using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace ExamSystem
{
    public partial class AddQuestion : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());

        public AddQuestion()
        {
            InitializeComponent();
        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            LoadTo.combobox(CourseComboBox, "SELECT * FROM course");
        }

        private void CourseComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(CourseComboBox.SelectedValue.ToString());

                LoadTo.combobox(BlockComboBox, "SELECT id, name FROM block WHERE course_id=" + i);
            }
            catch { }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int a_curr;
            if (A1Radio.Checked == true)
            {
                a_curr = 1;
            }
            else if(A2Radio.Checked == true)
            {
                a_curr = 2;
            }
            else if(A3Radio.Checked == true)
            {
                a_curr = 3;
            }
            else if(A4Radio.Checked == true)
            {
                a_curr = 4;
            }
            else
            {
                MessageBox.Show("Укажите правильный ответ!");
                return;
            }

            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();
            FbCommand newID = new FbCommand("SELECT MAX(ID) FROM question", fb);
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


            FbCommand InsertSQL = new FbCommand("INSERT INTO question VALUES (@ID, @BLOCK_ID, @QUES, @A1, @A2, @A3, @A4, @A_CURR, @COMMENT)", fb);

            InsertSQL.Parameters.Add("ID", FbDbType.Integer).Value = (int.Parse(newid) + 1);
            InsertSQL.Parameters.Add("BLOCK_ID", FbDbType.Integer).Value = int.Parse(BlockComboBox.SelectedValue.ToString());
            InsertSQL.Parameters.Add("QUES", FbDbType.Text).Value = QuestionTextBox.Text.Trim();
            InsertSQL.Parameters.Add("A1", FbDbType.Text).Value = A1TextBox.Text.Trim();
            InsertSQL.Parameters.Add("A2", FbDbType.Text).Value = A2TextBox.Text.Trim();
            InsertSQL.Parameters.Add("A3", FbDbType.Text).Value = A3TextBox.Text.Trim();
            InsertSQL.Parameters.Add("A4", FbDbType.Text).Value = A4TextBox.Text.Trim();
            InsertSQL.Parameters.Add("A_CURR", FbDbType.Integer).Value = a_curr;
            InsertSQL.Parameters.Add("COMMENT", FbDbType.Text).Value = commentTextBox.Text.Trim();

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
