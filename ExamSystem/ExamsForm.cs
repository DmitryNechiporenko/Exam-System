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
    public partial class ExamsForm : Form
    {
        FbConnection fb = new FbConnection(connection.conString());

        int userid, examid;
        double examresult = 0;
        public ExamsForm(int userid)
        {
            InitializeComponent();
            this.userid = userid;

            fb.Open();
            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand("SELECT * FROM users WHERE id = " + this.userid, fb);
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();
            if (reader.Read())
            {
                UserNameLabel.Text = reader[2].ToString() + " " + reader[1].ToString() + " " + reader[3].ToString();
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
        }


        private void ExamsFormcs_Load(object sender, EventArgs e)
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
            updateParts();
        }

        private void updateParts()
        {
            try
            {
                int partsCount = 0;
                int BlockID = int.Parse(BlockComboBox.SelectedValue.ToString());
                if (fb.State == ConnectionState.Closed)
                {
                    fb.Open();
                }

                FbTransaction fbt = fb.BeginTransaction();

                FbCommand SelectSQL = new FbCommand("SELECT * FROM exams WHERE block_id=" + BlockID + " AND user_id = " + userid, fb);
                SelectSQL.Transaction = fbt;

                FbDataReader reader = SelectSQL.ExecuteReader();

                if (reader.Read())
                {
                    ExamLabel.Visible = false;
                    CreateExamButton.Visible = false;
                    part1Button.Visible = true;
                    part2Button.Visible = true;
                    part3Button.Visible = true;
                    part4Button.Visible = true;
                    part5Button.Visible = true;
                    examid = int.Parse(reader[0].ToString());

                    if (reader[13].ToString().Length > 0)
                    {
                        part1Button.BackColor = Color.LightGreen;
                        part1Button.Enabled = false;
                    }
                    else
                    {
                        part1Button.BackColor = Color.LightGray;
                        part1Button.Enabled = true;
                        partsCount++;
                    }
                    if (reader[14].ToString().Length > 0)
                    {
                        part2Button.BackColor = Color.LightGreen;
                        part2Button.Enabled = false;
                    }
                    else
                    {
                        part2Button.BackColor = Color.LightGray;
                        part2Button.Enabled = true;
                        partsCount++;
                    }
                    if (reader[15].ToString().Length > 0)
                    {
                        part3Button.BackColor = Color.LightGreen;
                        part3Button.Enabled = false;
                    }
                    else
                    {
                        part3Button.BackColor = Color.LightGray;
                        part3Button.Enabled = true;
                        partsCount++;
                    }
                    if (reader[16].ToString().Length > 0)
                    {
                        part4Button.BackColor = Color.LightGreen;
                        part4Button.Enabled = false;
                    }
                    else
                    {
                        part4Button.BackColor = Color.LightGray;
                        part4Button.Enabled = true;
                        partsCount++;
                    }
                    if (reader[17].ToString().Length > 0)
                    {
                        part5Button.BackColor = Color.LightGreen;
                        part5Button.Enabled = false;
                    }
                    else
                    {
                        part5Button.BackColor = Color.LightGray;
                        part5Button.Enabled = true;
                        partsCount++;
                    }
                }
                else
                {
                    ExamLabel.Visible = true;
                    CreateExamButton.Visible = true;
                    part1Button.Visible = false;
                    part2Button.Visible = false;
                    part3Button.Visible = false;
                    part4Button.Visible = false;
                    part5Button.Visible = false;
                }
                reader.Close();
                SelectSQL.Dispose();
                fbt.Commit();
                fb.Close();


                ResultLabel.Visible = !CreateExamButton.Visible;
                RefreshExamButton.Visible = false;
                ReportButton.Visible = false;

                if (partsCount == 0)
                {
                    examresult = calculate.percentage(this.examid);
                    ResultLabel.Text = "Результат: " + examresult + "%";

                    if(examresult >= 75)
                    {
                        ReportButton.Visible = true;
                        RefreshExamButton.Visible = false;
                        ResultLabel.Text = ResultLabel.Text + " (экзамен сдан)";
                    }
                    else
                    {
                        RefreshExamButton.Visible = true;
                        ReportButton.Visible = false;
                        ResultLabel.Text = ResultLabel.Text + " (экзамен не сдан)";
                    }
                }
                else
                {
                    examresult = 0;
                    ResultLabel.Text = "Экзамен не завершён";
                }
            }
            catch
            {

            }
        }

        private string[] all_parts(int blockid)
        {
            string questions = "";
            if (fb.State == ConnectionState.Closed)
            {
                fb.Open();
            }
            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand("SELECT FIRST 100 id FROM question WHERE block_id = " + blockid + "ORDER BY rand()", fb);
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();

            while (reader.Read())
            {
                questions = questions + reader[0].ToString() + ",";
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            if (questions.Length > 0)
            {
                questions = questions.Substring(0, questions.Length - 1);
            }

            string[] parts = new string[5];
            parts[0] = parts[1] = parts[2] = parts[3] = parts[4] = "";

            int count = 0;
            foreach (string q in questions.Split(','))
            {
                parts[count] = parts[count] + q + ",";
                count++;
                if (count == 5)
                {
                    count = 0;
                }
            }

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length > 0)
                {
                    parts[i] = parts[i].Substring(0, parts[i].Length - 1);
                }
            }

            return parts;
        }

        private void CreateExamButton_Click(object sender, EventArgs e)
        {

            if (BlockComboBox.Text.Length < 1)
            {
                MessageBox.Show("Выберите блок!");
                return;
            }

            string[] parts = all_parts(int.Parse(BlockComboBox.SelectedValue.ToString()));

            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();
            FbCommand newID = new FbCommand("SELECT MAX(ID) FROM exams", fb);
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

            FbCommand InsertSQL = new FbCommand("INSERT INTO exams VALUES (@ID, @USER_ID, @BLOCK_ID, @PART1, @NOTHING, @PART2, @NOTHING, @PART3, @NOTHING, @PART4, @NOTHING, @PART5, @NOTHING, @NOTHING, @NOTHING, @NOTHING, @NOTHING, @NOTHING)", fb);

            InsertSQL.Parameters.Add("ID", FbDbType.Integer).Value = int.Parse(newid) + 1;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            examid = int.Parse(newid) + 1;

            InsertSQL.Dispose();
            fb.Close();
            CreateExamButton.Visible = false;

            ExamsFormcs_Load(sender, e);
        }

        private void goToExam(int part)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите начать экзамен?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                ExamQuiz eq = new ExamQuiz(examid, part);
                eq.Closed += (s, args) => { this.Show(); this.updateParts(); };
                eq.Show();
            }
        }

        private void part1Button_Click(object sender, EventArgs e)
        {
            goToExam(1);
        }

        private void part2Button_Click(object sender, EventArgs e)
        {
            goToExam(2);
        }

        private void part3Button_Click(object sender, EventArgs e)
        {
            goToExam(3);
        }

        private void part4Button_Click(object sender, EventArgs e)
        {
            goToExam(4);
        }

        private void part5Button_Click(object sender, EventArgs e)
        {
            goToExam(5);
        }

        private void RefreshExamButton_Click(object sender, EventArgs e)
        {
            delete.record("DELETE FROM exams WHERE id = " + examid);
            ExamsFormcs_Load(sender, e);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Word.Application application = new Word.Application();
            Object filename = Path.Combine(Application.StartupPath, "report.dot");
            Object missing = Type.Missing;
            application.Documents.Open(ref filename);
            Word.Find find = application.Selection.Find;

            Dictionary<string, string> replacements = new Dictionary<string, string>(3);
            replacements.Add("<username>", UserNameLabel.Text);
            replacements.Add("<nowdate>", DateTime.Now.ToString("dd.MM.yyy"));
            replacements.Add("<spec>", CourseComboBox.Text + "/" + BlockComboBox.Text);
            replacements.Add("<result>", examresult.ToString() + "%");


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
    }
}
