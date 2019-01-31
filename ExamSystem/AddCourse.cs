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
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand InsertSQL = new FbCommand("INSERT INTO course (name) VALUES (@NAME)", fb);
            InsertSQL.Parameters.Add("NAME", FbDbType.Text).Value = CourseTextBox.Text.Replace("\n", " ").Replace("\r", "").Trim();
            InsertSQL.Transaction = fbt;
            try
            {
                InsertSQL.ExecuteNonQuery();
                MessageBox.Show("Добавлено!");
                fbt.Commit();
                InsertSQL.Dispose();
                fb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
