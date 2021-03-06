﻿using FirebirdSql.Data.FirebirdClient;
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
    public partial class LearnQuiz : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());
        string all_blocks = "";
        DataTable questions = new DataTable();
        int num = 0;
        int currentcount = 0;

        public LearnQuiz(string[] blocklist)
        {
            InitializeComponent();

            foreach (string block in blocklist)
            {
                all_blocks = all_blocks + "'" + block + "'" + ",";
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

        private void get_questions(string foo)
        {
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT question.id, question.ques, question.a1, question.a2, question.a3, question.a4, question.a_curr, question.comment FROM question, block WHERE question.block_id = block.id AND block.name in (" + all_blocks + ") order by " + foo, fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            while (reader.Read())
                questions.Rows.Add(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString()), reader[7].ToString());
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
            Answer1Radio.Visible = true;
            Answer2Radio.Visible = true;
            Answer3Radio.Visible = true;
            Answer4Radio.Visible = true;
            Answer1TextBox.Visible = true;
            Answer2TextBox.Visible = true;
            Answer3TextBox.Visible = true;
            Answer4TextBox.Visible = true;
            AnswerButton.Visible = true;
            CommentButton.Visible = true;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            get_questions("question.ques");
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            get_questions("rand()");
        }

        private void ShowQuestion(int rownum)
        {
            QuestionTextBox.Text = questions.Rows[rownum][1].ToString();
            Answer1TextBox.Text = questions.Rows[rownum][2].ToString();
            Answer2TextBox.Text = questions.Rows[rownum][3].ToString();
            Answer3TextBox.Text = questions.Rows[rownum][4].ToString();
            Answer4TextBox.Text = questions.Rows[rownum][5].ToString();
            
            NextQuestionButton.Text = "Пропустить";
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
        }

        private int UserAnswer()
        {
            if (Answer1Radio.Checked == true)
                return 1;
            else if (Answer2Radio.Checked == true)
                return 2;
            else if (Answer3Radio.Checked == true)
                return 3;
            else if (Answer4Radio.Checked == true)
                return 4;
            else
                return -1;
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (UserAnswer() < 0)
            {
                MessageBox.Show("Выберите ответ");
                return;
            }
            if ((int)questions.Rows[num][6] == UserAnswer())
                currentcount++;
            else
                MessageBox.Show("ОТВЕТ НЕПРАВИЛЬНЫЙ! \n" + questions.Rows[num][7].ToString());

            NextQuestionButton.Text = "Продолжить";
            Answer1Radio.Enabled = false;
            Answer2Radio.Enabled = false;
            Answer3Radio.Enabled = false;
            Answer4Radio.Enabled = false;
            Answer1TextBox.Enabled = false;
            Answer2TextBox.Enabled = false;
            Answer3TextBox.Enabled = false;
            Answer4TextBox.Enabled = false;

            randomButton.Select();

            
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            if (NextQuestionButton.Text != "Завершить")
            {
                num++;
                ShowQuestion(num);
                if (num == questions.Rows.Count - 1)
                    NextQuestionButton.Text = "Завершить";

            }
            else
            {
                MessageBox.Show("Вы ответили правильно на " + currentcount + " из " + questions.Rows.Count + " вопросов! (" + Math.Round((((double)currentcount / questions.Rows.Count) * 100), 2) + "%)");
                Close();
            }
            
            randomButton.Select();
        }

        private void CommentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(questions.Rows[num][7].ToString());
            randomButton.Select(); 
        }


        private void LearnQuiz_Load(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Answer1Radio_VisibleChanged(object sender, EventArgs e)
        {
            Answer1TextBox.Visible = Answer1Radio.Visible;
        }

        private void Answer2Radio_VisibleChanged(object sender, EventArgs e)
        {
            Answer2TextBox.Visible = Answer2Radio.Visible;
        }

        private void Answer3Radio_VisibleChanged(object sender, EventArgs e)
        {
            Answer3TextBox.Visible = Answer3Radio.Visible;
        }

        private void Answer4Radio_VisibleChanged(object sender, EventArgs e)
        {
            Answer4TextBox.Visible = Answer4Radio.Visible;
        }
    }
}
