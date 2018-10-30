namespace ExamSystem
{
    partial class LearnQuiz
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
            this.randomButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.QuestionTextBox = new System.Windows.Forms.RichTextBox();
            this.Answer1Label = new System.Windows.Forms.Label();
            this.Answer2Label = new System.Windows.Forms.Label();
            this.Answer3Label = new System.Windows.Forms.Label();
            this.Answer4Label = new System.Windows.Forms.Label();
            this.Answer1Radio = new System.Windows.Forms.RadioButton();
            this.Answer2Radio = new System.Windows.Forms.RadioButton();
            this.Answer3Radio = new System.Windows.Forms.RadioButton();
            this.Answer4Radio = new System.Windows.Forms.RadioButton();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.CommentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(136, 154);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(254, 146);
            this.randomButton.TabIndex = 0;
            this.randomButton.Text = "Случайная выборка вопросв";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(396, 154);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(254, 146);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "Вопросы по порядку";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 12);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(776, 136);
            this.QuestionTextBox.TabIndex = 2;
            this.QuestionTextBox.TabStop = false;
            this.QuestionTextBox.Text = "";
            this.QuestionTextBox.Visible = false;
            // 
            // Answer1Label
            // 
            this.Answer1Label.AutoSize = true;
            this.Answer1Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer1Label.Location = new System.Drawing.Point(41, 164);
            this.Answer1Label.Name = "Answer1Label";
            this.Answer1Label.Size = new System.Drawing.Size(51, 13);
            this.Answer1Label.TabIndex = 3;
            this.Answer1Label.Text = "Answer 1";
            this.Answer1Label.Visible = false;
            this.Answer1Label.Click += new System.EventHandler(this.Answer1Label_Click);
            // 
            // Answer2Label
            // 
            this.Answer2Label.AutoSize = true;
            this.Answer2Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer2Label.Location = new System.Drawing.Point(41, 201);
            this.Answer2Label.Name = "Answer2Label";
            this.Answer2Label.Size = new System.Drawing.Size(51, 13);
            this.Answer2Label.TabIndex = 4;
            this.Answer2Label.Text = "Answer 2";
            this.Answer2Label.Visible = false;
            this.Answer2Label.Click += new System.EventHandler(this.Answer2Label_Click);
            // 
            // Answer3Label
            // 
            this.Answer3Label.AutoSize = true;
            this.Answer3Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer3Label.Location = new System.Drawing.Point(41, 238);
            this.Answer3Label.Name = "Answer3Label";
            this.Answer3Label.Size = new System.Drawing.Size(51, 13);
            this.Answer3Label.TabIndex = 5;
            this.Answer3Label.Text = "Answer 3";
            this.Answer3Label.Visible = false;
            this.Answer3Label.Click += new System.EventHandler(this.Answer3Label_Click);
            // 
            // Answer4Label
            // 
            this.Answer4Label.AutoSize = true;
            this.Answer4Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer4Label.Location = new System.Drawing.Point(41, 278);
            this.Answer4Label.Name = "Answer4Label";
            this.Answer4Label.Size = new System.Drawing.Size(51, 13);
            this.Answer4Label.TabIndex = 6;
            this.Answer4Label.Text = "Answer 4";
            this.Answer4Label.Visible = false;
            this.Answer4Label.Click += new System.EventHandler(this.Answer4Label_Click);
            // 
            // Answer1Radio
            // 
            this.Answer1Radio.AutoSize = true;
            this.Answer1Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer1Radio.Location = new System.Drawing.Point(21, 164);
            this.Answer1Radio.Name = "Answer1Radio";
            this.Answer1Radio.Size = new System.Drawing.Size(14, 13);
            this.Answer1Radio.TabIndex = 7;
            this.Answer1Radio.TabStop = true;
            this.Answer1Radio.UseVisualStyleBackColor = true;
            this.Answer1Radio.Visible = false;
            // 
            // Answer2Radio
            // 
            this.Answer2Radio.AutoSize = true;
            this.Answer2Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer2Radio.Location = new System.Drawing.Point(21, 201);
            this.Answer2Radio.Name = "Answer2Radio";
            this.Answer2Radio.Size = new System.Drawing.Size(14, 13);
            this.Answer2Radio.TabIndex = 8;
            this.Answer2Radio.TabStop = true;
            this.Answer2Radio.UseVisualStyleBackColor = true;
            this.Answer2Radio.Visible = false;
            // 
            // Answer3Radio
            // 
            this.Answer3Radio.AutoSize = true;
            this.Answer3Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer3Radio.Location = new System.Drawing.Point(21, 238);
            this.Answer3Radio.Name = "Answer3Radio";
            this.Answer3Radio.Size = new System.Drawing.Size(14, 13);
            this.Answer3Radio.TabIndex = 9;
            this.Answer3Radio.TabStop = true;
            this.Answer3Radio.UseVisualStyleBackColor = true;
            this.Answer3Radio.Visible = false;
            // 
            // Answer4Radio
            // 
            this.Answer4Radio.AutoSize = true;
            this.Answer4Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer4Radio.Location = new System.Drawing.Point(21, 278);
            this.Answer4Radio.Name = "Answer4Radio";
            this.Answer4Radio.Size = new System.Drawing.Size(14, 13);
            this.Answer4Radio.TabIndex = 10;
            this.Answer4Radio.TabStop = true;
            this.Answer4Radio.UseVisualStyleBackColor = true;
            this.Answer4Radio.Visible = false;
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(510, 396);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(136, 42);
            this.AnswerButton.TabIndex = 11;
            this.AnswerButton.Text = "Ответить";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Visible = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(652, 396);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(136, 42);
            this.NextQuestionButton.TabIndex = 12;
            this.NextQuestionButton.Text = "Пропустить";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Visible = false;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // CommentButton
            // 
            this.CommentButton.Location = new System.Drawing.Point(368, 396);
            this.CommentButton.Name = "CommentButton";
            this.CommentButton.Size = new System.Drawing.Size(136, 42);
            this.CommentButton.TabIndex = 13;
            this.CommentButton.Text = "Комментарий";
            this.CommentButton.UseVisualStyleBackColor = true;
            this.CommentButton.Visible = false;
            this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // LearnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommentButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.Answer4Radio);
            this.Controls.Add(this.Answer3Radio);
            this.Controls.Add(this.Answer2Radio);
            this.Controls.Add(this.Answer1Radio);
            this.Controls.Add(this.Answer4Label);
            this.Controls.Add(this.Answer3Label);
            this.Controls.Add(this.Answer2Label);
            this.Controls.Add(this.Answer1Label);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.randomButton);
            this.Name = "LearnForm";
            this.Text = "Обучение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.RichTextBox QuestionTextBox;
        private System.Windows.Forms.Label Answer1Label;
        private System.Windows.Forms.Label Answer2Label;
        private System.Windows.Forms.Label Answer3Label;
        private System.Windows.Forms.Label Answer4Label;
        private System.Windows.Forms.RadioButton Answer1Radio;
        private System.Windows.Forms.RadioButton Answer2Radio;
        private System.Windows.Forms.RadioButton Answer3Radio;
        private System.Windows.Forms.RadioButton Answer4Radio;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button CommentButton;
    }
}