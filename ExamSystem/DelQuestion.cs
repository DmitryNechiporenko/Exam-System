using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class DelQuestion : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());

        public DelQuestion()
        {
            InitializeComponent();
        }

        private void DelQuestion_Load(object sender, EventArgs e)
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

        private void BlockComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(BlockComboBox.SelectedValue.ToString());

                LoadTo.combobox(QuesComboBox, "SELECT id, ques FROM question WHERE block_id=" + i);
            }
            catch { }
        }

        private void QuesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int qID = int.Parse(QuesComboBox.SelectedValue.ToString());

                if (fb.State == ConnectionState.Closed)
                    fb.Open();
                FbTransaction fbt = fb.BeginTransaction();
                FbCommand SelectSQL = new FbCommand("SELECT * FROM question WHERE id=" + qID, fb);
                SelectSQL.Transaction = fbt;
                FbDataReader reader = SelectSQL.ExecuteReader();
                while (reader.Read())
                {
                    QuestionTextBox.Text = reader[2].ToString().Trim();
                    A1TextBox.Text = reader[3].ToString().Trim();
                    A2TextBox.Text = reader[4].ToString().Trim();
                    A3TextBox.Text = reader[5].ToString().Trim();
                    A4TextBox.Text = reader[6].ToString().Trim();
                    commentTextBox.Text = reader[8].ToString().Trim();
                    int curr_a = int.Parse(reader[7].ToString());
                    if (curr_a == 1)
                        A1Radio.Checked = true;
                    else if (curr_a == 2)
                        A2Radio.Checked = true;
                    else if (curr_a == 3)
                        A3Radio.Checked = true;
                    else
                        A4Radio.Checked = true;
                }
                reader.Close();
                SelectSQL.Dispose();
                fbt.Commit();
                fb.Close();
            }
            catch { }
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            int a_curr;
            if (A1Radio.Checked == true)
                a_curr = 1;
            else if (A2Radio.Checked == true)
                a_curr = 2;
            else if (A3Radio.Checked == true)
                a_curr = 3;
            else
                a_curr = 4;

            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            int qID = int.Parse(QuesComboBox.SelectedValue.ToString());
            FbCommand UpdateSQL = new FbCommand("UPDATE question SET block_id = @BLOCK_ID, ques = @QUES, a1 = @A1, a2 = @A2, a3 = @A3, a4 = @A4, a_curr = @A_CURR, comment = @COMMENT WHERE id = " + qID, fb);
            UpdateSQL.Parameters.Add("BLOCK_ID", FbDbType.Integer).Value = int.Parse(BlockComboBox.SelectedValue.ToString());
            UpdateSQL.Parameters.Add("QUES", FbDbType.Text).Value = QuestionTextBox.Text.Replace("\n", " ").Replace("\r", "").Trim();
            UpdateSQL.Parameters.Add("A1", FbDbType.Text).Value = A1TextBox.Text.Replace("\n", " ").Replace("\r", "").Trim();
            UpdateSQL.Parameters.Add("A2", FbDbType.Text).Value = A2TextBox.Text.Replace("\n", " ").Replace("\r", "").Trim();
            UpdateSQL.Parameters.Add("A3", FbDbType.Text).Value = A3TextBox.Text.Replace("\n", " ").Replace("\r", "").Trim();
            UpdateSQL.Parameters.Add("A4", FbDbType.Text).Value = A4TextBox.Text.Replace("\n", " ").Replace("\r", "").Trim();
            UpdateSQL.Parameters.Add("A_CURR", FbDbType.Integer).Value = a_curr;
            UpdateSQL.Parameters.Add("COMMENT", FbDbType.Text).Value = commentTextBox.Text.Replace("\n", " ").Replace("\r", "").Trim();
            UpdateSQL.Transaction = fbt;
            try
            {
                UpdateSQL.ExecuteNonQuery();
                MessageBox.Show("Изменено!");
                fbt.Commit();
                UpdateSQL.Dispose();
                fb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            metroButton1.Select();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            int qID = int.Parse(QuesComboBox.SelectedValue.ToString());
            FbCommand DeleteSQL = new FbCommand("DELETE FROM question WHERE id = " + qID, fb);
            DeleteSQL.Transaction = fbt;
            try
            {
                DeleteSQL.ExecuteNonQuery();
                MessageBox.Show("Удалено!");
                fbt.Commit();
                DeleteSQL.Dispose();
                fb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BlockComboBox_SelectedValueChanged(sender, e);
            metroButton1.Select();
        }
    }
}
