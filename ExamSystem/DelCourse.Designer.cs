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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelCourse));
            this.CourseLabel = new MetroFramework.Controls.MetroLabel();
            this.TextLabel = new MetroFramework.Controls.MetroLabel();
            this.CourseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.CourseTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UpdButton = new MetroFramework.Controls.MetroButton();
            this.DelButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(84, 63);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(36, 19);
            this.CourseLabel.TabIndex = 6;
            this.CourseLabel.Text = "Курс";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(18, 98);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(102, 19);
            this.TextLabel.TabIndex = 7;
            this.TextLabel.Text = "Наименование";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.DropDownWidth = 500;
            this.CourseComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.ItemHeight = 19;
            this.CourseComboBox.Location = new System.Drawing.Point(126, 63);
            this.CourseComboBox.MaxDropDownItems = 12;
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(400, 25);
            this.CourseComboBox.TabIndex = 8;
            this.CourseComboBox.UseSelectable = true;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // CourseTextBox
            // 
            // 
            // 
            // 
            this.CourseTextBox.CustomButton.Image = null;
            this.CourseTextBox.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.CourseTextBox.CustomButton.Name = "";
            this.CourseTextBox.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.CourseTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CourseTextBox.CustomButton.TabIndex = 1;
            this.CourseTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CourseTextBox.CustomButton.UseSelectable = true;
            this.CourseTextBox.CustomButton.Visible = false;
            this.CourseTextBox.Lines = new string[0];
            this.CourseTextBox.Location = new System.Drawing.Point(126, 98);
            this.CourseTextBox.MaxLength = 32767;
            this.CourseTextBox.Multiline = true;
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.PasswordChar = '\0';
            this.CourseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CourseTextBox.SelectedText = "";
            this.CourseTextBox.SelectionLength = 0;
            this.CourseTextBox.SelectionStart = 0;
            this.CourseTextBox.ShortcutsEnabled = true;
            this.CourseTextBox.Size = new System.Drawing.Size(400, 65);
            this.CourseTextBox.TabIndex = 9;
            this.CourseTextBox.UseSelectable = true;
            this.CourseTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CourseTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UpdButton
            // 
            this.UpdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdButton.Location = new System.Drawing.Point(296, 169);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(112, 61);
            this.UpdButton.TabIndex = 10;
            this.UpdButton.Text = "Изменить";
            this.UpdButton.UseSelectable = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.Location = new System.Drawing.Point(414, 169);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(112, 61);
            this.DelButton.TabIndex = 11;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseSelectable = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DelCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 249);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.CourseLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DelCourse";
            this.Resizable = false;
            this.Text = "Изменение курсов";
            this.Load += new System.EventHandler(this.DelCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel CourseLabel;
        private MetroFramework.Controls.MetroLabel TextLabel;
        private MetroFramework.Controls.MetroComboBox CourseComboBox;
        private MetroFramework.Controls.MetroTextBox CourseTextBox;
        private MetroFramework.Controls.MetroButton UpdButton;
        private MetroFramework.Controls.MetroButton DelButton;
    }
}