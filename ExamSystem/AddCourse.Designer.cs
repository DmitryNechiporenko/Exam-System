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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.CourseLabel = new MetroFramework.Controls.MetroLabel();
            this.CourseTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(23, 80);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(36, 19);
            this.CourseLabel.TabIndex = 3;
            this.CourseLabel.Text = "Курс";
            // 
            // CourseTextBox
            // 
            // 
            // 
            // 
            this.CourseTextBox.CustomButton.Image = null;
            this.CourseTextBox.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.CourseTextBox.CustomButton.Name = "";
            this.CourseTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CourseTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CourseTextBox.CustomButton.TabIndex = 1;
            this.CourseTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CourseTextBox.CustomButton.UseSelectable = true;
            this.CourseTextBox.CustomButton.Visible = false;
            this.CourseTextBox.Lines = new string[0];
            this.CourseTextBox.Location = new System.Drawing.Point(65, 80);
            this.CourseTextBox.MaxLength = 32767;
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.PasswordChar = '\0';
            this.CourseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CourseTextBox.SelectedText = "";
            this.CourseTextBox.SelectionLength = 0;
            this.CourseTextBox.SelectionStart = 0;
            this.CourseTextBox.ShortcutsEnabled = true;
            this.CourseTextBox.Size = new System.Drawing.Size(179, 23);
            this.CourseTextBox.TabIndex = 4;
            this.CourseTextBox.UseSelectable = true;
            this.CourseTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CourseTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(23, 128);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(221, 52);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 211);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.CourseLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCourse";
            this.Text = "Добавление курса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel CourseLabel;
        private MetroFramework.Controls.MetroTextBox CourseTextBox;
        private MetroFramework.Controls.MetroButton AddButton;
    }
}