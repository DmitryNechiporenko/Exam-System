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
            this.Answer1TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Answer2TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Answer3TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Answer4TextBox = new MetroFramework.Controls.MetroTextBox();
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
            this.Answer1Radio.Location = new System.Drawing.Point(27, 257);
            this.Answer1Radio.Name = "Answer1Radio";
            this.Answer1Radio.Size = new System.Drawing.Size(26, 15);
            this.Answer1Radio.TabIndex = 15;
            this.Answer1Radio.Text = " ";
            this.Answer1Radio.UseSelectable = true;
            this.Answer1Radio.Visible = false;
            this.Answer1Radio.VisibleChanged += new System.EventHandler(this.Answer1Radio_VisibleChanged);
            // 
            // Answer2Radio
            // 
            this.Answer2Radio.AutoSize = true;
            this.Answer2Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer2Radio.Location = new System.Drawing.Point(27, 314);
            this.Answer2Radio.MaximumSize = new System.Drawing.Size(400, 0);
            this.Answer2Radio.Name = "Answer2Radio";
            this.Answer2Radio.Size = new System.Drawing.Size(26, 15);
            this.Answer2Radio.TabIndex = 16;
            this.Answer2Radio.Text = " ";
            this.Answer2Radio.UseSelectable = true;
            this.Answer2Radio.Visible = false;
            this.Answer2Radio.VisibleChanged += new System.EventHandler(this.Answer2Radio_VisibleChanged);
            // 
            // Answer3Radio
            // 
            this.Answer3Radio.AutoSize = true;
            this.Answer3Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer3Radio.Location = new System.Drawing.Point(27, 371);
            this.Answer3Radio.MaximumSize = new System.Drawing.Size(400, 0);
            this.Answer3Radio.Name = "Answer3Radio";
            this.Answer3Radio.Size = new System.Drawing.Size(26, 15);
            this.Answer3Radio.TabIndex = 17;
            this.Answer3Radio.Text = " ";
            this.Answer3Radio.UseSelectable = true;
            this.Answer3Radio.Visible = false;
            this.Answer3Radio.VisibleChanged += new System.EventHandler(this.Answer3Radio_VisibleChanged);
            // 
            // Answer4Radio
            // 
            this.Answer4Radio.AutoSize = true;
            this.Answer4Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer4Radio.Location = new System.Drawing.Point(27, 428);
            this.Answer4Radio.Name = "Answer4Radio";
            this.Answer4Radio.Size = new System.Drawing.Size(26, 15);
            this.Answer4Radio.TabIndex = 18;
            this.Answer4Radio.Text = " ";
            this.Answer4Radio.UseSelectable = true;
            this.Answer4Radio.Visible = false;
            this.Answer4Radio.VisibleChanged += new System.EventHandler(this.Answer4Radio_VisibleChanged);
            // 
            // CommentButton
            // 
            this.CommentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommentButton.Location = new System.Drawing.Point(377, 508);
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
            this.AnswerButton.Location = new System.Drawing.Point(519, 508);
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
            this.NextQuestionButton.Location = new System.Drawing.Point(661, 508);
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
            // Answer1TextBox
            // 
            // 
            // 
            // 
            this.Answer1TextBox.CustomButton.Image = null;
            this.Answer1TextBox.CustomButton.Location = new System.Drawing.Point(597, 1);
            this.Answer1TextBox.CustomButton.Name = "";
            this.Answer1TextBox.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.Answer1TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Answer1TextBox.CustomButton.TabIndex = 1;
            this.Answer1TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer1TextBox.CustomButton.UseSelectable = true;
            this.Answer1TextBox.CustomButton.Visible = false;
            this.Answer1TextBox.Lines = new string[0];
            this.Answer1TextBox.Location = new System.Drawing.Point(59, 257);
            this.Answer1TextBox.MaxLength = 32767;
            this.Answer1TextBox.Multiline = true;
            this.Answer1TextBox.Name = "Answer1TextBox";
            this.Answer1TextBox.PasswordChar = '\0';
            this.Answer1TextBox.ReadOnly = true;
            this.Answer1TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Answer1TextBox.SelectedText = "";
            this.Answer1TextBox.SelectionLength = 0;
            this.Answer1TextBox.SelectionStart = 0;
            this.Answer1TextBox.ShortcutsEnabled = true;
            this.Answer1TextBox.Size = new System.Drawing.Size(647, 51);
            this.Answer1TextBox.TabIndex = 10037;
            this.Answer1TextBox.UseSelectable = true;
            this.Answer1TextBox.Visible = false;
            this.Answer1TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Answer1TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Answer2TextBox
            // 
            // 
            // 
            // 
            this.Answer2TextBox.CustomButton.Image = null;
            this.Answer2TextBox.CustomButton.Location = new System.Drawing.Point(597, 1);
            this.Answer2TextBox.CustomButton.Name = "";
            this.Answer2TextBox.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.Answer2TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Answer2TextBox.CustomButton.TabIndex = 1;
            this.Answer2TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer2TextBox.CustomButton.UseSelectable = true;
            this.Answer2TextBox.CustomButton.Visible = false;
            this.Answer2TextBox.Lines = new string[0];
            this.Answer2TextBox.Location = new System.Drawing.Point(59, 314);
            this.Answer2TextBox.MaxLength = 32767;
            this.Answer2TextBox.Multiline = true;
            this.Answer2TextBox.Name = "Answer2TextBox";
            this.Answer2TextBox.PasswordChar = '\0';
            this.Answer2TextBox.ReadOnly = true;
            this.Answer2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Answer2TextBox.SelectedText = "";
            this.Answer2TextBox.SelectionLength = 0;
            this.Answer2TextBox.SelectionStart = 0;
            this.Answer2TextBox.ShortcutsEnabled = true;
            this.Answer2TextBox.Size = new System.Drawing.Size(647, 51);
            this.Answer2TextBox.TabIndex = 10038;
            this.Answer2TextBox.UseSelectable = true;
            this.Answer2TextBox.Visible = false;
            this.Answer2TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Answer2TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Answer3TextBox
            // 
            // 
            // 
            // 
            this.Answer3TextBox.CustomButton.Image = null;
            this.Answer3TextBox.CustomButton.Location = new System.Drawing.Point(597, 1);
            this.Answer3TextBox.CustomButton.Name = "";
            this.Answer3TextBox.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.Answer3TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Answer3TextBox.CustomButton.TabIndex = 1;
            this.Answer3TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer3TextBox.CustomButton.UseSelectable = true;
            this.Answer3TextBox.CustomButton.Visible = false;
            this.Answer3TextBox.Lines = new string[0];
            this.Answer3TextBox.Location = new System.Drawing.Point(59, 371);
            this.Answer3TextBox.MaxLength = 32767;
            this.Answer3TextBox.Multiline = true;
            this.Answer3TextBox.Name = "Answer3TextBox";
            this.Answer3TextBox.PasswordChar = '\0';
            this.Answer3TextBox.ReadOnly = true;
            this.Answer3TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Answer3TextBox.SelectedText = "";
            this.Answer3TextBox.SelectionLength = 0;
            this.Answer3TextBox.SelectionStart = 0;
            this.Answer3TextBox.ShortcutsEnabled = true;
            this.Answer3TextBox.Size = new System.Drawing.Size(647, 51);
            this.Answer3TextBox.TabIndex = 10039;
            this.Answer3TextBox.UseSelectable = true;
            this.Answer3TextBox.Visible = false;
            this.Answer3TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Answer3TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Answer4TextBox
            // 
            // 
            // 
            // 
            this.Answer4TextBox.CustomButton.Image = null;
            this.Answer4TextBox.CustomButton.Location = new System.Drawing.Point(597, 1);
            this.Answer4TextBox.CustomButton.Name = "";
            this.Answer4TextBox.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.Answer4TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Answer4TextBox.CustomButton.TabIndex = 1;
            this.Answer4TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Answer4TextBox.CustomButton.UseSelectable = true;
            this.Answer4TextBox.CustomButton.Visible = false;
            this.Answer4TextBox.Lines = new string[0];
            this.Answer4TextBox.Location = new System.Drawing.Point(59, 428);
            this.Answer4TextBox.MaxLength = 32767;
            this.Answer4TextBox.Multiline = true;
            this.Answer4TextBox.Name = "Answer4TextBox";
            this.Answer4TextBox.PasswordChar = '\0';
            this.Answer4TextBox.ReadOnly = true;
            this.Answer4TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Answer4TextBox.SelectedText = "";
            this.Answer4TextBox.SelectionLength = 0;
            this.Answer4TextBox.SelectionStart = 0;
            this.Answer4TextBox.ShortcutsEnabled = true;
            this.Answer4TextBox.Size = new System.Drawing.Size(647, 51);
            this.Answer4TextBox.TabIndex = 10040;
            this.Answer4TextBox.UseSelectable = true;
            this.Answer4TextBox.Visible = false;
            this.Answer4TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Answer4TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LearnQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 573);
            this.Controls.Add(this.Answer4TextBox);
            this.Controls.Add(this.Answer3TextBox);
            this.Controls.Add(this.Answer2TextBox);
            this.Controls.Add(this.Answer1TextBox);
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
        private MetroFramework.Controls.MetroTextBox Answer1TextBox;
        private MetroFramework.Controls.MetroTextBox Answer2TextBox;
        private MetroFramework.Controls.MetroTextBox Answer3TextBox;
        private MetroFramework.Controls.MetroTextBox Answer4TextBox;
    }
}