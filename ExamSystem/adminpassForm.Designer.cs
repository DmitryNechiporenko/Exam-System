namespace ExamSystem
{
    partial class adminpassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passTextBox = new MetroFramework.Controls.MetroTextBox();
            this.contButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // passTextBox
            // 
            // 
            // 
            // 
            this.passTextBox.CustomButton.Image = null;
            this.passTextBox.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.passTextBox.CustomButton.Name = "";
            this.passTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passTextBox.CustomButton.TabIndex = 1;
            this.passTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passTextBox.CustomButton.UseSelectable = true;
            this.passTextBox.CustomButton.Visible = false;
            this.passTextBox.Lines = new string[0];
            this.passTextBox.Location = new System.Drawing.Point(61, 63);
            this.passTextBox.MaxLength = 32767;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '●';
            this.passTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passTextBox.SelectedText = "";
            this.passTextBox.SelectionLength = 0;
            this.passTextBox.SelectionStart = 0;
            this.passTextBox.ShortcutsEnabled = true;
            this.passTextBox.Size = new System.Drawing.Size(161, 23);
            this.passTextBox.TabIndex = 0;
            this.passTextBox.UseSelectable = true;
            this.passTextBox.UseSystemPasswordChar = true;
            this.passTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // contButton
            // 
            this.contButton.Location = new System.Drawing.Point(61, 109);
            this.contButton.Name = "contButton";
            this.contButton.Size = new System.Drawing.Size(161, 23);
            this.contButton.TabIndex = 1;
            this.contButton.Text = "Продолжить";
            this.contButton.UseSelectable = true;
            this.contButton.Click += new System.EventHandler(this.contButton_Click);
            // 
            // adminpassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 155);
            this.Controls.Add(this.contButton);
            this.Controls.Add(this.passTextBox);
            this.Name = "adminpassForm";
            this.Text = "Введите пароль";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox passTextBox;
        private MetroFramework.Controls.MetroButton contButton;
    }
}