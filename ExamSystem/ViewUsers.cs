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
    public partial class ViewUsers : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());
        int FinalExamId = 0;

        public ViewUsers()
        {
            InitializeComponent();
        }

        private void view_users_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            Table.Columns.Add("ID");
            Table.Columns.Add("Фамилия");
            Table.Columns.Add("Имя");
            Table.Columns.Add("Отчество");
            Table.Columns.Add("Город");
            Table.Columns.Add("Организация");
            Table.Columns.Add("Должность");
            Table.Columns.Add("Пароль");

            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT id, surname, name, patronymic, city, org, posit, pass FROM users", fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();
            try
            {
                while (reader.Read())
                    Table.Rows.Add(new object[] { reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7) });
                reader.Close();
                usersGridView.DataSource = Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();

            foreach (DataGridViewColumn col in usersGridView.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            usersGridView_SelectionChanged(sender, e);
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить запись?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (fb.State == ConnectionState.Closed)
                    fb.Open();

                FbTransaction fbt = fb.BeginTransaction();
                FbCommand InsertSQL = new FbCommand("DELETE FROM users WHERE id=@id", fb);
                InsertSQL.Parameters.Add("id", FbDbType.Integer).Value = usersGridView.CurrentRow.Cells[0].Value;
                InsertSQL.Transaction = fbt;
                try
                {
                    int res = InsertSQL.ExecuteNonQuery();
                    MessageBox.Show("Запись удалена!");
                    fbt.Commit();
                    InsertSQL.Dispose();
                    fb.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                view_users_Load(sender, e);
            }

        }

        private void usersGridView_SelectionChanged(object sender, EventArgs e)
        {
            ExamsComboBox.Visible = false;
            ViewExamButton.Visible = false;
            ViewFinalExamButton.Visible = false;
            ExamsComboBox.DataSource = null;
            try
            {
                string uid = usersGridView.CurrentRow.Cells[0].Value.ToString();
                if (fb.State == ConnectionState.Closed)
                    fb.Open();
                FbTransaction fbt = fb.BeginTransaction();
                FbCommand SelectSQL = new FbCommand("SELECT exams.id, block.name FROM exams, block WHERE exams.block_id = block.id AND exams.user_id = " + uid, fb);
                SelectSQL.Transaction = fbt;
                FbDataReader reader = SelectSQL.ExecuteReader();
                var data = new List<P1>();
                while (reader.Read())
                {
                    ExamsComboBox.Visible = true;
                    ViewExamButton.Visible = true;
                    var mc = new P1
                    {
                        Id = reader[0].ToString().Trim(),
                        Name = reader[1].ToString().Trim()
                    };
                    data.Add(mc);
                }
                reader.Close();
                SelectSQL.Dispose();
                fbt.Commit();
                ExamsComboBox.DataSource = data;
                ExamsComboBox.DisplayMember = "Name";
                ExamsComboBox.ValueMember = "Id";

                FbCommand SelectSQL1 = new FbCommand("SELECT id FROM final_exams WHERE user_id = " + uid, fb);
                SelectSQL1.Transaction = fbt;
                FbDataReader reader1 = SelectSQL1.ExecuteReader();
                if (reader1.Read())
                {
                    FinalExamId = int.Parse(reader1[0].ToString());
                    ViewFinalExamButton.Visible = true;
                }
                reader1.Close();
                SelectSQL1.Dispose();
                fbt.Commit();
                fb.Close();

            }
            catch { }
        }

        private void ViewExamButton_Click(object sender, EventArgs e)
        {
            ViewExam f = new ViewExam(int.Parse(ExamsComboBox.SelectedValue.ToString()));
            f.Show();
        }

        private void ViewFinalExamButton_Click(object sender, EventArgs e)
        {
            ViewFinalExam f = new ViewFinalExam(FinalExamId);
            f.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
