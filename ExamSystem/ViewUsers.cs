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
    public partial class ViewUsers : Form
    {
        FbConnection fb = new FbConnection(connection.conString());

        public ViewUsers()
        {
            InitializeComponent();
        }

        private void view_users_Load(object sender, EventArgs e)
        {
            if (fb.State == ConnectionState.Closed)
                fb.Open();


            FbTransaction fbt = fb.BeginTransaction();
            FbCommand SelectSQL = new FbCommand("SELECT id, surname, name, patronymic, city, org, posit, pass FROM users", fb);
            SelectSQL.Transaction = fbt;
            FbDataReader reader = SelectSQL.ExecuteReader();


            DataTable Table = new DataTable();
            Table.Columns.Add("ID");
            Table.Columns.Add("Фамилия");
            Table.Columns.Add("Имя");
            Table.Columns.Add("Отчество");
            Table.Columns.Add("Город");
            Table.Columns.Add("Организация");
            Table.Columns.Add("Должность");
            Table.Columns.Add("Пароль");

            try
            {
                while (reader.Read())
                {
                    Table.Rows.Add(new object[] { reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7) });
                }
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
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                InsertSQL.Dispose();
                fb.Close();
                view_users_Load(sender, e);
            }

        }

        private void usersGridView_SelectionChanged(object sender, EventArgs e)
        {
            ExamsComboBox.DataSource = null;
            try
            {
                int cnt = 0;
                if (fb.State == ConnectionState.Closed)
                {
                    fb.Open();
                }
                FbTransaction fbt = fb.BeginTransaction();

                FbCommand SelectSQL = new FbCommand("SELECT COUNT(*) FROM exams WHERE user_id = " + usersGridView.CurrentRow.Cells[0].Value.ToString(), fb);
                SelectSQL.Transaction = fbt;

                FbDataReader reader = SelectSQL.ExecuteReader();
                reader.Read();
                cnt = int.Parse(reader[0].ToString());
                reader.Close();
                SelectSQL.Dispose();
                fbt.Commit();
                fb.Close();

                if (cnt > 0)
                {
                    ExamsComboBox.Visible = true;
                    ViewExamButton.Visible = true;
                }
                else
                {
                    ExamsComboBox.Visible = false;
                    ViewExamButton.Visible = false;
                }

                
                if (fb.State == ConnectionState.Closed)
                {
                    fb.Open();
                }
                FbTransaction fbt1 = fb.BeginTransaction();

                FbCommand SelectSQL1 = new FbCommand("SELECT exams.id, block.name FROM exams, block WHERE exams.block_id = block.id AND exams.user_id = " + usersGridView.CurrentRow.Cells[0].Value.ToString(), fb);
                SelectSQL1.Transaction = fbt1;

                FbDataReader reader1 = SelectSQL1.ExecuteReader();
                var data1 = new List<P1>();

                while (reader1.Read())
                {
                    var mc = new P1
                    {
                        Id = reader1[0].ToString().Trim(),
                        Name = reader1[1].ToString().Trim()
                    };
                    data1.Add(mc);
                }
                reader1.Close();
                SelectSQL1.Dispose();
                fbt1.Commit();
                fb.Close();

                ExamsComboBox.DataSource = data1;
                ExamsComboBox.DisplayMember = "Name";
                ExamsComboBox.ValueMember = "Id";
            }
            catch
            {

            }
        }

        private void ViewExamButton_Click(object sender, EventArgs e)
        {
            ViewExam f = new ViewExam(int.Parse(ExamsComboBox.SelectedValue.ToString()));
            f.Show();
        }
    }
}
