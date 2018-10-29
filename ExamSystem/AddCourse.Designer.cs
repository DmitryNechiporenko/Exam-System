namespace ExamSystem
{
    partial class AddCourse
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
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Location = new System.Drawing.Point(100, 31);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(187, 20);
            this.CourseTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(66, 75);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(221, 52);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(63, 34);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(31, 13);
            this.CourseLabel.TabIndex = 2;
            this.CourseLabel.Text = "Курс";
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 155);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CourseTextBox);
            this.Name = "AddCourse";
            this.Text = "Добавление курса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CourseLabel;
    }
}