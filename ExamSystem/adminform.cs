using ExamSystem.Properties;
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

namespace ExamSystem
{
    public partial class adminform : MetroFramework.Forms.MetroForm
    {
        public adminform()
        {
            InitializeComponent();
            metroButton1.Select();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            AddCourse f = new AddCourse();
            f.ShowDialog();
        }

        private void DelCourseButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            DelCourse f = new DelCourse();
            f.ShowDialog();
        }

        private void AddBlockButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            AddBlock f = new AddBlock();
            f.ShowDialog();
        }

        private void DelBlockButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            DelBlock f = new DelBlock();
            f.ShowDialog();
        }

        private void AddQuesButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            AddQuestion f = new AddQuestion();
            f.ShowDialog();
        }

        private void DelQuesButton_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
            DelQuestion f = new DelQuestion();
            f.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroButton1.Select();
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
            metroButton1.Select();
            this.Close();
        }

        private void SaveDBButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = Path.Combine(Application.StartupPath, Settings.Default.DBNAME);
                    string destFile = Path.Combine(folderBrowserDialog1.SelectedPath, Settings.Default.DBNAME);

                    if (!Directory.Exists(folderBrowserDialog1.SelectedPath))
                        Directory.CreateDirectory(folderBrowserDialog1.SelectedPath);

                    File.Copy(sourceFile, destFile, true);
                    MessageBox.Show("Файл с базой успешно сохранен!");
                }
            }
            catch { MessageBox.Show("Ошибка"); }

            metroButton1.Select();
        }

        private void LoadDBButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string destFile = Path.Combine(Application.StartupPath, Settings.Default.DBNAME);
                string sourceFile = openFileDialog1.FileName;

                File.Copy(sourceFile, destFile, true);
                MessageBox.Show("Файл с базой успешно сохранен!");
            }

            metroButton1.Select();
        }
    }
}
