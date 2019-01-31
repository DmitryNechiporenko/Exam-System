using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ExamSystem
{
    public partial class FinalExamForm : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());
        int userid, examid;
        DataTable user_exams = new DataTable();

        public FinalExamForm(int userid)
        {
            InitializeComponent();

            user_exams.Columns.Add("id", typeof(int));
            user_exams.Columns.Add("course_id", typeof(int));
            user_exams.Columns.Add("exam_time", typeof(string));

            this.userid = userid;

            fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT * FROM users WHERE id = " + this.userid, fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            reader.Read();
            UserNameLabel.Text = reader[2].ToString() + " " + reader[1].ToString() + " " + reader[3].ToString();
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
        }

        private void FinalExamForm_Load(object sender, EventArgs e)
        {
            metroButton1.Select();
            LoadTo.combobox(CourseComboBox, "SELECT * FROM course");
            updateExams();
        }

        private void updateExams()
        {
            user_exams.Clear();
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT id, course_id, exam_time FROM final_exams WHERE user_id = " + userid, fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            while (reader.Read())
                user_exams.Rows.Add(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString());
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            updateForm();
        }

        private void updateForm()
        {
            try
            {
                int CourseId = int.Parse(CourseComboBox.SelectedValue.ToString());

                examid = 0;
                string examtime = "";

                foreach (DataRow exam in user_exams.Rows)
                {
                    if (int.Parse(exam["course_id"].ToString()) == CourseId)
                    {
                        examid = int.Parse(exam["id"].ToString());
                        examtime = exam["exam_time"].ToString();
                        break;
                    }
                }

                ExamLabel.Visible = false;
                CreateExamButton.Visible = false;
                RefreshExamButton.Visible = false;
                ReportButton.Visible = false;
                GoToLearnButton.Visible = false;
                StartExamButton.Visible = false;
                StartExamButton.Enabled = true;
                ResultLabel.Visible = false;

                if (examid == 0)
                {
                    ExamLabel.Visible = true;
                    CreateExamButton.Visible = true;
                }
                else
                {
                    StartExamButton.Visible = true;
                    ResultLabel.Visible = true;
                    if (examtime.Length > 0)
                    {
                        StartExamButton.Enabled = false;
                        double examresult = calculate.Percent(examid);
                        if (examresult >= 75)
                        {
                            ReportButton.Visible = true;
                            ResultLabel.Text = "Результат: " + examresult + "% (экзамен сдан)";
                        }
                        else
                        {
                            RefreshExamButton.Visible = true;
                            GoToLearnButton.Visible = true;
                            ResultLabel.Text = "Результат: " + examresult + "% (экзамен не сдан)";
                        }
                    }
                    else
                        ResultLabel.Text = "Экзамен не завершён";
                }
            }
            catch { }
        }


        private string get_questions(int courseid)
        {
            string questions = "";
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT * FROM getquestions(" + courseid + ")", fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            reader.Read();
            questions = reader[0].ToString();
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            return questions;
        }


        private void CreateExamButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            if (CourseComboBox.Text.Length < 1)
            {
                MessageBox.Show("Выберите курс!");
                return;
            }

            string questions = get_questions(int.Parse(CourseComboBox.SelectedValue.ToString()));

            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand InsertSQL = new FbCommand("INSERT INTO final_exams VALUES (0, @USER_ID, @COURSE_ID, @QUESTIONS, @NOTHING, @NOTHING)", fb);
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
                InsertSQL.Dispose();
                fb.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
                
            updateExams();
        }

        private void StartExamButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите начать экзамен?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                FinalExamQuiz eq = new FinalExamQuiz(examid);
                eq.Closed += (s, args) => { this.Show(); this.updateExams(); };
                eq.Show();
            }
        }

        private void RefreshExamButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            delete.record("DELETE FROM final_exams WHERE id = " + examid);
            updateExams();
        }

        private void GoToLearnButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            this.Hide();
            LearnForm lf = new LearnForm();
            lf.Closed += (s, args) => this.Show();
            lf.Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            Word._Application application = new Word.Application();
            Word._Document document;
            Object filename = Path.Combine(Application.StartupPath, "final_report.dot");
            Object missing = Type.Missing;
            document = application.Documents.Add(ref filename);
            Word.Find find = application.Selection.Find;

            Dictionary<string, string> replacements = new Dictionary<string, string>(3);
            replacements.Add("<username>", UserNameLabel.Text);
            replacements.Add("<nowdate>", DateTime.Now.ToString("dd.MM.yyy"));
            replacements.Add("<spec>", CourseComboBox.Text );
            replacements.Add("<result>", ResultLabel.Text.Substring(11));


            foreach (KeyValuePair<string, string> keyValue in replacements)
            {
                find.Text = keyValue.Key;
                find.Replacement.Text = keyValue.Value;
                Object wrap = Word.WdFindWrap.wdFindContinue;
                Object replace = Word.WdReplace.wdReplaceAll;
                find.Execute(FindText: Type.Missing,
                    MatchCase: false,
                    MatchWholeWord: false,
                    MatchWildcards: false,
                    MatchSoundsLike: missing,
                    MatchAllWordForms: false,
                    Forward: true,
                    Wrap: wrap,
                    Format: false,
                    ReplaceWith: missing, Replace: replace);
            }
            application.Visible = true;
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CourseComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            updateForm();
        }


    }
}
