namespace ExamSystem
{
    partial class DelCourse
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
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.UpdButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(102, 40);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(184, 21);
            this.CourseComboBox.TabIndex = 0;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(65, 43);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(31, 13);
            this.CourseLabel.TabIndex = 1;
            this.CourseLabel.Text = "Курс";
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Location = new System.Drawing.Point(102, 67);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(184, 20);
            this.CourseTextBox.TabIndex = 2;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(65, 70);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(37, 13);
            this.TextLabel.TabIndex = 3;
            this.TextLabel.Text = "Текст";
            // 
            // UpdButton
            // 
            this.UpdButton.Location = new System.Drawing.Point(68, 106);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(102, 58);
            this.UpdButton.TabIndex = 4;
            this.UpdButton.Text = "Изменить";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(186, 106);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(100, 58);
            this.DelButton.TabIndex = 5;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DelCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 206);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.CourseComboBox);
            this.Name = "DelCourse";
            this.Text = "Изменение курсов";
            this.Load += new System.EventHandler(this.DelCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Button DelButton;
    }
}