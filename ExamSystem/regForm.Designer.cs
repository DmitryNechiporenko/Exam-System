namespace ExamSystem
{
    partial class regForm
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
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patrLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.orgLabel = new System.Windows.Forms.Label();
            this.posLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.posTextBox = new System.Windows.Forms.TextBox();
            this.orgTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.patrTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(85, 15);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(112, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // patrLabel
            // 
            this.patrLabel.AutoSize = true;
            this.patrLabel.Location = new System.Drawing.Point(8, 67);
            this.patrLabel.Name = "patrLabel";
            this.patrLabel.Size = new System.Drawing.Size(133, 13);
            this.patrLabel.TabIndex = 2;
            this.patrLabel.Text = "Отчество (если имеется)";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(104, 93);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 13);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "Город";
            // 
            // orgLabel
            // 
            this.orgLabel.AutoSize = true;
            this.orgLabel.Location = new System.Drawing.Point(67, 119);
            this.orgLabel.Name = "orgLabel";
            this.orgLabel.Size = new System.Drawing.Size(74, 13);
            this.orgLabel.TabIndex = 4;
            this.orgLabel.Text = "Организация";
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Location = new System.Drawing.Point(76, 145);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(65, 13);
            this.posLabel.TabIndex = 5;
            this.posLabel.Text = "Должность";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(147, 12);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(194, 20);
            this.surnameTextBox.TabIndex = 0;
            // 
            // posTextBox
            // 
            this.posTextBox.Location = new System.Drawing.Point(147, 142);
            this.posTextBox.Name = "posTextBox";
            this.posTextBox.Size = new System.Drawing.Size(194, 20);
            this.posTextBox.TabIndex = 5;
            // 
            // orgTextBox
            // 
            this.orgTextBox.Location = new System.Drawing.Point(147, 116);
            this.orgTextBox.Name = "orgTextBox";
            this.orgTextBox.Size = new System.Drawing.Size(194, 20);
            this.orgTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(147, 90);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(194, 20);
            this.cityTextBox.TabIndex = 3;
            // 
            // patrTextBox
            // 
            this.patrTextBox.Location = new System.Drawing.Point(147, 64);
            this.patrTextBox.Name = "patrTextBox";
            this.patrTextBox.Size = new System.Drawing.Size(194, 20);
            this.patrTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(147, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(147, 216);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(194, 36);
            this.regButton.TabIndex = 16;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(147, 168);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(194, 20);
            this.passTextBox.TabIndex = 6;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(96, 171);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(45, 13);
            this.passLabel.TabIndex = 17;
            this.passLabel.Text = "Пароль";
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 264);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.patrTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.orgTextBox);
            this.Controls.Add(this.posTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.posLabel);
            this.Controls.Add(this.orgLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.patrLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Name = "regForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patrLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label orgLabel;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox posTextBox;
        private System.Windows.Forms.TextBox orgTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox patrTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passLabel;
    }
}