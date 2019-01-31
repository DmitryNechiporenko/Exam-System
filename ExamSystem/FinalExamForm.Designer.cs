namespace ExamSystem
{
    partial class FinalExamForm
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.goBackButton = new MetroFramework.Controls.MetroButton();
            this.GoToLearnButton = new MetroFramework.Controls.MetroButton();
            this.ReportButton = new MetroFramework.Controls.MetroButton();
            this.RefreshExamButton = new MetroFramework.Controls.MetroButton();
            this.ResultLabel = new MetroFramework.Controls.MetroLabel();
            this.CreateExamButton = new MetroFramework.Controls.MetroButton();
            this.ExamLabel = new MetroFramework.Controls.MetroLabel();
            this.CourseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.CourseLabel = new MetroFramework.Controls.MetroLabel();
            this.UserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.StartExamButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 364);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 10055;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            // 
            // goBackButton
            // 
            this.goBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackButton.Location = new System.Drawing.Point(202, 28);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(37, 21);
            this.goBackButton.Style = MetroFramework.MetroColorStyle.White;
            this.goBackButton.TabIndex = 10054;
            this.goBackButton.Text = "<<";
            this.goBackButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.goBackButton.UseCustomBackColor = true;
            this.goBackButton.UseSelectable = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // GoToLearnButton
            // 
            this.GoToLearnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToLearnButton.Location = new System.Drawing.Point(188, 280);
            this.GoToLearnButton.Name = "GoToLearnButton";
            this.GoToLearnButton.Size = new System.Drawing.Size(133, 49);
            this.GoToLearnButton.TabIndex = 10053;
            this.GoToLearnButton.Text = "Пройти обучение";
            this.GoToLearnButton.UseSelectable = true;
            this.GoToLearnButton.Click += new System.EventHandler(this.GoToLearnButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportButton.Location = new System.Drawing.Point(250, 280);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(133, 49);
            this.ReportButton.TabIndex = 10051;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.UseSelectable = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // RefreshExamButton
            // 
            this.RefreshExamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshExamButton.Location = new System.Drawing.Point(49, 280);
            this.RefreshExamButton.Name = "RefreshExamButton";
            this.RefreshExamButton.Size = new System.Drawing.Size(133, 49);
            this.RefreshExamButton.TabIndex = 10050;
            this.RefreshExamButton.Text = "Начать заново";
            this.RefreshExamButton.UseSelectable = true;
            this.RefreshExamButton.Click += new System.EventHandler(this.RefreshExamButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ResultLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ResultLabel.Location = new System.Drawing.Point(49, 232);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(98, 25);
            this.ResultLabel.TabIndex = 10049;
            this.ResultLabel.Text = "Результат: ";
            // 
            // CreateExamButton
            // 
            this.CreateExamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateExamButton.Location = new System.Drawing.Point(153, 177);
            this.CreateExamButton.Name = "CreateExamButton";
            this.CreateExamButton.Size = new System.Drawing.Size(107, 28);
            this.CreateExamButton.TabIndex = 10048;
            this.CreateExamButton.Text = "Создать";
            this.CreateExamButton.UseSelectable = true;
            this.CreateExamButton.Click += new System.EventHandler(this.CreateExamButton_Click);
            // 
            // ExamLabel
            // 
            this.ExamLabel.AutoSize = true;
            this.ExamLabel.Location = new System.Drawing.Point(136, 145);
            this.ExamLabel.Name = "ExamLabel";
            this.ExamLabel.Size = new System.Drawing.Size(144, 19);
            this.ExamLabel.TabIndex = 10047;
            this.ExamLabel.Text = "Экзамена не найдено";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.ItemHeight = 19;
            this.CourseComboBox.Location = new System.Drawing.Point(25, 117);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(400, 25);
            this.CourseComboBox.TabIndex = 10040;
            this.CourseComboBox.UseSelectable = true;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(25, 95);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(99, 19);
            this.CourseLabel.TabIndex = 10038;
            this.CourseLabel.Text = "Выберите курс";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.UserNameLabel.Location = new System.Drawing.Point(25, 58);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(33, 15);
            this.UserNameLabel.TabIndex = 10037;
            this.UserNameLabel.Text = "ФИО";
            // 
            // StartExamButton
            // 
            this.StartExamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartExamButton.Location = new System.Drawing.Point(107, 167);
            this.StartExamButton.Name = "StartExamButton";
            this.StartExamButton.Size = new System.Drawing.Size(214, 62);
            this.StartExamButton.TabIndex = 10042;
            this.StartExamButton.Text = "Пройти";
            this.StartExamButton.UseSelectable = true;
            this.StartExamButton.Click += new System.EventHandler(this.StartExamButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamSystem.Properties.Resources.civssm;
            this.pictureBox1.Location = new System.Drawing.Point(350, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10052;
            this.pictureBox1.TabStop = false;
            // 
            // FinalExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 412);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.GoToLearnButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.RefreshExamButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CreateExamButton);
            this.Controls.Add(this.ExamLabel);
            this.Controls.Add(this.StartExamButton);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.UserNameLabel);
            this.MaximizeBox = false;
            this.Name = "FinalExamForm";
            this.Resizable = false;
            this.Text = "Выбор экзамена";
            this.Load += new System.EventHandler(this.FinalExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton goBackButton;
        private MetroFramework.Controls.MetroButton GoToLearnButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton ReportButton;
        private MetroFramework.Controls.MetroButton RefreshExamButton;
        private MetroFramework.Controls.MetroLabel ResultLabel;
        private MetroFramework.Controls.MetroButton CreateExamButton;
        private MetroFramework.Controls.MetroLabel ExamLabel;
        private MetroFramework.Controls.MetroComboBox CourseComboBox;
        private MetroFramework.Controls.MetroLabel CourseLabel;
        private MetroFramework.Controls.MetroLabel UserNameLabel;
        private MetroFramework.Controls.MetroButton StartExamButton;
    }
}