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
    public partial class regForm : MetroFramework.Forms.MetroForm
    {
        public regForm()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if ((surnameTextBox.Text.Length < 2) || (nameTextBox.Text.Length < 2) || (orgTextBox.Text.Length < 1))
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            FbConnection fb = new FbConnection(connection.conString());
            if (fb.State == ConnectionState.Closed)
                fb.Open();
            FbTransaction fbt = fb.BeginTransaction();
            FbCommand InsertSQL = new FbCommand("INSERT INTO users VALUES (0, @NAME, @SURNAME, @PATR, @CITY, @ORG, @POSIT, @PASS)", fb);
            InsertSQL.Parameters.Add("NAME", FbDbType.Text).Value = nameTextBox.Text.Trim();
            InsertSQL.Parameters.Add("SURNAME", FbDbType.Text).Value = surnameTextBox.Text.Trim();
            InsertSQL.Parameters.Add("PATR", FbDbType.Text).Value = patrTextBox.Text.Trim();
            InsertSQL.Parameters.Add("CITY", FbDbType.Text).Value = cityTextBox.Text.Trim();
            InsertSQL.Parameters.Add("ORG", FbDbType.Text).Value = orgTextBox.Text.Trim();
            InsertSQL.Parameters.Add("POSIT", FbDbType.Text).Value = posTextBox.Text.Trim();
            InsertSQL.Parameters.Add("PASS", FbDbType.Text).Value = passTextBox.Text.Trim();
            InsertSQL.Transaction = fbt;

            try
            {
                int res = InsertSQL.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                fbt.Commit();
                InsertSQL.Dispose();
                fb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
