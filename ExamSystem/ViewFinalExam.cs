using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ExamSystem
{
    public partial class ViewFinalExam : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());

        string[] examinfo = new string[10];
        string[][] questionlist;
        int examid;
        DataTable questions = new DataTable();

        public ViewFinalExam(int examid)
        {
            InitializeComponent();

            this.examid = examid;
            string[] foo;
            string bar = "";

            if (fb.State == ConnectionState.Closed) //SELECT CURRENT EXAM
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT final_exams.*, users.name, users.surname, users.patronymic, course.name FROM final_exams, users, course WHERE final_exams.id = " + examid + " AND users.id = final_exams.user_id AND course.id = final_exams.course_id", fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            reader.Read();
            for (int i = 0; i < 10; i++)
                examinfo[i] = reader[i].ToString();
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();

            string questionlist = examinfo[3];
            FbTransaction fbt1 = fb.BeginTransaction(); //SELECT CURRENT QUESTIONS
            FbCommand SelectSQL1 = new FbCommand("SELECT * FROM question WHERE id IN (" + questionlist + ")", fb);
            SelectSQL1.Transaction = fbt1;
            FbDataReader reader1 = SelectSQL1.ExecuteReader();
            while (reader1.Read())
                bar = bar + reader1[0].ToString() + "|" + reader1[1].ToString() + "|" + reader1[2].ToString() + "|" + reader1[3].ToString() + "|" + reader1[4].ToString() + "|" + reader1[5].ToString() + "|" + reader1[6].ToString() + "|" + reader1[7].ToString() + "|" + reader1[8].ToString() + "\n";
            reader1.Close();
            SelectSQL1.Dispose();
            fbt1.Commit();
            fb.Close();

            bar = bar.Substring(0, bar.Length - 1);
            foo = bar.Split('\n');
            string[][] qList = new string[foo.Length][];
            for (int i = 0; i < foo.Length; i++)
                qList[i] = foo[i].Split('|');

            this.questionlist = qList;

            int min = 0;
            int sec = 0;

            string[] time = examinfo[5].Split(':');
            if (time.Count() > 1)
            {
                min = int.Parse(time[0]);
                sec = int.Parse(time[1]);
            }

            ExamTimeLabel.Text = ExamTimeLabel.Text + min.ToString() + ":" + sec.ToString();
            ResultLabel.Text = ResultLabel.Text + " " + calculate.Percent(examid) + "%";
            UserNameLabel.Text = examinfo[6] + " " + examinfo[7] + " " + examinfo[8];
        }

        private void ViewFinalExam_Load(object sender, EventArgs e)
        {
            try
            {
                QuestionsListBox.Items.Clear();

                string[] qIds = examinfo[3].Split(',');

                foreach (string qId in qIds)
                {
                    string temp = "";
                    foreach (string[] question in questionlist)
                    {
                        if (question[0] == qId)
                        {
                            temp = question[2];
                            break;
                        }
                    }
                    QuestionsListBox.Items.Add(temp);
                }

                if (QuestionsListBox.Items.Count > 0)
                {
                    QuestionsListBox.SelectedIndex = 0;
                    QuestionsListBox_SelectedValueChanged(sender, e);
                }
            }
            catch { }
        }

        private void QuestionsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                string[] question = new string[9];

                foreach (string[] q in questionlist)
                {
                    if (q[2] == QuestionsListBox.SelectedItem.ToString())
                    {
                        question = q;
                        break;
                    }
                }
                QuestionTextBox.Text = question[2];
                CurrentAnswerTextBox.Text = question[int.Parse(question[7]) + 2];

                int answerid;
                string foo = examinfo[4].Split(',')[QuestionsListBox.SelectedIndex];
                if (foo.Length > 0)
                    answerid = int.Parse(foo);
                else
                    answerid = -1;

                if (answerid != -1)
                    UserAnswerTextBox.Text = question[answerid + 2].ToString();
                else
                    UserAnswerTextBox.Text = "Нет ответа";
            }
            catch { }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Word._Application application = new Word.Application();
            Word._Document document;
            Object filename = Path.Combine(Application.StartupPath, "final_report.dot");
            Object missing = Type.Missing;
            document = application.Documents.Add(ref filename);
            Word.Find find = application.Selection.Find;
            Dictionary<string, string> replacements = new Dictionary<string, string>(3);
            replacements.Add("<username>", UserNameLabel.Text);
            replacements.Add("<nowdate>", DateTime.Now.ToString("dd.MM.yyy"));
            replacements.Add("<spec>", examinfo[9]);
            replacements.Add("<result>", ResultLabel.Text);


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
    }
}
