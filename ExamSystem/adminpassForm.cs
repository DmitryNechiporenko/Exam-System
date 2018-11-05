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
    public partial class adminpassForm : MetroFramework.Forms.MetroForm
    {
        public adminpassForm()
        {
            InitializeComponent();
        }

        private void contButton_Click(object sender, EventArgs e)
        {
            if (passTextBox.Text == "civssm")
                this.DialogResult = DialogResult.OK;
            else
            {
                passTextBox.Clear();
                MessageBox.Show("Пароль введен неверно!");
                passTextBox.Focus();
            }
        }
    }
}
