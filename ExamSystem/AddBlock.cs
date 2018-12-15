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
    public partial class AddBlock : MetroFramework.Forms.MetroForm
    {

        FbConnection fb = new FbConnection(connection.conString());

        public AddBlock()
        {
            InitializeComponent();
        }

        private void AddBlock_Load(object sender, EventArgs e)
        {
            LoadTo.combobox(CourseComboBox, "SELECT * FROM course");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (BlockTextBox.Text.Length < 1)
            {
                MessageBox.Show("Введите название блока!");
                return;
            }

            if (fb.State == ConnectionState.Closed)
                fb.Open();

            FbTransaction fbt = fb.BeginTransaction();
            FbCommand newID = new FbCommand("SELECT MAX(ID) FROM block", fb);
            newID.Transaction = fbt;
            FbDataReader reader1 = newID.ExecuteReader();
            reader1.Read();
            string newid = reader1[0].ToString();
            newID.Dispose();

            reader1.Close();

            try
            {
                int chislo = int.Parse(newid);
            }
            catch
            {
                newid = "1";
            }



            FbCommand InsertSQL = new FbCommand("INSERT INTO block VALUES (@ID, @COURSE_ID, @NAME)", fb);

            InsertSQL.Parameters.Add("ID", FbDbType.Integer).Value = (int.Parse(newid) + 1);
            InsertSQL.Parameters.Add("COURSE_ID", FbDbType.Integer).Value = int.Parse(CourseComboBox.SelectedValue.ToString());
            InsertSQL.Parameters.Add("NAME", FbDbType.Text).Value = BlockTextBox.Text.Replace("\n"," ").Replace("\r","").Trim();

            InsertSQL.Transaction = fbt;



            try
            {
                int res = InsertSQL.ExecuteNonQuery();
                MessageBox.Show("Добавлено!");
                fbt.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            InsertSQL.Dispose();
            fb.Close();
        }
    }
}
