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
    public partial class FinalExamForm : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());

        int userid, examid;
        double[] examresult = { 0, 0, 0, 0, 0 };

        public FinalExamForm(int userid)
        {
            InitializeComponent();

            this.userid = userid;

            fb.Open();
            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand("SELECT * FROM users WHERE id = " + this.userid, fb);
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();
            if (reader.Read())
                UserNameLabel.Text = reader[2].ToString() + " " + reader[1].ToString() + " " + reader[3].ToString();

            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
        }

        private void FinalExamForm_Load(object sender, EventArgs e)
        {
            LoadTo.combobox(CourseComboBox, "SELECT * FROM course");
        }

        private void CourseComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            updateExamResult();
        }


        private string get_questions(int courseid)
        {
            string questions = "";
            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand("SELECT FIRST 40 id, block_id FROM question WHERE block_id IN ( SELECT block.id FROM block WHERE course_id = " + courseid + ") order by rand()", fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();

            Dictionary<string, string> ques = new Dictionary<string, string>();
            while (reader.Read())
            {
                if (ques.ContainsKey(reader[1].ToString()))
                {
                    if (ques[reader[1].ToString()].Count(f => f == ',') < 2)
                        ques[reader[1].ToString()] = ques[reader[1].ToString()] + ',' + reader[0].ToString();
                }
                else
                    ques.Add(reader[1].ToString(), reader[0].ToString());
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            
            foreach(var foo in ques.Keys)
                questions = questions + "," + ques[foo];

            questions = questions.Substring(1);

            return questions;
        }


        private void CreateExamButton_Click(object sender, EventArgs e)
        {
            if (CourseComboBox.Text.Length < 1)
            {
                MessageBox.Show("Выберите курс!");
                return;
            }

            string questions = get_questions(int.Parse(CourseComboBox.SelectedValue.ToString()));

            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();
            FbCommand newID = new FbCommand("SELECT MAX(ID) FROM final_exams", fb);
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

            FbCommand InsertSQL = new FbCommand("INSERT INTO final_exams VALUES (@ID, @USER_ID, @COURSE_ID, @QUESTIONS, @NOTHING, @NOTHING)", fb);

            InsertSQL.Parameters.Add("ID", FbDbType.Integer).Value = int.Parse(newid) + 1;
            InsertSQL.Parameters.Add("USER_ID", FbDbType.Integer).Value = userid;
            InsertSQL.Parameters.Add("COURSE_ID", FbDbType.Integer).Value = int.Parse(CourseComboBox.SelectedValue.ToString());
            InsertSQL.Parameters.Add("NOTHING", FbDbType.Text).Value = "";
            InsertSQL.Parameters.Add("QUESTIONS", FbDbType.Text).Value = questions;
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

            examid = int.Parse(newid) + 1;

            InsertSQL.Dispose();
            fb.Close();
            CreateExamButton.Visible = false;

            updateExamResult();
        }

        private void StartExamButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите начать экзамен?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                FinalExamQuiz eq = new FinalExamQuiz(examid);
                eq.Closed += (s, args) => { this.Show(); this.updateExamResult(); };
                eq.Show();
            }
        }

        private void updateExamResult()
        {
            try
            {
                int CourseId = int.Parse(CourseComboBox.SelectedValue.ToString());
                if (fb.State == ConnectionState.Closed)
                    fb.Open();

                FbTransaction fbt = fb.BeginTransaction();

                FbCommand SelectSQL = new FbCommand("SELECT * FROM final_exams WHERE course_id=" + CourseId + " AND user_id = " + userid, fb);
                SelectSQL.Transaction = fbt;

                FbDataReader reader = SelectSQL.ExecuteReader();

                StartExamButton.Enabled = true;

                if (reader.Read())
                {
                    ExamLabel.Visible = false;
                    CreateExamButton.Visible = false;
                    StartExamButton.Visible = true;

                    examid = int.Parse(reader[0].ToString());

                    if (reader[5].ToString().Length > 0)
                        StartExamButton.Enabled = false;
                }
                else
                {
                    ExamLabel.Visible = true;
                    CreateExamButton.Visible = true;
                    StartExamButton.Visible = false;
                }
                reader.Close();
                SelectSQL.Dispose();
                fbt.Commit();
                fb.Close();


                ResultLabel.Visible = !CreateExamButton.Visible;
                RefreshExamButton.Visible = false;
                ReportButton.Visible = false;
                GoToLearnButton.Visible = false;

                if (!StartExamButton.Enabled)
                {
                    //examresult = calculate.percentage(this.examid, false);
                    ResultLabel.Text = "Результат: " + examresult[0] + "%";

                    if (examresult[0] >= 75)
                    {
                        ReportButton.Visible = true;
                        RefreshExamButton.Visible = false;
                        GoToLearnButton.Visible = false;
                        ResultLabel.Text = ResultLabel.Text + " (экзамен сдан)";
                    }
                    else
                    {
                        RefreshExamButton.Visible = true;
                        GoToLearnButton.Visible = true;
                        ReportButton.Visible = false;
                        ResultLabel.Text = ResultLabel.Text + " (экзамен не сдан)";
                    }
                }
                else
                    ResultLabel.Text = "Экзамен не завершён";
            }
            catch
            {

            }
        }

    }
}
