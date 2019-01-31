using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Collections.Generic;
using System.IO;

namespace ExamSystem
{
    public partial class ExamsForm : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());
        int userid, examid;
        DataTable user_exams = new DataTable();

        public ExamsForm(int userid)
        {
            InitializeComponent();

            user_exams.Columns.Add("id", typeof(int));
            user_exams.Columns.Add("block_id", typeof(int));
            user_exams.Columns.Add("part1_time", typeof(string));
            user_exams.Columns.Add("part2_time", typeof(string));
            user_exams.Columns.Add("part3_time", typeof(string));
            user_exams.Columns.Add("part4_time", typeof(string));
            user_exams.Columns.Add("part5_time", typeof(string));

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


        private void ExamsFormcs_Load(object sender, EventArgs e)
        {
            LoadTo.combobox(CourseComboBox, "SELECT * FROM course");
            updateExams();
        }

        private void updateExams()
        {
            user_exams.Clear();
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT id, block_id, p1_time, p2_time, p3_time, p4_time, p5_time FROM exams WHERE user_id = " + userid, fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            while (reader.Read())
                user_exams.Rows.Add(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
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
                int BlockId = int.Parse(BlockComboBox.SelectedValue.ToString());

                examid = 0;
                int finished_parts = 0;

                Button[] partButtons = { part1Button, part2Button, part3Button, part4Button, part5Button };
                foreach (var btn in partButtons)
                {
                    btn.Enabled = false;
                    btn.Visible = false;
                }
                   
                foreach (DataRow exam in user_exams.Rows)
                {
                    if (int.Parse(exam["block_id"].ToString()) == BlockId)
                    {
                        examid = int.Parse(exam["id"].ToString());
                        if (exam["part1_time"].ToString().Length == 0)
                            part1Button.Enabled = true;
                        if (exam["part2_time"].ToString().Length == 0)
                            part2Button.Enabled = true;
                        if (exam["part3_time"].ToString().Length == 0)
                            part3Button.Enabled = true;
                        if (exam["part4_time"].ToString().Length == 0)
                            part4Button.Enabled = true;
                        if (exam["part5_time"].ToString().Length == 0)
                            part5Button.Enabled = true;
                        break;
                    }
                }

                ResultLabel.Visible = false;
                ExamLabel.Visible = false;
                CreateExamButton.Visible = false;
                RefreshExamButton.Visible = false;
                ReportButton.Visible = false;
                GoToLearnButton.Visible = false;

                if (examid == 0)
                {
                    ExamLabel.Visible = true;
                    CreateExamButton.Visible = true;
                }
                else
                {
                    foreach (var btn in partButtons)
                    {
                        btn.Visible = true;
                        if (!btn.Enabled)
                            finished_parts++;
                    }
                    ResultLabel.Visible = true;
                    if (finished_parts == 5)
                    {
                        double examresult = calculate.Percent(examid, false);
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


        private string[] get_questions(int blockid)
        {
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT FIRST 100 CAST(LIST(id,',') as VARCHAR(250)) FROM question WHERE block_id = " + blockid + "ORDER BY rand()", fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            reader.Read();
            string questions = reader[0].ToString();
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            string[] parts = new string[5];
            parts[0] = parts[1] = parts[2] = parts[3] = parts[4] = "";

            int count = 0;
            foreach (string q in questions.Split(','))
            {
                parts[count] = parts[count] + "," + q;
                count++;
                if (count == 5)
                    count = 0;
            }

            for (int i = 0; i < parts.Length; i++)
                parts[i] = parts[i].Substring(1);

            return parts;
        }

        private void CreateExamButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            if (BlockComboBox.Text.Length < 1)
            {
                MessageBox.Show("Выберите блок!");
                return;
            }

            string[] parts = get_questions(int.Parse(BlockComboBox.SelectedValue.ToString()));

            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand InsertSQL = new FbCommand("INSERT INTO exams VALUES (0, @USER_ID, @BLOCK_ID, @PART1, @NOTHING, @PART2, @NOTHING, @PART3, @NOTHING, @PART4, @NOTHING, @PART5, @NOTHING, @NOTHING, @NOTHING, @NOTHING, @NOTHING, @NOTHING)", fb);
            InsertSQL.Parameters.Add("USER_ID", FbDbType.Integer).Value = userid;
            InsertSQL.Parameters.Add("BLOCK_ID", FbDbType.Integer).Value = int.Parse(BlockComboBox.SelectedValue.ToString());
            InsertSQL.Parameters.Add("NOTHING", FbDbType.Text).Value = "";
            InsertSQL.Parameters.Add("PART1", FbDbType.Text).Value = parts[0];
            InsertSQL.Parameters.Add("PART2", FbDbType.Text).Value = parts[1];
            InsertSQL.Parameters.Add("PART3", FbDbType.Text).Value = parts[2];
            InsertSQL.Parameters.Add("PART4", FbDbType.Text).Value = parts[3];
            InsertSQL.Parameters.Add("PART5", FbDbType.Text).Value = parts[4];
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

        private void goToExam(int part)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите начать экзамен?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                ExamQuiz eq = new ExamQuiz(examid, part);
                eq.Closed += (s, args) => { this.Show(); this.updateExams(); };
                eq.Show();
            }
        }

        private void partButton_Click(object sender, EventArgs e)
        {
            if ((Button)sender == part1Button)
                goToExam(1);
            else if ((Button)sender == part2Button)
                goToExam(2);
            else if ((Button)sender == part3Button)
                goToExam(3);
            else if ((Button)sender == part4Button)
                goToExam(4);
            else if ((Button)sender == part5Button)
                goToExam(5);
        }

        private void RefreshExamButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            delete.record("DELETE FROM exams WHERE id = " + examid);
            updateExams();
        }

        private void GoToLearnButton_Click(object sender, EventArgs e)
        {
            string[] blocklist = { BlockComboBox.Text };
            this.Hide();
            LearnQuiz lq = new LearnQuiz(blocklist);
            lq.Closed += (s, args) => this.Show();
            lq.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            Word._Application application = new Word.Application();
            Word._Document document;
            Object filename = Path.Combine(Application.StartupPath, "report.dot");
            Object missing = Type.Missing;
            document = application.Documents.Add(ref filename);
            Word.Find find = application.Selection.Find;

            Dictionary<string, string> replacements = new Dictionary<string, string>(3);
            replacements.Add("<username>", UserNameLabel.Text);
            replacements.Add("<nowdate>", DateTime.Now.ToString("dd.MM.yyy"));
            replacements.Add("<spec>", CourseComboBox.Text + "/" + BlockComboBox.Text);
            replacements.Add("<part1>", calculate.PartPercent(examid, "part1") + "%");
            replacements.Add("<part2>", calculate.PartPercent(examid, "part2") + "%");
            replacements.Add("<part3>", calculate.PartPercent(examid, "part3") + "%");
            replacements.Add("<part4>", calculate.PartPercent(examid, "part4") + "%");
            replacements.Add("<part5>", calculate.PartPercent(examid, "part5") + "%");
            replacements.Add("<result>", ResultLabel.Text.Substring(11));


            foreach(KeyValuePair<string, string> keyValue in replacements)
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
            updateForm();
        }
    }
}
