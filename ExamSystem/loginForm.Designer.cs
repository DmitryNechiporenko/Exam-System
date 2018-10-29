namespace ExamSystem
{
    partial class loginForm
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
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.PatrLabel = new System.Windows.Forms.Label();
            this.patrTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(150, 22);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(161, 20);
            this.surnameTextBox.TabIndex = 0;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(88, 25);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 999;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(227, 152);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(84, 38);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(100, 152);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(121, 38);
            this.regButton.TabIndex = 5;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(115, 51);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 998;
            this.NameLabel.Text = "Имя";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(150, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(161, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // PatrLabel
            // 
            this.PatrLabel.AutoSize = true;
            this.PatrLabel.Location = new System.Drawing.Point(11, 77);
            this.PatrLabel.Name = "PatrLabel";
            this.PatrLabel.Size = new System.Drawing.Size(133, 13);
            this.PatrLabel.TabIndex = 997;
            this.PatrLabel.Text = "Отчество (если имеется)";
            // 
            // patrTextBox
            // 
            this.patrTextBox.Location = new System.Drawing.Point(150, 74);
            this.patrTextBox.Name = "patrTextBox";
            this.patrTextBox.Size = new System.Drawing.Size(161, 20);
            this.patrTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(150, 100);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(161, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(97, 103);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 996;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 202);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.PatrLabel);
            this.Controls.Add(this.patrTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Name = "loginForm";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label PatrLabel;
        private System.Windows.Forms.TextBox patrTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}