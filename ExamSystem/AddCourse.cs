using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class AddCourse : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());

        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (CourseTextBox.Text.Length < 1)
            {
                MessageBox.Show("Введите название курса!");
                return;
            }

            fb.Open();

            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();
            FbCommand newID = new FbCommand("SELECT MAX(ID) FROM course", fb);
            newID.Transaction = fbt;
            FbDataReader reader1 = newID.ExecuteReader();
            reader1.Read();
            string newid = reader1[0].ToString();
            newID.Dispose();

            reader1.Close();

            try
            {
                int chislo = int.Parse(newid);
            }
            catch
            {
                newid = "1";
            }



            FbCommand InsertSQL = new FbCommand("INSERT INTO course VALUES (@ID, @NAME)", fb);

            InsertSQL.Parameters.Add("ID", FbDbType.Integer).Value = (int.Parse(newid) + 1);
            InsertSQL.Parameters.Add("NAME", FbDbType.Text).Value = CourseTextBox.Text;

            InsertSQL.Transaction = fbt;



            try
            {
                int res = InsertSQL.ExecuteNonQuery();
                MessageBox.Show("Добавлено!");
                fbt.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            InsertSQL.Dispose();
            fb.Close();
        }
    }
}
