namespace ExamSystem
{
    partial class ExamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamsForm));
            this.UserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.CourseLabel = new MetroFramework.Controls.MetroLabel();
            this.BlockLabel = new MetroFramework.Controls.MetroLabel();
            this.CourseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BlockComboBox = new MetroFramework.Controls.MetroComboBox();
            this.part1Button = new MetroFramework.Controls.MetroButton();
            this.part5Button = new MetroFramework.Controls.MetroButton();
            this.part4Button = new MetroFramework.Controls.MetroButton();
            this.part3Button = new MetroFramework.Controls.MetroButton();
            this.part2Button = new MetroFramework.Controls.MetroButton();
            this.ExamLabel = new MetroFramework.Controls.MetroLabel();
            this.CreateExamButton = new MetroFramework.Controls.MetroButton();
            this.ResultLabel = new MetroFramework.Controls.MetroLabel();
            this.RefreshExamButton = new MetroFramework.Controls.MetroButton();
            this.ReportButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GoToLearnButton = new MetroFramework.Controls.MetroButton();
            this.goBackButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.UserNameLabel.Location = new System.Drawing.Point(23, 60);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(33, 15);
            this.UserNameLabel.TabIndex = 10018;
            this.UserNameLabel.Text = "ФИО";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(23, 97);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(99, 19);
            this.CourseLabel.TabIndex = 10019;
            this.CourseLabel.Text = "Выберите курс";
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(23, 187);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(102, 19);
            this.BlockLabel.TabIndex = 10020;
            this.BlockLabel.Text = "Выберите блок";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.ItemHeight = 23;
            this.CourseComboBox.Location = new System.Drawing.Point(23, 119);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(271, 29);
            this.CourseComboBox.TabIndex = 10021;
            this.CourseComboBox.UseSelectable = true;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // BlockComboBox
            // 
            this.BlockComboBox.FormattingEnabled = true;
            this.BlockComboBox.ItemHeight = 23;
            this.BlockComboBox.Location = new System.Drawing.Point(23, 209);
            this.BlockComboBox.Name = "BlockComboBox";
            this.BlockComboBox.Size = new System.Drawing.Size(271, 29);
            this.BlockComboBox.TabIndex = 10022;
            this.BlockComboBox.UseSelectable = true;
            this.BlockComboBox.SelectedValueChanged += new System.EventHandler(this.BlockComboBox_SelectedValueChanged);
            // 
            // part1Button
            // 
            this.part1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part1Button.Location = new System.Drawing.Point(331, 143);
            this.part1Button.Name = "part1Button";
            this.part1Button.Size = new System.Drawing.Size(62, 62);
            this.part1Button.TabIndex = 10023;
            this.part1Button.Text = "1 \r\nЧасть";
            this.part1Button.UseSelectable = true;
            this.part1Button.Click += new System.EventHandler(this.part1Button_Click);
            // 
            // part5Button
            // 
            this.part5Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part5Button.Location = new System.Drawing.Point(603, 144);
            this.part5Button.Name = "part5Button";
            this.part5Button.Size = new System.Drawing.Size(62, 62);
            this.part5Button.TabIndex = 10024;
            this.part5Button.Text = "5 \r\nЧасть";
            this.part5Button.UseSelectable = true;
            this.part5Button.Click += new System.EventHandler(this.part5Button_Click);
            // 
            // part4Button
            // 
            this.part4Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part4Button.Location = new System.Drawing.Point(535, 143);
            this.part4Button.Name = "part4Button";
            this.part4Button.Size = new System.Drawing.Size(62, 62);
            this.part4Button.TabIndex = 10025;
            this.part4Button.Text = "4 \r\nЧасть";
            this.part4Button.UseSelectable = true;
            this.part4Button.Click += new System.EventHandler(this.part4Button_Click);
            // 
            // part3Button
            // 
            this.part3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part3Button.Location = new System.Drawing.Point(467, 143);
            this.part3Button.Name = "part3Button";
            this.part3Button.Size = new System.Drawing.Size(62, 62);
            this.part3Button.TabIndex = 10026;
            this.part3Button.Text = "3 \r\nЧасть";
            this.part3Button.UseSelectable = true;
            this.part3Button.Click += new System.EventHandler(this.part3Button_Click);
            // 
            // part2Button
            // 
            this.part2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part2Button.Location = new System.Drawing.Point(399, 143);
            this.part2Button.Name = "part2Button";
            this.part2Button.Size = new System.Drawing.Size(62, 62);
            this.part2Button.TabIndex = 10027;
            this.part2Button.Text = "2 \r\nЧасть";
            this.part2Button.UseSelectable = true;
            this.part2Button.Click += new System.EventHandler(this.part2Button_Click);
            // 
            // ExamLabel
            // 
            this.ExamLabel.AutoSize = true;
            this.ExamLabel.Location = new System.Drawing.Point(418, 126);
            this.ExamLabel.Name = "ExamLabel";
            this.ExamLabel.Size = new System.Drawing.Size(144, 19);
            this.ExamLabel.TabIndex = 10028;
            this.ExamLabel.Text = "Экзамена не найдено";
            // 
            // CreateExamButton
            // 
            this.CreateExamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateExamButton.Location = new System.Drawing.Point(435, 158);
            this.CreateExamButton.Name = "CreateExamButton";
            this.CreateExamButton.Size = new System.Drawing.Size(107, 28);
            this.CreateExamButton.TabIndex = 10029;
            this.CreateExamButton.Text = "Создать";
            this.CreateExamButton.UseSelectable = true;
            this.CreateExamButton.Click += new System.EventHandler(this.CreateExamButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ResultLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ResultLabel.Location = new System.Drawing.Point(331, 213);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(98, 25);
            this.ResultLabel.TabIndex = 10030;
            this.ResultLabel.Text = "Результат: ";
            // 
            // RefreshExamButton
            // 
            this.RefreshExamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshExamButton.Location = new System.Drawing.Point(331, 261);
            this.RefreshExamButton.Name = "RefreshExamButton";
            this.RefreshExamButton.Size = new System.Drawing.Size(133, 49);
            this.RefreshExamButton.TabIndex = 10031;
            this.RefreshExamButton.Text = "Начать заново";
            this.RefreshExamButton.UseSelectable = true;
            this.RefreshExamButton.Click += new System.EventHandler(this.RefreshExamButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportButton.Location = new System.Drawing.Point(532, 261);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(133, 49);
            this.ReportButton.TabIndex = 10032;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.UseSelectable = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamSystem.Properties.Resources.civssm;
            this.pictureBox1.Location = new System.Drawing.Point(606, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10033;
            this.pictureBox1.TabStop = false;
            // 
            // GoToLearnButton
            // 
            this.GoToLearnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToLearnButton.Location = new System.Drawing.Point(470, 261);
            this.GoToLearnButton.Name = "GoToLearnButton";
            this.GoToLearnButton.Size = new System.Drawing.Size(133, 49);
            this.GoToLearnButton.TabIndex = 10034;
            this.GoToLearnButton.Text = "Пройти обучение";
            this.GoToLearnButton.UseSelectable = true;
            this.GoToLearnButton.Click += new System.EventHandler(this.GoToLearnButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackButton.Location = new System.Drawing.Point(200, 30);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(37, 21);
            this.goBackButton.Style = MetroFramework.MetroColorStyle.White;
            this.goBackButton.TabIndex = 10035;
            this.goBackButton.Text = "<<";
            this.goBackButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.goBackButton.UseCustomBackColor = true;
            this.goBackButton.UseSelectable = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // ExamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 354);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.GoToLearnButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.RefreshExamButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CreateExamButton);
            this.Controls.Add(this.ExamLabel);
            this.Controls.Add(this.part2Button);
            this.Controls.Add(this.part3Button);
            this.Controls.Add(this.part4Button);
            this.Controls.Add(this.part5Button);
            this.Controls.Add(this.part1Button);
            this.Controls.Add(this.BlockComboBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExamsForm";
            this.Resizable = false;
            this.Text = "Выбор экзамена";
            this.Load += new System.EventHandler(this.ExamsFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel UserNameLabel;
        private MetroFramework.Controls.MetroLabel CourseLabel;
        private MetroFramework.Controls.MetroLabel BlockLabel;
        private MetroFramework.Controls.MetroComboBox CourseComboBox;
        private MetroFramework.Controls.MetroComboBox BlockComboBox;
        private MetroFramework.Controls.MetroButton part1Button;
        private MetroFramework.Controls.MetroButton part5Button;
        private MetroFramework.Controls.MetroButton part4Button;
        private MetroFramework.Controls.MetroButton part3Button;
        private MetroFramework.Controls.MetroButton part2Button;
        private MetroFramework.Controls.MetroLabel ExamLabel;
        private MetroFramework.Controls.MetroButton CreateExamButton;
        private MetroFramework.Controls.MetroLabel ResultLabel;
        private MetroFramework.Controls.MetroButton RefreshExamButton;
        private MetroFramework.Controls.MetroButton ReportButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton GoToLearnButton;
        private MetroFramework.Controls.MetroButton goBackButton;
    }
}