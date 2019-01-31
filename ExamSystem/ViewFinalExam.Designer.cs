namespace ExamSystem
{
    partial class ViewFinalExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFinalExam));
            this.UserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.reportButton = new MetroFramework.Controls.MetroButton();
            this.goBackButton = new MetroFramework.Controls.MetroButton();
            this.ResultLabel = new MetroFramework.Controls.MetroLabel();
            this.ExamTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.CurrentAnswerLabel = new MetroFramework.Controls.MetroLabel();
            this.AnswerLabel = new MetroFramework.Controls.MetroLabel();
            this.CurrentAnswerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserAnswerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuestionLabel1 = new MetroFramework.Controls.MetroLabel();
            this.QuestionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuestionLabel = new MetroFramework.Controls.MetroLabel();
            this.QuestionsListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.UserNameLabel.Location = new System.Drawing.Point(281, 30);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(33, 15);
            this.UserNameLabel.TabIndex = 10054;
            this.UserNameLabel.Text = "ФИО";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(708, 538);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(88, 43);
            this.reportButton.TabIndex = 10053;
            this.reportButton.Text = "Отчет";
            this.reportButton.UseSelectable = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackButton.Location = new System.Drawing.Point(238, 30);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(37, 21);
            this.goBackButton.Style = MetroFramework.MetroColorStyle.White;
            this.goBackButton.TabIndex = 10052;
            this.goBackButton.Text = "<<";
            this.goBackButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.goBackButton.UseCustomBackColor = true;
            this.goBackButton.UseSelectable = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ResultLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ResultLabel.Location = new System.Drawing.Point(442, 538);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(96, 25);
            this.ResultLabel.TabIndex = 10050;
            this.ResultLabel.Text = "Результат";
            // 
            // ExamTimeLabel
            // 
            this.ExamTimeLabel.AutoSize = true;
            this.ExamTimeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ExamTimeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ExamTimeLabel.Location = new System.Drawing.Point(440, 507);
            this.ExamTimeLabel.Name = "ExamTimeLabel";
            this.ExamTimeLabel.Size = new System.Drawing.Size(231, 25);
            this.ExamTimeLabel.TabIndex = 10049;
            this.ExamTimeLabel.Text = "Общее время экзамена: ";
            // 
            // CurrentAnswerLabel
            // 
            this.CurrentAnswerLabel.AutoSize = true;
            this.CurrentAnswerLabel.Location = new System.Drawing.Point(442, 391);
            this.CurrentAnswerLabel.Name = "CurrentAnswerLabel";
            this.CurrentAnswerLabel.Size = new System.Drawing.Size(122, 19);
            this.CurrentAnswerLabel.TabIndex = 10048;
            this.CurrentAnswerLabel.Text = "Правильный ответ";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(442, 276);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(131, 19);
            this.AnswerLabel.TabIndex = 10047;
            this.AnswerLabel.Text = "Ответ пользователя";
            // 
            // CurrentAnswerTextBox
            // 
            // 
            // 
            // 
            this.CurrentAnswerTextBox.CustomButton.Image = null;
            this.CurrentAnswerTextBox.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.CurrentAnswerTextBox.CustomButton.Name = "";
            this.CurrentAnswerTextBox.CustomButton.Size = new System.Drawing.Size(77, 77);
            this.CurrentAnswerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CurrentAnswerTextBox.CustomButton.TabIndex = 1;
            this.CurrentAnswerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CurrentAnswerTextBox.CustomButton.UseSelectable = true;
            this.CurrentAnswerTextBox.CustomButton.Visible = false;
            this.CurrentAnswerTextBox.Lines = new string[0];
            this.CurrentAnswerTextBox.Location = new System.Drawing.Point(442, 413);
            this.CurrentAnswerTextBox.MaxLength = 32767;
            this.CurrentAnswerTextBox.Multiline = true;
            this.CurrentAnswerTextBox.Name = "CurrentAnswerTextBox";
            this.CurrentAnswerTextBox.PasswordChar = '\0';
            this.CurrentAnswerTextBox.ReadOnly = true;
            this.CurrentAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CurrentAnswerTextBox.SelectedText = "";
            this.CurrentAnswerTextBox.SelectionLength = 0;
            this.CurrentAnswerTextBox.SelectionStart = 0;
            this.CurrentAnswerTextBox.ShortcutsEnabled = true;
            this.CurrentAnswerTextBox.Size = new System.Drawing.Size(358, 82);
            this.CurrentAnswerTextBox.TabIndex = 10046;
            this.CurrentAnswerTextBox.UseSelectable = true;
            this.CurrentAnswerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CurrentAnswerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserAnswerTextBox
            // 
            // 
            // 
            // 
            this.UserAnswerTextBox.CustomButton.Image = null;
            this.UserAnswerTextBox.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.UserAnswerTextBox.CustomButton.Name = "";
            this.UserAnswerTextBox.CustomButton.Size = new System.Drawing.Size(77, 77);
            this.UserAnswerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserAnswerTextBox.CustomButton.TabIndex = 1;
            this.UserAnswerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserAnswerTextBox.CustomButton.UseSelectable = true;
            this.UserAnswerTextBox.CustomButton.Visible = false;
            this.UserAnswerTextBox.Lines = new string[0];
            this.UserAnswerTextBox.Location = new System.Drawing.Point(442, 298);
            this.UserAnswerTextBox.MaxLength = 32767;
            this.UserAnswerTextBox.Multiline = true;
            this.UserAnswerTextBox.Name = "UserAnswerTextBox";
            this.UserAnswerTextBox.PasswordChar = '\0';
            this.UserAnswerTextBox.ReadOnly = true;
            this.UserAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserAnswerTextBox.SelectedText = "";
            this.UserAnswerTextBox.SelectionLength = 0;
            this.UserAnswerTextBox.SelectionStart = 0;
            this.UserAnswerTextBox.ShortcutsEnabled = true;
            this.UserAnswerTextBox.Size = new System.Drawing.Size(358, 82);
            this.UserAnswerTextBox.TabIndex = 10045;
            this.UserAnswerTextBox.UseSelectable = true;
            this.UserAnswerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserAnswerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QuestionLabel1
            // 
            this.QuestionLabel1.AutoSize = true;
            this.QuestionLabel1.Location = new System.Drawing.Point(442, 105);
            this.QuestionLabel1.Name = "QuestionLabel1";
            this.QuestionLabel1.Size = new System.Drawing.Size(55, 19);
            this.QuestionLabel1.TabIndex = 10044;
            this.QuestionLabel1.Text = "Вопрос";
            // 
            // QuestionTextBox
            // 
            // 
            // 
            // 
            this.QuestionTextBox.CustomButton.Image = null;
            this.QuestionTextBox.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.QuestionTextBox.CustomButton.Name = "";
            this.QuestionTextBox.CustomButton.Size = new System.Drawing.Size(131, 131);
            this.QuestionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuestionTextBox.CustomButton.TabIndex = 1;
            this.QuestionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuestionTextBox.CustomButton.UseSelectable = true;
            this.QuestionTextBox.CustomButton.Visible = false;
            this.QuestionTextBox.Lines = new string[0];
            this.QuestionTextBox.Location = new System.Drawing.Point(442, 127);
            this.QuestionTextBox.MaxLength = 32767;
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.PasswordChar = '\0';
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuestionTextBox.SelectedText = "";
            this.QuestionTextBox.SelectionLength = 0;
            this.QuestionTextBox.SelectionStart = 0;
            this.QuestionTextBox.ShortcutsEnabled = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(358, 136);
            this.QuestionTextBox.TabIndex = 10043;
            this.QuestionTextBox.UseSelectable = true;
            this.QuestionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuestionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(23, 60);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(64, 19);
            this.QuestionLabel.TabIndex = 10042;
            this.QuestionLabel.Text = "Вопросы";
            // 
            // QuestionsListBox
            // 
            this.QuestionsListBox.FormattingEnabled = true;
            this.QuestionsListBox.Location = new System.Drawing.Point(24, 91);
            this.QuestionsListBox.Name = "QuestionsListBox";
            this.QuestionsListBox.Size = new System.Drawing.Size(315, 472);
            this.QuestionsListBox.TabIndex = 10040;
            this.QuestionsListBox.SelectedValueChanged += new System.EventHandler(this.QuestionsListBox_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamSystem.Properties.Resources.civssm;
            this.pictureBox1.Location = new System.Drawing.Point(725, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10051;
            this.pictureBox1.TabStop = false;
            // 
            // ViewFinalExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 606);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ExamTimeLabel);
            this.Controls.Add(this.CurrentAnswerLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.CurrentAnswerTextBox);
            this.Controls.Add(this.UserAnswerTextBox);
            this.Controls.Add(this.QuestionLabel1);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.QuestionsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewFinalExam";
            this.Text = "Просмотр экзамена";
            this.Load += new System.EventHandler(this.ViewFinalExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel UserNameLabel;
        private MetroFramework.Controls.MetroButton reportButton;
        private MetroFramework.Controls.MetroButton goBackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel ResultLabel;
        private MetroFramework.Controls.MetroLabel ExamTimeLabel;
        private MetroFramework.Controls.MetroLabel CurrentAnswerLabel;
        private MetroFramework.Controls.MetroLabel AnswerLabel;
        private MetroFramework.Controls.MetroTextBox CurrentAnswerTextBox;
        private MetroFramework.Controls.MetroTextBox UserAnswerTextBox;
        private MetroFramework.Controls.MetroLabel QuestionLabel1;
        private MetroFramework.Controls.MetroTextBox QuestionTextBox;
        private MetroFramework.Controls.MetroLabel QuestionLabel;
        private System.Windows.Forms.ListBox QuestionsListBox;
    }
}