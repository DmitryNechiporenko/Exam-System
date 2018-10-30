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
    public partial class LearnQuiz : Form
    {
        FbConnection fb = new FbConnection(connection.conString());
        string all_blocks = "";
        DataTable questions = new DataTable();
        int num = 0;
        int currentcount = 0;

        public LearnQuiz(string[] input_arr)
        {
            InitializeComponent();

            foreach (string st in input_arr)
            {
                all_blocks = all_blocks + "'" + st + "'" + ",";
            }
            all_blocks = all_blocks.Substring(0, all_blocks.Length - 1);

            questions.Columns.Add("ID", typeof(int));
            questions.Columns.Add("QUESTION", typeof(string));
            questions.Columns.Add("A1", typeof(string));
            questions.Columns.Add("A2", typeof(string));
            questions.Columns.Add("A3", typeof(string));
            questions.Columns.Add("A4", typeof(string));
            questions.Columns.Add("A_CURR", typeof(int));
            questions.Columns.Add("COMMENT", typeof(string));
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
                questions.Rows.Add(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString()), reader[7].ToString());
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            ShowQuestion(0);

            AnswerButton.Visible = true;
            NextQuestionButton.Visible = true;
            orderButton.Visible = false;
            randomButton.Visible = false;
            QuestionTextBox.Visible = true;
            Answer1Label.Visible = true;
            Answer1Radio.Visible = true;
            Answer2Label.Visible = true;
            Answer2Radio.Visible = true;
            Answer3Label.Visible = true;
            Answer3Radio.Visible = true;
            Answer4Label.Visible = true;
            Answer4Radio.Visible = true;
            AnswerButton.Visible = true;
            CommentButton.Visible = true;

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            get_questions("SELECT question.id, question.ques, question.a1, question.a2, question.a3, question.a4, question.a_curr, question.comment FROM question, block WHERE question.block_id = block.id AND block.name in (" + all_blocks + ")");
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            get_questions("SELECT question.id, question.ques, question.a1, question.a2, question.a3, question.a4, question.a_curr, question.comment FROM question, block WHERE question.block_id = block.id AND block.name in (" + all_blocks + ") order by rand()");
        }

        private void ShowQuestion(int rownum)
        {
            QuestionTextBox.Text = questions.Rows[rownum][1].ToString();
            Answer1Label.Text = questions.Rows[rownum][2].ToString();
            Answer2Label.Text = questions.Rows[rownum][3].ToString();
            Answer3Label.Text = questions.Rows[rownum][4].ToString();
            Answer4Label.Text = questions.Rows[rownum][5].ToString();
            
            NextQuestionButton.Text = "Пропустить";
            AnswerButton.BackColor = Color.WhiteSmoke;
            Answer1Radio.Enabled = true;
            Answer2Radio.Enabled = true;
            Answer3Radio.Enabled = true;
            Answer4Radio.Enabled = true;
            Answer1Radio.Checked = false;
            Answer2Radio.Checked = false;
            Answer3Radio.Checked = false;
            Answer4Radio.Checked = false;
            Answer1Label.Enabled = true;
            Answer2Label.Enabled = true;
            Answer3Label.Enabled = true;
            Answer4Label.Enabled = true;
        }

        private int UserAnswer()
        {
            if (Answer1Radio.Checked == true)
            {
                return 1;
            }
            else if (Answer2Radio.Checked == true)
            {
                return 2;
            }
            else if (Answer3Radio.Checked == true)
            {
                return 3;
            }
            else if (Answer4Radio.Checked == true)
            {
                return 4;
            }
            else
            {
                return -1;
            }
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            
            if ((int)questions.Rows[num][6] == UserAnswer())
            {
                currentcount++;
                AnswerButton.BackColor = Color.LightGreen;
                NextQuestionButton.Text = "Продолжить";
                Answer1Radio.Enabled = false;
                Answer2Radio.Enabled = false;
                Answer3Radio.Enabled = false;
                Answer4Radio.Enabled = false;
                Answer1Label.Enabled = false;
                Answer2Label.Enabled = false;
                Answer3Label.Enabled = false;
                Answer4Label.Enabled = false;
            }
            else
            {
                
                AnswerButton.BackColor = Color.OrangeRed;
                NextQuestionButton.Text = "Продолжить";
                Answer1Radio.Enabled = false;
                Answer2Radio.Enabled = false;
                Answer3Radio.Enabled = false;
                Answer4Radio.Enabled = false;
                Answer1Label.Enabled = false;
                Answer2Label.Enabled = false;
                Answer3Label.Enabled = false;
                Answer4Label.Enabled = false;
                MessageBox.Show("ОТВЕТ НЕПРАВИЛЬНЫЙ! \n" + questions.Rows[num][7].ToString());
                
            }
            
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            if (num < questions.Rows.Count)
            {
                num++;
                if (num < questions.Rows.Count)
                {
                    ShowQuestion(num);
                }
                else
                {
                    NextQuestionButton.Text = "Завершить";
                }
            }
            else
            {
                num = 0;
                MessageBox.Show("Вы ответили правильно на " + currentcount + " из " + questions.Rows.Count + " вопросов! (" + (((double)currentcount / questions.Rows.Count)*100) + "%)");
                Close();
            }
            
        }

        private void CommentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(questions.Rows[num][7].ToString());
        }

        private void Answer1Label_Click(object sender, EventArgs e)
        {
            Answer1Radio.Checked = true;
        }

        private void Answer2Label_Click(object sender, EventArgs e)
        {
            Answer2Radio.Checked = true;
        }

        private void Answer3Label_Click(object sender, EventArgs e)
        {
            Answer3Radio.Checked = true;
        }

        private void Answer4Label_Click(object sender, EventArgs e)
        {
            Answer4Radio.Checked = true;
        }
    }
}
