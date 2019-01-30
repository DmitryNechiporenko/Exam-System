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
    public partial class FinalExamQuiz : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());
        int examid;
        int[] answers = Enumerable.Repeat<int>(0, 20).ToArray();
        MetroFramework.Controls.MetroButton[] qButtons = new MetroFramework.Controls.MetroButton[40];
        int rownum = 0;
        DataTable questions = new DataTable();

        public FinalExamQuiz(int examid)
        {
            InitializeComponent();

            questions.Columns.Add("ID", typeof(int));
            questions.Columns.Add("QUESTION", typeof(string));
            questions.Columns.Add("A1", typeof(string));
            questions.Columns.Add("A2", typeof(string));
            questions.Columns.Add("A3", typeof(string));
            questions.Columns.Add("A4", typeof(string));
            questions.Columns.Add("A_CURR", typeof(int));
            questions.Columns.Add("COMMENT", typeof(string));

            this.examid = examid;
           
            timer1.Start();
        }



        private void FinalExamQuiz_Load(object sender, EventArgs e)
        {
            foreach (var button in this.Controls.OfType<MetroFramework.Controls.MetroButton>())
            {
                int foo;
                if (int.TryParse(button.Text, out foo))
                    qButtons[int.Parse(button.Text) - 1] = button;
            }

            QuestionTextBox.Visible = true;
            Answer1Radio.Visible = true;
            Answer2Radio.Visible = true;
            Answer3Radio.Visible = true;
            Answer4Radio.Visible = true;
            Answer1TextBox.Visible = true;
            Answer2TextBox.Visible = true;
            Answer3TextBox.Visible = true;
            Answer4TextBox.Visible = true;

            get_questions("SELECT question.* FROM question, (SELECT id FROM GetIntegerList((SELECT questions FROM final_exams WHERE id = " + examid + "))) foo WHERE question.id = foo.id");

            for (int i = questions.Rows.Count; i < 40; i++)
                qButtons[i].Visible = false;

            ShowQuestion();
        }

        private void get_questions(string query)
        {
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand(query, fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();

            while (reader.Read())
                questions.Rows.Add(int.Parse(reader[0].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), int.Parse(reader[7].ToString()), reader[8].ToString());

            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
        }

        private void ShowQuestion()
        {
            QuestionTextBox.Text = questions.Rows[rownum][1].ToString();
            Answer1TextBox.Text = questions.Rows[rownum][2].ToString();
            Answer2TextBox.Text = questions.Rows[rownum][3].ToString();
            Answer3TextBox.Text = questions.Rows[rownum][4].ToString();
            Answer4TextBox.Text = questions.Rows[rownum][5].ToString();

            Answer1Radio.Enabled = true;
            Answer2Radio.Enabled = true;
            Answer3Radio.Enabled = true;
            Answer4Radio.Enabled = true;
            Answer1TextBox.Enabled = true;
            Answer2TextBox.Enabled = true;
            Answer3TextBox.Enabled = true;
            Answer4TextBox.Enabled = true;
            Answer1Radio.Checked = false;
            Answer2Radio.Checked = false;
            Answer3Radio.Checked = false;
            Answer4Radio.Checked = false;

            if (answers[rownum] == 1)
                Answer1Radio.Checked = true;
            else if (answers[rownum] == 2)
                Answer2Radio.Checked = true;
            else if (answers[rownum] == 3)
                Answer3Radio.Checked = true;
            else if (answers[rownum] == 4)
                Answer4Radio.Checked = true;

            QuesNumLabel.Text = "Вы на вопросе №" + (rownum + 1);
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (Answer1Radio.Checked)
                answers[rownum] = 1;
            else if (Answer2Radio.Checked)
                answers[rownum] = 2;
            else if (Answer3Radio.Checked)
                answers[rownum] = 3;
            else if (Answer4Radio.Checked)
                answers[rownum] = 4;
            else
            {
                MessageBox.Show("Выберите ответ");
                return;
            }

            qButtons[rownum].Highlight = true;
            qButtons[rownum].Refresh();
            metroButton1.Select();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FinalExamQuiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите завершить экзамен?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int answers_count = 0;
                for (int i = 0; i < questions.Rows.Count; i++)
                {
                    if ((int)questions.Rows[i][6] == answers[i])
                        answers_count++;
                }
                string timeSpend = "";
                if (minLabel.BackColor == Color.OrangeRed)
                    timeSpend = (20 + int.Parse(minLabel.Text)).ToString() + ":" + secLabel.Text;
                else
                    timeSpend = (19 - int.Parse(minLabel.Text)).ToString() + ":" + (60 - int.Parse(secLabel.Text)).ToString();
                string out_a = "";
                for (int i = 0; i < questions.Rows.Count; i++)
                    out_a = out_a + "," + answers[i];
                out_a = out_a.Substring(1);

                if (fb.State == ConnectionState.Closed)
                    fb.Open();

                FbTransaction fbt = fb.BeginTransaction();
                FbCommand UpdateSQL = new FbCommand("UPDATE final_exams SET answers = '" + out_a + "', exam_time = '" + timeSpend + "' WHERE final_exams.id = " + examid, fb);
                UpdateSQL.Transaction = fbt;

                try
                {
                    int res = UpdateSQL.ExecuteNonQuery();
                    timer1.Stop();
                    MessageBox.Show("Вы отетили правильно на " + answers_count + " вопросов из " + questions.Rows.Count + " (" + ((double)answers_count / (double)questions.Rows.Count) * 100 + "%)");
                    fbt.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                UpdateSQL.Dispose();
                fb.Close();
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (rownum > 0)
            {
                rownum--;
                ShowQuestion();
            }
            metroButton1.Select();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (rownum + 1 < questions.Rows.Count)
            {
                rownum++;
                ShowQuestion();
            }
            metroButton1.Select();
        }

        private void qButton_Click(object sender, EventArgs e)
        {
            rownum = int.Parse((sender as Button).Text) - 1;
            ShowQuestion();
            metroButton1.Select();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(secLabel.Text) == 0 && int.Parse(minLabel.Text) == 0)
            {
                secLabel.BackColor = Color.OrangeRed;
                splitLabel.BackColor = Color.OrangeRed;
                minLabel.BackColor = Color.OrangeRed;
            }

            if (secLabel.BackColor == Color.OrangeRed)
            {
                if (int.Parse(secLabel.Text) == 59)
                {
                    secLabel.Text = "00";
                    if (int.Parse(minLabel.Text) < 9)
                        minLabel.Text = "0" + (int.Parse(minLabel.Text) + 1);
                    else
                        minLabel.Text = (int.Parse(minLabel.Text) + 1).ToString();
                }
                else
                {
                    if (int.Parse(secLabel.Text) < 9)
                        secLabel.Text = "0" + (int.Parse(secLabel.Text) + 1);
                    else
                        secLabel.Text = (int.Parse(secLabel.Text) + 1).ToString();
                }
            }
            else
            {
                if (int.Parse(secLabel.Text) == 0)
                {
                    secLabel.Text = "59";

                    if (int.Parse(minLabel.Text) <= 10)
                        minLabel.Text = "0" + (int.Parse(minLabel.Text) - 1);
                    else
                        minLabel.Text = (int.Parse(minLabel.Text) - 1).ToString();
                }
                else
                {
                    if (int.Parse(secLabel.Text) <= 10)
                        secLabel.Text = "0" + (int.Parse(secLabel.Text) - 1);
                    else
                        secLabel.Text = (int.Parse(secLabel.Text) - 1).ToString();
                }
            }
        }
    }
}