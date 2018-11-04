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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }


        private void StartForm_Load(object sender, EventArgs e)
        {
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestion f = new AddQuestion();
            f.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelQuestion f = new DelQuestion();
            f.ShowDialog();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCourse f = new AddCourse();
            f.ShowDialog();
        }

        private void удалитьИзменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelCourse f = new DelCourse();
            f.ShowDialog();
        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddBlock f = new AddBlock();
            f.ShowDialog();
        }

        private void удалитьИзменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DelBlock f = new DelBlock();
            f.ShowDialog();
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

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsers f = new ViewUsers();
            f.ShowDialog();
        }
    }
}
