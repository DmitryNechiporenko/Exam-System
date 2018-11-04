﻿using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System;
using System.Data;

namespace ExamSystem
{

    class connection
    {
        public static string conString()
        {
            FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder();
            string[] config = File.ReadAllLines(Path.Combine(Application.StartupPath, "config.txt"));
            foreach (string line in config)
            {
                string[] cfg = line.Split(' ');
                if (cfg[0] == "Charset")
                    fb_con.Charset = cfg[1];
                else if (cfg[0] == "UserID")
                    fb_con.UserID = cfg[1];
                else if (cfg[0] == "Password")
                    fb_con.Password = cfg[1];
            }
            fb_con.Database = Path.Combine(Application.StartupPath, "DB.FDB");
            fb_con.ServerType = 0; //тип сервера (0 - "полноценный Firebird" (classic или super server), 1 - встроенный (embedded))

            return fb_con.ToString();
        }
    }


    class LoadTo
    {
        public static void combobox(ComboBox box, string query)
        {
            FbConnection fb = new FbConnection(connection.conString());

            fb.Open();
            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand(query, fb);
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();
            var data1 = new List<P1>();

            while (reader.Read())
            {
                var mc = new P1
                {
                    Id = reader[0].ToString().Trim(),
                    Name = reader[1].ToString().Trim()
                };
                data1.Add(mc);
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();


            box.DataSource = data1;
            box.DisplayMember = "Name";
            box.ValueMember = "Id";
        }

        public static void listbox(ListBox box, string query)
        {
            FbConnection fb = new FbConnection(connection.conString());
            fb.Open();


            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand(query, fb);
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();

            box.Items.Clear();

            while (reader.Read())
            {
                box.Items.Add(reader[0].ToString());
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
        }
    }


    class calculate
    {
        public static double percentage(int examid)
        {
            string[] examinfo = new string[18];
            string[] questioninfo;
            string questions;
            string answers;
            

            FbConnection fb = new FbConnection(connection.conString());
            fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT * FROM exams WHERE id = " + examid, fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            reader.Read();
            for(int i = 0; i < 18; i++)
            {
                examinfo[i] = reader[i].ToString();
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            questions = examinfo[3] + ',' + examinfo[5] + ',' + examinfo[7] + ',' + examinfo[9] + ',' + examinfo[11];
            string[] q_array = questions.Split(',');
            answers = examinfo[4] + ',' + examinfo[6] + ',' + examinfo[8] + ',' + examinfo[10] + ',' + examinfo[12];
            string[] a_array = answers.Split(',');
            questioninfo = new string[questions.Split(',').Length];

            fb.Open();
            FbTransaction fbt1 = fb.BeginTransaction();
            FbCommand SelectSQL1 = new FbCommand("SELECT * FROM question WHERE id IN (" + questions + ")", fb);
            SelectSQL1.Transaction = fbt1;
            FbDataReader reader1 = SelectSQL1.ExecuteReader();
            for (int i = 0; i < questioninfo.Length; i++)
            {
                reader1.Read();
                    string foo = "";
                for (int z = 0; z < 8; z++)
                {
                    foo = foo + reader1[z].ToString() + "|";
                }
                questioninfo[i] = foo.Substring(0, foo.Length - 1);
            }
            reader1.Close();
            SelectSQL1.Dispose();
            fbt1.Commit();
            fb.Close();

            Dictionary<int, string> user_qa = new Dictionary<int, string>(q_array.Length);
            Dictionary<int, string> curr_qa = new Dictionary<int, string>(q_array.Length);
            for (int i = 0; i < q_array.Length; i++)
            {
                user_qa.Add(int.Parse(q_array[i]), a_array[i]);
                string[] foo = questioninfo[i].Split('|');
                curr_qa.Add(int.Parse(foo[0]), foo[7]);
            }

            return Math.Round(100*(q_array.Length - (double)user_qa.Except(curr_qa).Count())/((double)q_array.Length),2);
        }
    }

    class delete
    {
        public static void record(string query)
        {
            FbConnection fb = new FbConnection(connection.conString());
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand DeleteSQL = new FbCommand(query, fb);
            DeleteSQL.Transaction = fbt;
            try
            {
                DeleteSQL.ExecuteNonQuery();
                fbt.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DeleteSQL.Dispose();
            fb.Close();
        }
    }

    class P1
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
