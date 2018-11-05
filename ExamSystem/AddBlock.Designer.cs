namespace ExamSystem
{
    partial class AddBlock
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
            this.CourseLabel = new MetroFramework.Controls.MetroLabel();
            this.BlockLabel = new MetroFramework.Controls.MetroLabel();
            this.CourseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BlockTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(23, 78);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(36, 19);
            this.CourseLabel.TabIndex = 5;
            this.CourseLabel.Text = "Курс";
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(21, 108);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(38, 19);
            this.BlockLabel.TabIndex = 6;
            this.BlockLabel.Text = "Блок";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.ItemHeight = 23;
            this.CourseComboBox.Location = new System.Drawing.Point(76, 73);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(167, 29);
            this.CourseComboBox.TabIndex = 7;
            this.CourseComboBox.UseSelectable = true;
            // 
            // BlockTextBox
            // 
            // 
            // 
            // 
            this.BlockTextBox.CustomButton.Image = null;
            this.BlockTextBox.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.BlockTextBox.CustomButton.Name = "";
            this.BlockTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BlockTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BlockTextBox.CustomButton.TabIndex = 1;
            this.BlockTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BlockTextBox.CustomButton.UseSelectable = true;
            this.BlockTextBox.CustomButton.Visible = false;
            this.BlockTextBox.Lines = new string[0];
            this.BlockTextBox.Location = new System.Drawing.Point(76, 108);
            this.BlockTextBox.MaxLength = 32767;
            this.BlockTextBox.Name = "BlockTextBox";
            this.BlockTextBox.PasswordChar = '\0';
            this.BlockTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BlockTextBox.SelectedText = "";
            this.BlockTextBox.SelectionLength = 0;
            this.BlockTextBox.SelectionStart = 0;
            this.BlockTextBox.ShortcutsEnabled = true;
            this.BlockTextBox.Size = new System.Drawing.Size(167, 23);
            this.BlockTextBox.TabIndex = 8;
            this.BlockTextBox.UseSelectable = true;
            this.BlockTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BlockTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 148);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(222, 53);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 228);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BlockTextBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.CourseLabel);
            this.Name = "AddBlock";
            this.Text = "Добавление блока";
            this.Load += new System.EventHandler(this.AddBlock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel CourseLabel;
        private MetroFramework.Controls.MetroLabel BlockLabel;
        private MetroFramework.Controls.MetroComboBox CourseComboBox;
        private MetroFramework.Controls.MetroTextBox BlockTextBox;
        private MetroFramework.Controls.MetroButton AddButton;
    }
}