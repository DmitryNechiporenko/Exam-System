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
    public partial class ExamSelectForm : MetroFramework.Forms.MetroForm
    {
        int userid;
        public ExamSelectForm(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            metroButton1.Select();
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamsForm ef = new ExamsForm(userid);
            ef.Closed += (s, args) => this.Close();
            ef.Show();
        }

        private void FinalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinalExamForm ef = new FinalExamForm(userid);
            ef.Closed += (s, args) => this.Close();
            ef.Show();
        }
    }
}
