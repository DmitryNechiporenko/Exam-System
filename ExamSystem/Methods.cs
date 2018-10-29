using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExamSystem
{

    class connection
    {
        public static string conString()
        {
            FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder();
            fb_con.Charset = "UTF8"; //используемая кодировка
            fb_con.UserID = "SYSDBA"; //логин
            fb_con.Password = "civssm"; //пароль
            fb_con.Database = "C:\\DB.FDB"; //путь к файлу базы данных
            fb_con.ServerType = 0; //указываем тип сервера (0 - "полноценный Firebird" (classic или super server), 1 - встроенный (embedded))

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
