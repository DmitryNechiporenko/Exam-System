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
    public partial class DelCourse : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());

        public DelCourse()
        {
            InitializeComponent();
        }

        private void DelCourse_Load(object sender, EventArgs e)
        {
            LoadTo.combobox(CourseComboBox, "SELECT * FROM course");
        }

        private void CourseComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(CourseComboBox.SelectedValue.ToString());
                CourseTextBox.Text = CourseComboBox.GetItemText(CourseComboBox.SelectedItem);
            }
            catch { }
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            if (CourseTextBox.Text.Length < 1)
            {
                MessageBox.Show("Введите название курса!");
                return;
            }


            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();
            int cID = int.Parse(CourseComboBox.SelectedValue.ToString());

            FbCommand UpdateSQL = new FbCommand("UPDATE course SET name = @NAME WHERE id = " + cID, fb);
            UpdateSQL.Parameters.Add("NAME", FbDbType.Text).Value = CourseTextBox.Text.Replace("\n", " ").Replace("\r", "").Trim();

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
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();
            int cID = int.Parse(CourseComboBox.SelectedValue.ToString());

            FbCommand DeleteSQL = new FbCommand("DELETE FROM course WHERE id = " + cID, fb);

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
            DelCourse_Load(sender, e);
        }
    }
}
