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
            this.PartComboBox = new System.Windows.Forms.ComboBox();
            this.QuestionsListBox = new System.Windows.Forms.ListBox();
            this.UserAnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.CurrentAnswerLabel = new System.Windows.Forms.Label();
            this.CurrentAnswerTextBox = new System.Windows.Forms.RichTextBox();
            this.ExamTimeLabel = new System.Windows.Forms.Label();
            this.CompleteLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.QuestionLabel1 = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PartComboBox
            // 
            this.PartComboBox.FormattingEnabled = true;
            this.PartComboBox.Items.AddRange(new object[] {
            "Часть 1",
            "Часть 2",
            "Часть 3",
            "Часть 4",
            "Часть 5"});
            this.PartComboBox.Location = new System.Drawing.Point(12, 12);
            this.PartComboBox.Name = "PartComboBox";
            this.PartComboBox.Size = new System.Drawing.Size(131, 21);
            this.PartComboBox.TabIndex = 0;
            this.PartComboBox.SelectedValueChanged += new System.EventHandler(this.PartComboBox_SelectedValueChanged);
            // 
            // QuestionsListBox
            // 
            this.QuestionsListBox.FormattingEnabled = true;
            this.QuestionsListBox.Location = new System.Drawing.Point(12, 57);
            this.QuestionsListBox.Name = "QuestionsListBox";
            this.QuestionsListBox.Size = new System.Drawing.Size(315, 433);
            this.QuestionsListBox.TabIndex = 1;
            this.QuestionsListBox.SelectedValueChanged += new System.EventHandler(this.QuestionsListBox_SelectedValueChanged);
            // 
            // UserAnswerTextBox
            // 
            this.UserAnswerTextBox.Location = new System.Drawing.Point(430, 231);
            this.UserAnswerTextBox.Name = "UserAnswerTextBox";
            this.UserAnswerTextBox.ReadOnly = true;
            this.UserAnswerTextBox.Size = new System.Drawing.Size(358, 82);
            this.UserAnswerTextBox.TabIndex = 2;
            this.UserAnswerTextBox.TabStop = false;
            this.UserAnswerTextBox.Text = "";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(9, 41);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(44, 13);
            this.QuestionLabel.TabIndex = 3;
            this.QuestionLabel.Text = "Вопрос";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(427, 215);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(111, 13);
            this.AnswerLabel.TabIndex = 4;
            this.AnswerLabel.Text = "Ответ пользователя";
            // 
            // CurrentAnswerLabel
            // 
            this.CurrentAnswerLabel.AutoSize = true;
            this.CurrentAnswerLabel.Location = new System.Drawing.Point(427, 319);
            this.CurrentAnswerLabel.Name = "CurrentAnswerLabel";
            this.CurrentAnswerLabel.Size = new System.Drawing.Size(102, 13);
            this.CurrentAnswerLabel.TabIndex = 6;
            this.CurrentAnswerLabel.Text = "Правильный ответ";
            // 
            // CurrentAnswerTextBox
            // 
            this.CurrentAnswerTextBox.Location = new System.Drawing.Point(430, 335);
            this.CurrentAnswerTextBox.Name = "CurrentAnswerTextBox";
            this.CurrentAnswerTextBox.ReadOnly = true;
            this.CurrentAnswerTextBox.Size = new System.Drawing.Size(358, 82);
            this.CurrentAnswerTextBox.TabIndex = 5;
            this.CurrentAnswerTextBox.Text = "";
            // 
            // ExamTimeLabel
            // 
            this.ExamTimeLabel.AutoSize = true;
            this.ExamTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ExamTimeLabel.Location = new System.Drawing.Point(426, 434);
            this.ExamTimeLabel.Name = "ExamTimeLabel";
            this.ExamTimeLabel.Size = new System.Drawing.Size(222, 22);
            this.ExamTimeLabel.TabIndex = 7;
            this.ExamTimeLabel.Text = "Общее время экзамена: ";
            // 
            // CompleteLabel
            // 
            this.CompleteLabel.AutoSize = true;
            this.CompleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.CompleteLabel.Location = new System.Drawing.Point(572, 12);
            this.CompleteLabel.Name = "CompleteLabel";
            this.CompleteLabel.Size = new System.Drawing.Size(103, 22);
            this.CompleteLabel.TabIndex = 8;
            this.CompleteLabel.Text = "завершен?";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ResultLabel.Location = new System.Drawing.Point(426, 470);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(95, 22);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.Text = "Результат";
            // 
            // QuestionLabel1
            // 
            this.QuestionLabel1.AutoSize = true;
            this.QuestionLabel1.Location = new System.Drawing.Point(427, 41);
            this.QuestionLabel1.Name = "QuestionLabel1";
            this.QuestionLabel1.Size = new System.Drawing.Size(44, 13);
            this.QuestionLabel1.TabIndex = 11;
            this.QuestionLabel1.Text = "Вопрос";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(430, 57);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(358, 138);
            this.QuestionTextBox.TabIndex = 10;
            this.QuestionTextBox.TabStop = false;
            this.QuestionTextBox.Text = "";
            // 
            // ViewExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.QuestionLabel1);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CompleteLabel);
            this.Controls.Add(this.ExamTimeLabel);
            this.Controls.Add(this.CurrentAnswerLabel);
            this.Controls.Add(this.CurrentAnswerTextBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.UserAnswerTextBox);
            this.Controls.Add(this.QuestionsListBox);
            this.Controls.Add(this.PartComboBox);
            this.Name = "ViewExam";
            this.Text = "Просмотр экзамена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PartComboBox;
        private System.Windows.Forms.ListBox QuestionsListBox;
        private System.Windows.Forms.RichTextBox UserAnswerTextBox;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label CurrentAnswerLabel;
        private System.Windows.Forms.RichTextBox CurrentAnswerTextBox;
        private System.Windows.Forms.Label ExamTimeLabel;
        private System.Windows.Forms.Label CompleteLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label QuestionLabel1;
        private System.Windows.Forms.RichTextBox QuestionTextBox;
    }
}