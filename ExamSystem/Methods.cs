using FirebirdSql.Data.FirebirdClient;
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
                else if (cfg[0] == "Database")
                    fb_con.Database = Path.Combine(Application.StartupPath, cfg[1]);
            }
            fb_con.ServerType = 0;

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

            box.DataSource = data1.OrderBy(o=>o.Name).ToList();
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
                box.Items.Add(reader[0].ToString());
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
            box.Sorted = true;
        }
    }



    class calculate
    {
        public static double Percent(int examid, bool is_final = true)
        {
            FbConnection fb = new FbConnection(connection.conString());
            fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            string sql = "SELECT result FROM(SELECT questions, answers FROM final_exams WHERE id = " + examid + ") foo, GetPercent(foo.questions, foo.answers)";
            if (!is_final)
                sql = "SELECT result FROM(SELECT part1||','||part2||','||part3||','||part4||','||part5 as questions, part1_a||','||part2_a||','||part3_a||','||part4_a||','||part5_a as answers FROM exams WHERE id = " + examid + ") foo, GetPercent(foo.questions, foo.answers)";
            FbCommand SelectSQL = new FbCommand(sql, fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            reader.Read();
            double result = double.Parse(reader[0].ToString());
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
            return Math.Round(result, 2);
        }

        public static string PartPercent(int examid, string part)
        {
            FbConnection fb = new FbConnection(connection.conString());
            fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            string sql = "SELECT result FROM(SELECT " + part + " as questions, " + part + "_a as answers FROM exams WHERE id = " + examid + ") foo, GetPercent(foo.questions, foo.answers)";
            FbCommand SelectSQL = new FbCommand(sql, fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            reader.Read();
            double result = double.Parse(reader[0].ToString());
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
            return Math.Round(result, 2).ToString();
        }
    }

    class delete
    {
        public static void record(string query)
        {
            FbConnection fb = new FbConnection(connection.conString());
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
