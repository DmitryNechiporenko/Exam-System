using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

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


    class P1
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
