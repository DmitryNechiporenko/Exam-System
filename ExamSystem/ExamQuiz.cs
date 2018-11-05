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
    public partial class ExamQuiz : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());
        int examid;
        string part, partTime = "";
        int[] answers = new int[20];
        string[] q;
        int rownum = 0;

        DataTable questions = new DataTable();

        public ExamQuiz(int examid, int part)
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
            if (part == 1)
            {
                this.part = "PART1";
                this.partTime = "P1_TIME";
            }
            else if (part == 2)
            {
                this.part = "PART2";
                this.partTime = "P2_TIME";
            }
            else if (part == 3)
            {
                this.part = "PART3";
                this.partTime = "P3_TIME";
            }
            else if (part == 4)
            {
                this.part = "PART4";
                this.partTime = "P4_TIME";
            }
            else
            {
                this.part = "PART5";
                this.partTime = "P5_TIME";
            }

            for (int i = 0; i < 20; i++)
            {
                answers[i] = -1;
            }
            timer1.Start();
        }

        private void ExamQuiz_Load(object sender, EventArgs e)
        {
            QuestionTextBox.Visible = true;
            Answer1Radio.Visible = true;
            Answer2Radio.Visible = true;
            Answer3Radio.Visible = true;
            Answer4Radio.Visible = true;
            if (fb.State == ConnectionState.Closed)
            {
                fb.Open();
            }
            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand("SELECT " + part + " FROM exams WHERE id = " + examid, fb);
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();
            reader.Read();
            q = reader[0].ToString().Split(',');
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            foreach (var foo in q)
            {
                get_questions("SELECT * FROM question WHERE id = " + int.Parse(foo) + "");
            }

            disable_buttons();
            ShowQuestion();
        }

        private void get_questions(string query)
        {
            if (fb.State == ConnectionState.Closed)
            {
                fb.Open();
            }
            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand(query, fb);
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();
            while (reader.Read())
            {
                questions.Rows.Add(int.Parse(reader[0].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), int.Parse(reader[7].ToString()), reader[8].ToString());
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
        }

        private void ShowQuestion()
        {
            QuestionTextBox.Text = questions.Rows[rownum][1].ToString();
            Answer1Radio.Text = questions.Rows[rownum][2].ToString();
            Answer2Radio.Text = questions.Rows[rownum][3].ToString();
            Answer3Radio.Text = questions.Rows[rownum][4].ToString();
            Answer4Radio.Text = questions.Rows[rownum][5].ToString();

            Answer1Radio.Enabled = true;
            Answer2Radio.Enabled = true;
            Answer3Radio.Enabled = true;
            Answer4Radio.Enabled = true;
            Answer1Radio.Checked = false;
            Answer2Radio.Checked = false;
            Answer3Radio.Checked = false;
            Answer4Radio.Checked = false;

            if (answers[rownum] == 1)
            {
                Answer1Radio.Checked = true;
            }
            else if (answers[rownum] == 2)
            {
                Answer2Radio.Checked = true;
            }
            else if (answers[rownum] == 3)
            {
                Answer3Radio.Checked = true;
            }
            else if (answers[rownum] == 4)
            {
                Answer4Radio.Checked = true;
            }
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (Answer1Radio.Checked)
            {
                answers[rownum] = 1;
            }
            else if (Answer2Radio.Checked)
            {
                answers[rownum] = 2;
            }
            else if (Answer3Radio.Checked)
            {
                answers[rownum] = 3;
            }
            else if (Answer4Radio.Checked)
            {
                answers[rownum] = 4;
            }
            if (rownum == 0)
            {
                q1Button.Highlight = true;
                q1Button.Refresh();
            }
            if (rownum == 1)
            {
                q2Button.Highlight = true;
                q2Button.Refresh();
            }
            if (rownum == 2)
            {
                q3Button.Highlight = true;
                q3Button.Refresh();
            }
            if (rownum == 3)
            {
                q4Button.Highlight = true;
                q4Button.Refresh();
            }
            if (rownum == 4)
            {
                q5Button.Highlight = true;
                q5Button.Refresh();
            }
            if (rownum == 5)
            {
                q6Button.Highlight = true;
                q6Button.Refresh();
            }
            if (rownum == 6)
            {
                q7Button.Highlight = true;
                q7Button.Refresh();
            }
            if (rownum == 7)
            {
                q8Button.Highlight = true;
                q8Button.Refresh();
            }
            if (rownum == 8)
            {
                q9Button.Highlight = true;
                q9Button.Refresh();
            }
            if (rownum == 9)
            {
                q10Button.Highlight = true;
                q10Button.Refresh();
            }
            if (rownum == 10)
            {
                q11Button.Highlight = true;
                q11Button.Refresh();
            }
            if (rownum == 11)
            {
                q12Button.Highlight = true;
                q12Button.Refresh();
            }
            if (rownum == 12)
            {
                q13Button.Highlight = true;
                q13Button.Refresh();
            }
            if (rownum == 13)
            {
                q14Button.Highlight = true;
                q14Button.Refresh();
            }
            if (rownum == 14)
            {
                q15Button.Highlight = true;
                q15Button.Refresh();
            }
            if (rownum == 15)
            {
                q16Button.Highlight = true;
                q16Button.Refresh();
            }
            if (rownum == 16)
            {
                q17Button.Highlight = true;
                q17Button.Refresh();
            }
            if (rownum == 17)
            {
                q18Button.Highlight = true;
                q18Button.Refresh();
            }
            if (rownum == 18)
            {
                q19Button.Highlight = true;
                q19Button.Refresh();
            }
            if (rownum == 19)
            {
                q20Button.Highlight = true;
                q20Button.Refresh();
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExamQuiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите завершить экзамен?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int answers_count = 0;
                for (int i = 0; i < questions.Rows.Count; i++)
                {
                    if ((int)questions.Rows[i][6] == answers[i])
                    {
                        answers_count++;
                    }
                }
                string timeSpend = "";
                if (minLabel.BackColor == Color.OrangeRed)
                {
                    timeSpend = (20 + int.Parse(minLabel.Text)).ToString() + ":" + secLabel.Text;
                }
                else
                {
                    timeSpend = (19 - int.Parse(minLabel.Text)).ToString() + ":" + (60 - int.Parse(secLabel.Text)).ToString();
                }
                string out_a = "";
                for (int i = 0; i < questions.Rows.Count; i++)
                {
                    if (answers[i] != -1)
                    {
                        out_a = out_a + answers[i] + ",";
                    }
                    else
                    {
                        out_a = out_a + ",";
                    }
                }
                out_a = out_a.Substring(0, out_a.Length - 1);

                if (fb.State == ConnectionState.Closed)
                    fb.Open();

                FbTransaction fbt = fb.BeginTransaction();

                FbCommand UpdateSQL = new FbCommand("UPDATE exams SET " + part + "_A = '" + out_a + "', " + partTime + " = '" + timeSpend + "' WHERE exams.id = " + examid, fb);


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
            {
                e.Cancel = true;
            }

        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            rownum = 0;
            ShowQuestion();
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            rownum = 1;
            ShowQuestion();
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            rownum = 2;
            ShowQuestion();
        }

        private void q4Button_Click(object sender, EventArgs e)
        {
            rownum = 3;
            ShowQuestion();
        }

        private void q5Button_Click(object sender, EventArgs e)
        {
            rownum = 4;
            ShowQuestion();
        }

        private void q6Button_Click(object sender, EventArgs e)
        {
            rownum = 5;
            ShowQuestion();
        }

        private void q7Button_Click(object sender, EventArgs e)
        {
            rownum = 6;
            ShowQuestion();
        }

        private void q8Button_Click(object sender, EventArgs e)
        {
            rownum = 7;
            ShowQuestion();
        }

        private void q9Button_Click(object sender, EventArgs e)
        {
            rownum = 8;
            ShowQuestion();
        }

        private void q10Button_Click(object sender, EventArgs e)
        {
            rownum = 9;
            ShowQuestion();
        }

        private void q11Button_Click(object sender, EventArgs e)
        {
            rownum = 10;
            ShowQuestion();
        }

        private void q12Button_Click(object sender, EventArgs e)
        {
            rownum = 11;
            ShowQuestion();
        }

        private void q13Button_Click(object sender, EventArgs e)
        {
            rownum = 12;
            ShowQuestion();
        }

        private void q14Button_Click(object sender, EventArgs e)
        {
            rownum = 13;
            ShowQuestion();
        }

        private void q15Button_Click(object sender, EventArgs e)
        {
            rownum = 14;
            ShowQuestion();
        }

        private void q16Button_Click(object sender, EventArgs e)
        {
            rownum = 15;
            ShowQuestion();
        }

        private void q17Button_Click(object sender, EventArgs e)
        {
            rownum = 16;
            ShowQuestion();
        }

        private void q18Button_Click(object sender, EventArgs e)
        {
            rownum = 17;
            ShowQuestion();
        }

        private void q19Button_Click(object sender, EventArgs e)
        {
            rownum = 18;
            ShowQuestion();
        }

        private void q20Button_Click(object sender, EventArgs e)
        {
            rownum = 19;
            ShowQuestion();
        }



        private void NextButton_Click(object sender, EventArgs e)
        {
            if (rownum + 1 < questions.Rows.Count)
            {
                rownum++;
                ShowQuestion();
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (rownum > 0)
            {
                rownum--;
                ShowQuestion();
            }
        }

        private void disable_buttons()
        {
            if (questions.Rows.Count < 20)
            {
                q20Button.Visible = false;
            }
            if (questions.Rows.Count < 19)
            {
                q19Button.Visible = false;
            }
            if (questions.Rows.Count < 18)
            {
                q18Button.Visible = false;
            }
            if (questions.Rows.Count < 17)
            {
                q17Button.Visible = false;
            }
            if (questions.Rows.Count < 16)
            {
                q16Button.Visible = false;
            }
            if (questions.Rows.Count < 15)
            {
                q15Button.Visible = false;
            }
            if (questions.Rows.Count < 14)
            {
                q14Button.Visible = false;
            }
            if (questions.Rows.Count < 13)
            {
                q13Button.Visible = false;
            }
            if (questions.Rows.Count < 12)
            {
                q12Button.Visible = false;
            }
            if (questions.Rows.Count < 11)
            {
                q11Button.Visible = false;
            }
            if (questions.Rows.Count < 10)
            {
                q10Button.Visible = false;
            }
            if (questions.Rows.Count < 9)
            {
                q9Button.Visible = false;
            }
            if (questions.Rows.Count < 8)
            {
                q8Button.Visible = false;
            }
            if (questions.Rows.Count < 7)
            {
                q7Button.Visible = false;
            }
            if (questions.Rows.Count < 6)
            {
                q6Button.Visible = false;
            }
            if (questions.Rows.Count < 5)
            {
                q5Button.Visible = false;
            }
            if (questions.Rows.Count < 4)
            {
                q4Button.Visible = false;
            }
            if (questions.Rows.Count < 3)
            {
                q3Button.Visible = false;
            }
            if (questions.Rows.Count < 2)
            {
                q2Button.Visible = false;
            }
            if (questions.Rows.Count < 1)
            {
                q1Button.Visible = false;
            }
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
                    {
                        minLabel.Text = "0" + (int.Parse(minLabel.Text) + 1);
                    }
                    else
                    {
                        minLabel.Text = (int.Parse(minLabel.Text) + 1).ToString();
                    }
                }
                else
                {
                    if (int.Parse(secLabel.Text) < 9)
                    {
                        secLabel.Text = "0" + (int.Parse(secLabel.Text) + 1);
                    }
                    else
                    {
                        secLabel.Text = (int.Parse(secLabel.Text) + 1).ToString();
                    }
                }
            }
            else
            {
                if (int.Parse(secLabel.Text) == 0)
                {
                    secLabel.Text = "59";

                    if (int.Parse(minLabel.Text) <= 10)
                    {
                        minLabel.Text = "0" + (int.Parse(minLabel.Text) - 1);
                    }
                    else
                    {
                        minLabel.Text = (int.Parse(minLabel.Text) - 1).ToString();
                    }
                }
                else
                {
                    if (int.Parse(secLabel.Text) <= 10)
                    {
                        secLabel.Text = "0" + (int.Parse(secLabel.Text) - 1);
                    }
                    else
                    {
                        secLabel.Text = (int.Parse(secLabel.Text) - 1).ToString();
                    }
                }
            }
        }
    }
}
