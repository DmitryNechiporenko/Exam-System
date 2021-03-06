﻿namespace ExamSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBlock));
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
            this.CourseLabel.Location = new System.Drawing.Point(23, 85);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(36, 19);
            this.CourseLabel.TabIndex = 5;
            this.CourseLabel.Text = "Курс";
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(21, 115);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(38, 19);
            this.BlockLabel.TabIndex = 6;
            this.BlockLabel.Text = "Блок";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.ItemHeight = 19;
            this.CourseComboBox.Location = new System.Drawing.Point(76, 80);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(400, 25);
            this.CourseComboBox.TabIndex = 7;
            this.CourseComboBox.UseSelectable = true;
            // 
            // BlockTextBox
            // 
            // 
            // 
            // 
            this.BlockTextBox.CustomButton.Image = null;
            this.BlockTextBox.CustomButton.Location = new System.Drawing.Point(302, 2);
            this.BlockTextBox.CustomButton.Name = "";
            this.BlockTextBox.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.BlockTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BlockTextBox.CustomButton.TabIndex = 1;
            this.BlockTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BlockTextBox.CustomButton.UseSelectable = true;
            this.BlockTextBox.CustomButton.Visible = false;
            this.BlockTextBox.Lines = new string[0];
            this.BlockTextBox.Location = new System.Drawing.Point(76, 115);
            this.BlockTextBox.MaxLength = 32767;
            this.BlockTextBox.Multiline = true;
            this.BlockTextBox.Name = "BlockTextBox";
            this.BlockTextBox.PasswordChar = '\0';
            this.BlockTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BlockTextBox.SelectedText = "";
            this.BlockTextBox.SelectionLength = 0;
            this.BlockTextBox.SelectionStart = 0;
            this.BlockTextBox.ShortcutsEnabled = true;
            this.BlockTextBox.Size = new System.Drawing.Size(400, 100);
            this.BlockTextBox.TabIndex = 8;
            this.BlockTextBox.UseSelectable = true;
            this.BlockTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BlockTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Location = new System.Drawing.Point(76, 233);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(400, 53);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 311);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BlockTextBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.CourseLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddBlock";
            this.Resizable = false;
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