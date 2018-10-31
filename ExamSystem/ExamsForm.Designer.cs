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
            this.BlockComboBox = new System.Windows.Forms.ComboBox();
            this.ExamLabel = new System.Windows.Forms.Label();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.CreateExamButton = new System.Windows.Forms.Button();
            this.part1Button = new System.Windows.Forms.Button();
            this.part2Button = new System.Windows.Forms.Button();
            this.part3Button = new System.Windows.Forms.Button();
            this.part4Button = new System.Windows.Forms.Button();
            this.part5Button = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlockComboBox
            // 
            this.BlockComboBox.FormattingEnabled = true;
            this.BlockComboBox.Location = new System.Drawing.Point(9, 129);
            this.BlockComboBox.Name = "BlockComboBox";
            this.BlockComboBox.Size = new System.Drawing.Size(271, 21);
            this.BlockComboBox.TabIndex = 10008;
            this.BlockComboBox.SelectedValueChanged += new System.EventHandler(this.BlockComboBox_SelectedValueChanged);
            // 
            // ExamLabel
            // 
            this.ExamLabel.AutoSize = true;
            this.ExamLabel.Location = new System.Drawing.Point(414, 86);
            this.ExamLabel.Name = "ExamLabel";
            this.ExamLabel.Size = new System.Drawing.Size(118, 13);
            this.ExamLabel.TabIndex = 10007;
            this.ExamLabel.Text = "Экзамена не найдено";
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(8, 113);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(84, 13);
            this.BlockLabel.TabIndex = 10006;
            this.BlockLabel.Text = "Выберите блок";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(9, 46);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(83, 13);
            this.CourseLabel.TabIndex = 10004;
            this.CourseLabel.Text = "Выберите курс";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(9, 15);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(38, 17);
            this.UserNameLabel.TabIndex = 10005;
            this.UserNameLabel.Text = "ФИО";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(12, 62);
            this.CourseComboBox.MaxDropDownItems = 100;
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(268, 21);
            this.CourseComboBox.TabIndex = 10003;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // CreateExamButton
            // 
            this.CreateExamButton.Location = new System.Drawing.Point(417, 102);
            this.CreateExamButton.Name = "CreateExamButton";
            this.CreateExamButton.Size = new System.Drawing.Size(115, 24);
            this.CreateExamButton.TabIndex = 10009;
            this.CreateExamButton.Text = "Создать";
            this.CreateExamButton.UseVisualStyleBackColor = true;
            this.CreateExamButton.Visible = false;
            this.CreateExamButton.Click += new System.EventHandler(this.CreateExamButton_Click);
            // 
            // part1Button
            // 
            this.part1Button.Location = new System.Drawing.Point(334, 141);
            this.part1Button.Name = "part1Button";
            this.part1Button.Size = new System.Drawing.Size(51, 45);
            this.part1Button.TabIndex = 10010;
            this.part1Button.Text = "1 часть";
            this.part1Button.UseVisualStyleBackColor = true;
            this.part1Button.Visible = false;
            this.part1Button.Click += new System.EventHandler(this.part1Button_Click);
            // 
            // part2Button
            // 
            this.part2Button.Location = new System.Drawing.Point(391, 141);
            this.part2Button.Name = "part2Button";
            this.part2Button.Size = new System.Drawing.Size(51, 45);
            this.part2Button.TabIndex = 10011;
            this.part2Button.Text = "2 часть";
            this.part2Button.UseVisualStyleBackColor = true;
            this.part2Button.Visible = false;
            this.part2Button.Click += new System.EventHandler(this.part2Button_Click);
            // 
            // part3Button
            // 
            this.part3Button.Location = new System.Drawing.Point(448, 141);
            this.part3Button.Name = "part3Button";
            this.part3Button.Size = new System.Drawing.Size(51, 45);
            this.part3Button.TabIndex = 10012;
            this.part3Button.Text = "3 часть";
            this.part3Button.UseVisualStyleBackColor = true;
            this.part3Button.Visible = false;
            this.part3Button.Click += new System.EventHandler(this.part3Button_Click);
            // 
            // part4Button
            // 
            this.part4Button.Location = new System.Drawing.Point(505, 141);
            this.part4Button.Name = "part4Button";
            this.part4Button.Size = new System.Drawing.Size(51, 45);
            this.part4Button.TabIndex = 10013;
            this.part4Button.Text = "4 часть";
            this.part4Button.UseVisualStyleBackColor = true;
            this.part4Button.Visible = false;
            this.part4Button.Click += new System.EventHandler(this.part4Button_Click);
            // 
            // part5Button
            // 
            this.part5Button.Location = new System.Drawing.Point(562, 141);
            this.part5Button.Name = "part5Button";
            this.part5Button.Size = new System.Drawing.Size(51, 45);
            this.part5Button.TabIndex = 10014;
            this.part5Button.Text = "5 часть";
            this.part5Button.UseVisualStyleBackColor = true;
            this.part5Button.Visible = false;
            this.part5Button.Click += new System.EventHandler(this.part5Button_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(619, 141);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(51, 45);
            this.ReportButton.TabIndex = 10015;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // ExamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 281);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.part5Button);
            this.Controls.Add(this.part4Button);
            this.Controls.Add(this.part3Button);
            this.Controls.Add(this.part2Button);
            this.Controls.Add(this.part1Button);
            this.Controls.Add(this.CreateExamButton);
            this.Controls.Add(this.BlockComboBox);
            this.Controls.Add(this.ExamLabel);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.CourseComboBox);
            this.Name = "ExamsForm";
            this.Text = "Выбор экзамена";
            this.Load += new System.EventHandler(this.ExamsFormcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BlockComboBox;
        private System.Windows.Forms.Label ExamLabel;
        private System.Windows.Forms.Label BlockLabel;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Button CreateExamButton;
        private System.Windows.Forms.Button part1Button;
        private System.Windows.Forms.Button part2Button;
        private System.Windows.Forms.Button part3Button;
        private System.Windows.Forms.Button part4Button;
        private System.Windows.Forms.Button part5Button;
        private System.Windows.Forms.Button ReportButton;
    }
}