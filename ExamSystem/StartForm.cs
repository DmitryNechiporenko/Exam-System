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
    public partial class StartForm : MetroFramework.Forms.MetroForm
    {
        public StartForm()
        {
            InitializeComponent();
        }


        private void StartForm_Load(object sender, EventArgs e)
        {
            adminButton.Select();
        }

        private void LearnButton_Click(object sender, EventArgs e)
        {
            this.Hide();       
            LearnForm lf = new LearnForm();
            lf.Closed += (s, args) => this.Show();
            lf.Show();
        }

        private void examButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm ef = new loginForm();
            ef.Closed += (s, args) => this.Show();
            ef.Show();
        }


        private void adminButton_Click(object sender, EventArgs e)
        {
            adminpassForm frm = new adminpassForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                adminform f = new adminform();
                f.ShowDialog();
            }
        }
    }
}
