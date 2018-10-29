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
    public partial class ViewExam : Form
    {
        FbConnection fb = new FbConnection(connection.conString());

        string[] examinfo = new string[18];
        int examid;
        DataTable questions = new DataTable();

        public ViewExam(int examid)
        {
            InitializeComponent();

            fb.Open();

            this.examid = examid;

            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand("SELECT * FROM exams WHERE id = " + examid, fb);
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();
            reader.Read();
            for (int i = 0; i < 18; i++)
            {
                examinfo[i] = reader[i].ToString();
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            int min = 0;
            int sec = 0; 
            for (int i = 13; i < 18; i++)
            {
                string[] time = examinfo[i].Split(':');
                if (time.Count() > 1)
                {
                    min = min + int.Parse(time[0]);
                    sec = sec + int.Parse(time[1]);
                }
            }
            ExamTimeLabel.Text = ExamTimeLabel.Text + min.ToString() + ":" + sec.ToString();

            CompleteLabel.Text = "Экзамен завершен";

            for (int i = 13; i < 18; i++)
            {
                if (examinfo[i].Length == 0)
                {
                    CompleteLabel.Text = "Экзамен не заверешен";
                    break;
                }
            }

            PartComboBox.SelectedIndex = 0;
        }

        private void PartComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                QuestionsListBox.Items.Clear();

                foreach (string s in get_questions_id())
                {
                    QuestionsListBox.Items.Add(get_question("SELECT ques FROM question WHERE id = " + s));
                }

                if (QuestionsListBox.Items.Count > 0)
                {
                    QuestionsListBox.SelectedIndex = 0;
                    QuestionsListBox_SelectedValueChanged(sender, e);
                }
            }
            catch { fb.Close(); }
        }

        private string get_question(string query)
        {
            string q = "";
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
                q = reader[0].ToString();
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            return q;
        }

        private string[] get_questions_id()
        {
            string part = PartComboBox.SelectedItem.ToString();
            if (part == "Часть 1")
            {
                part = "PART1";
            }
            else if(part == "Часть 2")
            {
                part = "PART2";
            }
            else if(part == "Часть 3")
            {
                part = "PART3";
            }
            else if (part == "Часть 4")
            {
                part = "PART4";
            }
            else if (part == "Часть 5")
            {
                part = "PART5";
            }
            if (fb.State == ConnectionState.Closed)
            {
                fb.Open();
            }
            
            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand("SELECT " + part + " FROM exams WHERE exams.id = " + examid, fb);
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();
            string foo = "";
            while (reader.Read())
            {
                foo = reader[0].ToString();
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            string[] questionsid = new string[foo.Split(',').Count()];
            int bar = 0;
            foreach (string s in foo.Split(','))
            {
                questionsid[bar] = s;
                bar++;
            }
            return questionsid;
        }


        private void QuestionsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                QuestionTextBox.Text = QuestionsListBox.SelectedItem.ToString();
                string q = "";
                if (fb.State == ConnectionState.Closed)
                {
                    fb.Open();
                }
                FbTransaction fbt = fb.BeginTransaction();

                FbCommand SelectSQL = new FbCommand("SELECT a1, a2, a3, a4, a_curr FROM question WHERE ques = '" + QuestionsListBox.SelectedItem.ToString() + "'", fb);
                SelectSQL.Transaction = fbt;

                FbDataReader reader = SelectSQL.ExecuteReader();
                reader.Read();

                CurrentAnswerTextBox.Text = reader[int.Parse(reader[4].ToString()) - 1].ToString();

                int answerid;


                string foo = examinfo[get_part_id_in_exams()].Split(',')[QuestionsListBox.SelectedIndex];
                if (foo.Length > 0)
                    answerid = int.Parse(foo) - 1;
                else
                    answerid = -1;

                if (answerid != -1)
                    UserAnswerTextBox.Text = reader[answerid].ToString();
                else
                    UserAnswerTextBox.Text = "Нет ответа";

                reader.Close();
                SelectSQL.Dispose();
                fbt.Commit();
                fb.Close();
            }
            catch { }
        }

        private int get_part_id_in_exams()
        {
            string part = PartComboBox.SelectedItem.ToString();
            if (part == "Часть 1")
            {
                return 4;
            }
            else if (part == "Часть 2")
            {
                return 6;
            }
            else if (part == "Часть 3")
            {
                return 8;
            }
            else if (part == "Часть 4")
            {
                return 10;
            }
            else
            {
                return 12;
            }
        }
    }
}
