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
    public partial class LearnForm : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());


        public LearnForm()
        {
            InitializeComponent();
        }

        private void LearnForm_Load(object sender, EventArgs e)
        {
            LoadTo.combobox(CourseComboBox, "SELECT * FROM course");
        }

        private void CourseComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(CourseComboBox.SelectedValue.ToString());
                LoadTo.listbox(CourseBlocksListBox, "SELECT name FROM block WHERE course_id=" + i);
            }
            catch { }
        }

        private void AddBlockButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ChoosedBlocksListBox.Items.Contains(CourseBlocksListBox.SelectedItem.ToString()))
                {
                    ChoosedBlocksListBox.Items.Add(CourseBlocksListBox.SelectedItem.ToString());
                    ChoosedBlocksListBox.SelectedIndex = int.Parse(ChoosedBlocksListBox.Items.Count.ToString()) - 1;
                }
            }
            catch { }
        }

        private void DeleteBlockButton_Click(object sender, EventArgs e)
        {
            try
            {
                ChoosedBlocksListBox.Items.RemoveAt(ChoosedBlocksListBox.SelectedIndex);
                ChoosedBlocksListBox.SelectedIndex = int.Parse(ChoosedBlocksListBox.Items.Count.ToString()) - 1;
            }
            catch { }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (ChoosedBlocksListBox.Items.Count > 0)
            {
                string[] blocklist = new string[ChoosedBlocksListBox.Items.Count];
                for (int i = 0; i < ChoosedBlocksListBox.Items.Count; i++)
                {
                    blocklist[i] = ChoosedBlocksListBox.Items[i].ToString();
                }

                this.Hide();
                LearnQuiz lq = new LearnQuiz(blocklist);
                lq.Closed += (s, args) => this.Close();
                lq.Show();
            }
            else
            {
                MessageBox.Show("Выберите блок!");
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
