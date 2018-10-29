using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace ExamSystem
{
    public partial class DelBlock : Form
    {
        FbConnection fb = new FbConnection(connection.conString());

        public DelBlock()
        {
            InitializeComponent();
        }

        private void DelBlock_Load(object sender, EventArgs e)
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
            try
            {
                int i = int.Parse(BlockComboBox.SelectedValue.ToString());
                BlockTextBox.Text = BlockComboBox.GetItemText(BlockComboBox.SelectedItem);
            }
            catch { }
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            if (BlockTextBox.Text.Length < 1)
            {
                MessageBox.Show("Введите название блока!");
                return;
            }


            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();
            int bID = int.Parse(BlockComboBox.SelectedValue.ToString());

            FbCommand UpdateSQL = new FbCommand("UPDATE block SET name = @NAME WHERE id = " + bID, fb);
            UpdateSQL.Parameters.Add("NAME", FbDbType.Text).Value = BlockTextBox.Text.Trim();

            UpdateSQL.Transaction = fbt;



            try
            {
                UpdateSQL.ExecuteNonQuery();
                MessageBox.Show("Изменено!");
                fbt.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateSQL.Dispose();
            fb.Close();
            CourseComboBox_SelectedValueChanged(sender, e);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();
            int bID = int.Parse(BlockComboBox.SelectedValue.ToString());

            FbCommand DeleteSQL = new FbCommand("DELETE FROM block WHERE id = " + bID, fb);

            DeleteSQL.Transaction = fbt;

            try
            {
                DeleteSQL.ExecuteNonQuery();
                MessageBox.Show("Удалено!");
                fbt.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DeleteSQL.Dispose();
            fb.Close();
            CourseComboBox_SelectedValueChanged(sender, e);
        }
    }
}
