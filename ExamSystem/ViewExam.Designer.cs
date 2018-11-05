namespace ExamSystem
{
    partial class ViewExam
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
            this.QuestionsListBox = new System.Windows.Forms.ListBox();
            this.PartComboBox = new MetroFramework.Controls.MetroComboBox();
            this.QuestionLabel = new MetroFramework.Controls.MetroLabel();
            this.QuestionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuestionLabel1 = new MetroFramework.Controls.MetroLabel();
            this.UserAnswerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CurrentAnswerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AnswerLabel = new MetroFramework.Controls.MetroLabel();
            this.CurrentAnswerLabel = new MetroFramework.Controls.MetroLabel();
            this.ExamTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.ResultLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // QuestionsListBox
            // 
            this.QuestionsListBox.FormattingEnabled = true;
            this.QuestionsListBox.Location = new System.Drawing.Point(23, 130);
            this.QuestionsListBox.Name = "QuestionsListBox";
            this.QuestionsListBox.Size = new System.Drawing.Size(315, 433);
            this.QuestionsListBox.TabIndex = 1;
            this.QuestionsListBox.SelectedValueChanged += new System.EventHandler(this.QuestionsListBox_SelectedValueChanged);
            // 
            // PartComboBox
            // 
            this.PartComboBox.FormattingEnabled = true;
            this.PartComboBox.ItemHeight = 23;
            this.PartComboBox.Items.AddRange(new object[] {
            "Часть 1",
            "Часть 2",
            "Часть 3",
            "Часть 4",
            "Часть 5"});
            this.PartComboBox.Location = new System.Drawing.Point(23, 63);
            this.PartComboBox.Name = "PartComboBox";
            this.PartComboBox.Size = new System.Drawing.Size(171, 29);
            this.PartComboBox.TabIndex = 12;
            this.PartComboBox.UseSelectable = true;
            this.PartComboBox.SelectedValueChanged += new System.EventHandler(this.PartComboBox_SelectedValueChanged);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(23, 108);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(55, 19);
            this.QuestionLabel.TabIndex = 13;
            this.QuestionLabel.Text = "Вопрос";
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
            this.QuestionTextBox.Location = new System.Drawing.Point(441, 127);
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
            this.QuestionTextBox.TabIndex = 14;
            this.QuestionTextBox.UseSelectable = true;
            this.QuestionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuestionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QuestionLabel1
            // 
            this.QuestionLabel1.AutoSize = true;
            this.QuestionLabel1.Location = new System.Drawing.Point(441, 105);
            this.QuestionLabel1.Name = "QuestionLabel1";
            this.QuestionLabel1.Size = new System.Drawing.Size(55, 19);
            this.QuestionLabel1.TabIndex = 15;
            this.QuestionLabel1.Text = "Вопрос";
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
            this.UserAnswerTextBox.Location = new System.Drawing.Point(441, 298);
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
            this.UserAnswerTextBox.TabIndex = 16;
            this.UserAnswerTextBox.UseSelectable = true;
            this.UserAnswerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserAnswerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.CurrentAnswerTextBox.Location = new System.Drawing.Point(441, 413);
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
            this.CurrentAnswerTextBox.TabIndex = 17;
            this.CurrentAnswerTextBox.UseSelectable = true;
            this.CurrentAnswerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CurrentAnswerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(441, 276);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(131, 19);
            this.AnswerLabel.TabIndex = 18;
            this.AnswerLabel.Text = "Ответ пользователя";
            // 
            // CurrentAnswerLabel
            // 
            this.CurrentAnswerLabel.AutoSize = true;
            this.CurrentAnswerLabel.Location = new System.Drawing.Point(441, 391);
            this.CurrentAnswerLabel.Name = "CurrentAnswerLabel";
            this.CurrentAnswerLabel.Size = new System.Drawing.Size(122, 19);
            this.CurrentAnswerLabel.TabIndex = 19;
            this.CurrentAnswerLabel.Text = "Правильный ответ";
            // 
            // ExamTimeLabel
            // 
            this.ExamTimeLabel.AutoSize = true;
            this.ExamTimeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ExamTimeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ExamTimeLabel.Location = new System.Drawing.Point(439, 507);
            this.ExamTimeLabel.Name = "ExamTimeLabel";
            this.ExamTimeLabel.Size = new System.Drawing.Size(231, 25);
            this.ExamTimeLabel.TabIndex = 20;
            this.ExamTimeLabel.Text = "Общее время экзамена: ";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ResultLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ResultLabel.Location = new System.Drawing.Point(441, 538);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(96, 25);
            this.ResultLabel.TabIndex = 21;
            this.ResultLabel.Text = "Результат";
            // 
            // ViewExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 604);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ExamTimeLabel);
            this.Controls.Add(this.CurrentAnswerLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.CurrentAnswerTextBox);
            this.Controls.Add(this.UserAnswerTextBox);
            this.Controls.Add(this.QuestionLabel1);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.PartComboBox);
            this.Controls.Add(this.QuestionsListBox);
            this.Name = "ViewExam";
            this.Text = "Просмотр экзамена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox QuestionsListBox;
        private MetroFramework.Controls.MetroComboBox PartComboBox;
        private MetroFramework.Controls.MetroLabel QuestionLabel;
        private MetroFramework.Controls.MetroTextBox QuestionTextBox;
        private MetroFramework.Controls.MetroLabel QuestionLabel1;
        private MetroFramework.Controls.MetroTextBox UserAnswerTextBox;
        private MetroFramework.Controls.MetroTextBox CurrentAnswerTextBox;
        private MetroFramework.Controls.MetroLabel AnswerLabel;
        private MetroFramework.Controls.MetroLabel CurrentAnswerLabel;
        private MetroFramework.Controls.MetroLabel ExamTimeLabel;
        private MetroFramework.Controls.MetroLabel ResultLabel;
    }
}