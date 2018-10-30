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
    public partial class LearnChooseBlocksForm : Form
    {
        FbConnection fb = new FbConnection(connection.conString());


        public LearnChooseBlocksForm()
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
            string[] foo = new string[ChoosedBlocksListBox.Items.Count];
            for(int i = 0; i < ChoosedBlocksListBox.Items.Count; i++)
            {
                foo[i] = ChoosedBlocksListBox.Items[i].ToString();
            }
            LearnForm f = new LearnForm(foo);
            f.ShowDialog();
        }
    }
}
