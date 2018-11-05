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
    public partial class loginForm : MetroFramework.Forms.MetroForm
    {
        FbConnection fb = new FbConnection(connection.conString());

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (fb.State == ConnectionState.Closed)
            {
                fb.Open();
            }
            FbTransaction fbt = fb.BeginTransaction();

            FbCommand SelectSQL = new FbCommand("SELECT id FROM users WHERE surname = @surname AND name = @name AND patronymic = @patr AND pass = @pass", fb);
            SelectSQL.Parameters.Add("surname", FbDbType.Text).Value = surnameTextBox.Text.Trim();
            SelectSQL.Parameters.Add("name", FbDbType.Text).Value = nameTextBox.Text.Trim();
            SelectSQL.Parameters.Add("patr", FbDbType.Text).Value = patrTextBox.Text.Trim();
            SelectSQL.Parameters.Add("pass", FbDbType.Text).Value = passwordTextBox.Text.Trim();
            SelectSQL.Transaction = fbt;

            FbDataReader reader = SelectSQL.ExecuteReader();

            int userid = -1;

            while (reader.Read())
            {
                userid = int.Parse(reader[0].ToString());
            }
            reader.Close();
            SelectSQL.Dispose();
            fbt.Commit();
            fb.Close();
            if (userid >= 0)
            {
                this.Hide();
                ExamsForm ef = new ExamsForm(userid);
                ef.Closed += (s, args) => this.Close();
                ef.Show();
            }
            else
            {
                MessageBox.Show("Пользователь с такими данными не найден");
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            regForm f = new regForm();
            f.ShowDialog();
        }
    }
}
