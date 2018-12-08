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
    public partial class adminform : MetroFramework.Forms.MetroForm
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            AddCourse f = new AddCourse();
            f.ShowDialog();
        }

        private void DelCourseButton_Click(object sender, EventArgs e)
        {
            DelCourse f = new DelCourse();
            f.ShowDialog();
        }

        private void AddBlockButton_Click(object sender, EventArgs e)
        {
            AddBlock f = new AddBlock();
            f.ShowDialog();
        }

        private void DelBlockButton_Click(object sender, EventArgs e)
        {
            DelBlock f = new DelBlock();
            f.ShowDialog();
        }

        private void AddQuesButton_Click(object sender, EventArgs e)
        {
            AddQuestion f = new AddQuestion();
            f.ShowDialog();
        }

        private void DelQuesButton_Click(object sender, EventArgs e)
        {
            DelQuestion f = new DelQuestion();
            f.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ViewUsers f = new ViewUsers();
            f.ShowDialog();
        }

        private void metroTabControl1_MouseEnter(object sender, EventArgs e)
        {
            metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            metroTabControl1.Refresh();
        }

        private void metroTabControl1_MouseLeave(object sender, EventArgs e)
        {
            metroTabControl1.Style = MetroFramework.MetroColorStyle.Default;
            metroTabControl1.Refresh();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
