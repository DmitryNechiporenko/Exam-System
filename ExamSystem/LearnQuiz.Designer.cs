﻿namespace ExamSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnQuiz));
            this.QuestionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Answer1Radio = new MetroFramework.Controls.MetroRadioButton();
            this.Answer2Radio = new MetroFramework.Controls.MetroRadioButton();
            this.Answer3Radio = new MetroFramework.Controls.MetroRadioButton();
            this.Answer4Radio = new MetroFramework.Controls.MetroRadioButton();
            this.CommentButton = new MetroFramework.Controls.MetroButton();
            this.AnswerButton = new MetroFramework.Controls.MetroButton();
            this.NextQuestionButton = new MetroFramework.Controls.MetroButton();
            this.randomButton = new MetroFramework.Controls.MetroButton();
            this.orderButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goBackButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionTextBox
            // 
            // 
            // 
            // 
            this.QuestionTextBox.CustomButton.Image = null;
            this.QuestionTextBox.CustomButton.Location = new System.Drawing.Point(644, 1);
            this.QuestionTextBox.CustomButton.Name = "";
            this.QuestionTextBox.CustomButton.Size = new System.Drawing.Size(131, 131);
            this.QuestionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuestionTextBox.CustomButton.TabIndex = 1;
            this.QuestionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuestionTextBox.CustomButton.UseSelectable = true;
            this.QuestionTextBox.CustomButton.Visible = false;
            this.QuestionTextBox.Lines = new string[0];
            this.QuestionTextBox.Location = new System.Drawing.Point(23, 101);
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
            this.QuestionTextBox.Size = new System.Drawing.Size(776, 133);
            this.QuestionTextBox.TabIndex = 14;
            this.QuestionTextBox.UseSelectable = true;
            this.QuestionTextBox.Visible = false;
            this.QuestionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuestionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Answer1Radio
            // 
            this.Answer1Radio.AutoSize = true;
            this.Answer1Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer1Radio.Location = new System.Drawing.Point(27, 253);
            this.Answer1Radio.Name = "Answer1Radio";
            this.Answer1Radio.Size = new System.Drawing.Size(71, 15);
            this.Answer1Radio.TabIndex = 15;
            this.Answer1Radio.Text = "Answer 1";
            this.Answer1Radio.UseSelectable = true;
            this.Answer1Radio.Visible = false;
            // 
            // Answer2Radio
            // 
            this.Answer2Radio.AutoSize = true;
            this.Answer2Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer2Radio.Location = new System.Drawing.Point(27, 287);
            this.Answer2Radio.Name = "Answer2Radio";
            this.Answer2Radio.Size = new System.Drawing.Size(71, 15);
            this.Answer2Radio.TabIndex = 16;
            this.Answer2Radio.Text = "Answer 2";
            this.Answer2Radio.UseSelectable = true;
            this.Answer2Radio.Visible = false;
            // 
            // Answer3Radio
            // 
            this.Answer3Radio.AutoSize = true;
            this.Answer3Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer3Radio.Location = new System.Drawing.Point(27, 318);
            this.Answer3Radio.Name = "Answer3Radio";
            this.Answer3Radio.Size = new System.Drawing.Size(71, 15);
            this.Answer3Radio.TabIndex = 17;
            this.Answer3Radio.Text = "Answer 3";
            this.Answer3Radio.UseSelectable = true;
            this.Answer3Radio.Visible = false;
            // 
            // Answer4Radio
            // 
            this.Answer4Radio.AutoSize = true;
            this.Answer4Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer4Radio.Location = new System.Drawing.Point(27, 350);
            this.Answer4Radio.Name = "Answer4Radio";
            this.Answer4Radio.Size = new System.Drawing.Size(71, 15);
            this.Answer4Radio.TabIndex = 18;
            this.Answer4Radio.Text = "Answer 4";
            this.Answer4Radio.UseSelectable = true;
            this.Answer4Radio.Visible = false;
            // 
            // CommentButton
            // 
            this.CommentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommentButton.Location = new System.Drawing.Point(370, 447);
            this.CommentButton.Name = "CommentButton";
            this.CommentButton.Size = new System.Drawing.Size(136, 42);
            this.CommentButton.TabIndex = 19;
            this.CommentButton.TabStop = false;
            this.CommentButton.Text = "Комментарий";
            this.CommentButton.UseSelectable = true;
            this.CommentButton.Visible = false;
            this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // AnswerButton
            // 
            this.AnswerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerButton.Location = new System.Drawing.Point(512, 447);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(136, 42);
            this.AnswerButton.TabIndex = 20;
            this.AnswerButton.TabStop = false;
            this.AnswerButton.Text = "Ответить";
            this.AnswerButton.UseSelectable = true;
            this.AnswerButton.Visible = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextQuestionButton.Location = new System.Drawing.Point(654, 447);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(136, 42);
            this.NextQuestionButton.TabIndex = 21;
            this.NextQuestionButton.TabStop = false;
            this.NextQuestionButton.Text = "Пропустить";
            this.NextQuestionButton.UseSelectable = true;
            this.NextQuestionButton.Visible = false;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomButton.Location = new System.Drawing.Point(75, 191);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(333, 153);
            this.randomButton.TabIndex = 22;
            this.randomButton.TabStop = false;
            this.randomButton.Text = "Случайная выборка вопросов";
            this.randomButton.UseSelectable = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderButton.Location = new System.Drawing.Point(414, 191);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(333, 153);
            this.orderButton.TabIndex = 23;
            this.orderButton.TabStop = false;
            this.orderButton.Text = "Вопросы по порядку";
            this.orderButton.UseSelectable = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamSystem.Properties.Resources.civssm;
            this.pictureBox1.Location = new System.Drawing.Point(724, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10035;
            this.pictureBox1.TabStop = false;
            // 
            // goBackButton
            // 
            this.goBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackButton.Location = new System.Drawing.Point(134, 28);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(37, 21);
            this.goBackButton.Style = MetroFramework.MetroColorStyle.White;
            this.goBackButton.TabIndex = 10036;
            this.goBackButton.Text = "<<";
            this.goBackButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.goBackButton.UseCustomBackColor = true;
            this.goBackButton.UseSelectable = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // LearnQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 507);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.CommentButton);
            this.Controls.Add(this.Answer4Radio);
            this.Controls.Add(this.Answer3Radio);
            this.Controls.Add(this.Answer2Radio);
            this.Controls.Add(this.Answer1Radio);
            this.Controls.Add(this.QuestionTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LearnQuiz";
            this.Resizable = false;
            this.Text = "Обучение";
            this.Load += new System.EventHandler(this.LearnQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox QuestionTextBox;
        private MetroFramework.Controls.MetroRadioButton Answer1Radio;
        private MetroFramework.Controls.MetroRadioButton Answer2Radio;
        private MetroFramework.Controls.MetroRadioButton Answer3Radio;
        private MetroFramework.Controls.MetroRadioButton Answer4Radio;
        private MetroFramework.Controls.MetroButton CommentButton;
        private MetroFramework.Controls.MetroButton AnswerButton;
        private MetroFramework.Controls.MetroButton NextQuestionButton;
        private MetroFramework.Controls.MetroButton randomButton;
        private MetroFramework.Controls.MetroButton orderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton goBackButton;
    }
}