﻿namespace ExamSystem
{
    partial class AddQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestion));
            this.CourseLabel = new MetroFramework.Controls.MetroLabel();
            this.BlockLabel = new MetroFramework.Controls.MetroLabel();
            this.QuestionLabel = new MetroFramework.Controls.MetroLabel();
            this.a1Label = new MetroFramework.Controls.MetroLabel();
            this.a2Label = new MetroFramework.Controls.MetroLabel();
            this.a3Label = new MetroFramework.Controls.MetroLabel();
            this.a4Label = new MetroFramework.Controls.MetroLabel();
            this.commentLabel = new MetroFramework.Controls.MetroLabel();
            this.CourseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BlockComboBox = new MetroFramework.Controls.MetroComboBox();
            this.QuestionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.A1TextBox = new MetroFramework.Controls.MetroTextBox();
            this.A2TextBox = new MetroFramework.Controls.MetroTextBox();
            this.A3TextBox = new MetroFramework.Controls.MetroTextBox();
            this.A4TextBox = new MetroFramework.Controls.MetroTextBox();
            this.A1Radio = new MetroFramework.Controls.MetroRadioButton();
            this.A2Radio = new MetroFramework.Controls.MetroRadioButton();
            this.A3Radio = new MetroFramework.Controls.MetroRadioButton();
            this.A4Radio = new MetroFramework.Controls.MetroRadioButton();
            this.commentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(67, 66);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(36, 19);
            this.CourseLabel.TabIndex = 21;
            this.CourseLabel.Text = "Курс";
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(65, 101);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(38, 19);
            this.BlockLabel.TabIndex = 22;
            this.BlockLabel.Text = "Блок";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(48, 135);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(55, 19);
            this.QuestionLabel.TabIndex = 23;
            this.QuestionLabel.Text = "Вопрос";
            // 
            // a1Label
            // 
            this.a1Label.AutoSize = true;
            this.a1Label.Location = new System.Drawing.Point(50, 300);
            this.a1Label.Name = "a1Label";
            this.a1Label.Size = new System.Drawing.Size(53, 19);
            this.a1Label.TabIndex = 24;
            this.a1Label.Text = "Ответ 1";
            // 
            // a2Label
            // 
            this.a2Label.AutoSize = true;
            this.a2Label.Location = new System.Drawing.Point(48, 371);
            this.a2Label.Name = "a2Label";
            this.a2Label.Size = new System.Drawing.Size(55, 19);
            this.a2Label.TabIndex = 25;
            this.a2Label.Text = "Ответ 2";
            // 
            // a3Label
            // 
            this.a3Label.AutoSize = true;
            this.a3Label.Location = new System.Drawing.Point(48, 441);
            this.a3Label.Name = "a3Label";
            this.a3Label.Size = new System.Drawing.Size(55, 19);
            this.a3Label.TabIndex = 26;
            this.a3Label.Text = "Ответ 3";
            // 
            // a4Label
            // 
            this.a4Label.AutoSize = true;
            this.a4Label.Location = new System.Drawing.Point(48, 511);
            this.a4Label.Name = "a4Label";
            this.a4Label.Size = new System.Drawing.Size(55, 19);
            this.a4Label.TabIndex = 27;
            this.a4Label.Text = "Ответ 4";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(10, 581);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(93, 19);
            this.commentLabel.TabIndex = 28;
            this.commentLabel.Text = "Комментарий";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.ItemHeight = 19;
            this.CourseComboBox.Location = new System.Drawing.Point(109, 66);
            this.CourseComboBox.MaxDropDownItems = 10;
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(400, 25);
            this.CourseComboBox.TabIndex = 29;
            this.CourseComboBox.UseSelectable = true;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // BlockComboBox
            // 
            this.BlockComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.BlockComboBox.FormattingEnabled = true;
            this.BlockComboBox.IntegralHeight = false;
            this.BlockComboBox.ItemHeight = 19;
            this.BlockComboBox.Location = new System.Drawing.Point(109, 101);
            this.BlockComboBox.MaxDropDownItems = 10;
            this.BlockComboBox.Name = "BlockComboBox";
            this.BlockComboBox.Size = new System.Drawing.Size(400, 25);
            this.BlockComboBox.TabIndex = 30;
            this.BlockComboBox.UseSelectable = true;
            // 
            // QuestionTextBox
            // 
            // 
            // 
            // 
            this.QuestionTextBox.CustomButton.Image = null;
            this.QuestionTextBox.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.QuestionTextBox.CustomButton.Name = "";
            this.QuestionTextBox.CustomButton.Size = new System.Drawing.Size(157, 157);
            this.QuestionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuestionTextBox.CustomButton.TabIndex = 1;
            this.QuestionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuestionTextBox.CustomButton.UseSelectable = true;
            this.QuestionTextBox.CustomButton.Visible = false;
            this.QuestionTextBox.Lines = new string[0];
            this.QuestionTextBox.Location = new System.Drawing.Point(109, 136);
            this.QuestionTextBox.MaxLength = 32767;
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.PasswordChar = '\0';
            this.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QuestionTextBox.SelectedText = "";
            this.QuestionTextBox.SelectionLength = 0;
            this.QuestionTextBox.SelectionStart = 0;
            this.QuestionTextBox.ShortcutsEnabled = true;
            this.QuestionTextBox.ShowClearButton = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(400, 159);
            this.QuestionTextBox.TabIndex = 31;
            this.QuestionTextBox.UseSelectable = true;
            this.QuestionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuestionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // A1TextBox
            // 
            // 
            // 
            // 
            this.A1TextBox.CustomButton.Image = null;
            this.A1TextBox.CustomButton.Location = new System.Drawing.Point(338, 2);
            this.A1TextBox.CustomButton.Name = "";
            this.A1TextBox.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.A1TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.A1TextBox.CustomButton.TabIndex = 1;
            this.A1TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.A1TextBox.CustomButton.UseSelectable = true;
            this.A1TextBox.CustomButton.Visible = false;
            this.A1TextBox.Lines = new string[0];
            this.A1TextBox.Location = new System.Drawing.Point(109, 301);
            this.A1TextBox.MaxLength = 32767;
            this.A1TextBox.Multiline = true;
            this.A1TextBox.Name = "A1TextBox";
            this.A1TextBox.PasswordChar = '\0';
            this.A1TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.A1TextBox.SelectedText = "";
            this.A1TextBox.SelectionLength = 0;
            this.A1TextBox.SelectionStart = 0;
            this.A1TextBox.ShortcutsEnabled = true;
            this.A1TextBox.Size = new System.Drawing.Size(400, 64);
            this.A1TextBox.TabIndex = 32;
            this.A1TextBox.UseSelectable = true;
            this.A1TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.A1TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // A2TextBox
            // 
            // 
            // 
            // 
            this.A2TextBox.CustomButton.Image = null;
            this.A2TextBox.CustomButton.Location = new System.Drawing.Point(338, 2);
            this.A2TextBox.CustomButton.Name = "";
            this.A2TextBox.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.A2TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.A2TextBox.CustomButton.TabIndex = 1;
            this.A2TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.A2TextBox.CustomButton.UseSelectable = true;
            this.A2TextBox.CustomButton.Visible = false;
            this.A2TextBox.Lines = new string[0];
            this.A2TextBox.Location = new System.Drawing.Point(109, 371);
            this.A2TextBox.MaxLength = 32767;
            this.A2TextBox.Multiline = true;
            this.A2TextBox.Name = "A2TextBox";
            this.A2TextBox.PasswordChar = '\0';
            this.A2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.A2TextBox.SelectedText = "";
            this.A2TextBox.SelectionLength = 0;
            this.A2TextBox.SelectionStart = 0;
            this.A2TextBox.ShortcutsEnabled = true;
            this.A2TextBox.Size = new System.Drawing.Size(400, 64);
            this.A2TextBox.TabIndex = 33;
            this.A2TextBox.UseSelectable = true;
            this.A2TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.A2TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // A3TextBox
            // 
            // 
            // 
            // 
            this.A3TextBox.CustomButton.Image = null;
            this.A3TextBox.CustomButton.Location = new System.Drawing.Point(338, 2);
            this.A3TextBox.CustomButton.Name = "";
            this.A3TextBox.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.A3TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.A3TextBox.CustomButton.TabIndex = 1;
            this.A3TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.A3TextBox.CustomButton.UseSelectable = true;
            this.A3TextBox.CustomButton.Visible = false;
            this.A3TextBox.Lines = new string[0];
            this.A3TextBox.Location = new System.Drawing.Point(109, 441);
            this.A3TextBox.MaxLength = 32767;
            this.A3TextBox.Multiline = true;
            this.A3TextBox.Name = "A3TextBox";
            this.A3TextBox.PasswordChar = '\0';
            this.A3TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.A3TextBox.SelectedText = "";
            this.A3TextBox.SelectionLength = 0;
            this.A3TextBox.SelectionStart = 0;
            this.A3TextBox.ShortcutsEnabled = true;
            this.A3TextBox.Size = new System.Drawing.Size(400, 64);
            this.A3TextBox.TabIndex = 34;
            this.A3TextBox.UseSelectable = true;
            this.A3TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.A3TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // A4TextBox
            // 
            // 
            // 
            // 
            this.A4TextBox.CustomButton.Image = null;
            this.A4TextBox.CustomButton.Location = new System.Drawing.Point(338, 2);
            this.A4TextBox.CustomButton.Name = "";
            this.A4TextBox.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.A4TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.A4TextBox.CustomButton.TabIndex = 1;
            this.A4TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.A4TextBox.CustomButton.UseSelectable = true;
            this.A4TextBox.CustomButton.Visible = false;
            this.A4TextBox.Lines = new string[0];
            this.A4TextBox.Location = new System.Drawing.Point(109, 511);
            this.A4TextBox.MaxLength = 32767;
            this.A4TextBox.Multiline = true;
            this.A4TextBox.Name = "A4TextBox";
            this.A4TextBox.PasswordChar = '\0';
            this.A4TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.A4TextBox.SelectedText = "";
            this.A4TextBox.SelectionLength = 0;
            this.A4TextBox.SelectionStart = 0;
            this.A4TextBox.ShortcutsEnabled = true;
            this.A4TextBox.Size = new System.Drawing.Size(400, 64);
            this.A4TextBox.TabIndex = 35;
            this.A4TextBox.UseSelectable = true;
            this.A4TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.A4TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // A1Radio
            // 
            this.A1Radio.AutoSize = true;
            this.A1Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A1Radio.Location = new System.Drawing.Point(515, 327);
            this.A1Radio.Name = "A1Radio";
            this.A1Radio.Size = new System.Drawing.Size(26, 15);
            this.A1Radio.TabIndex = 36;
            this.A1Radio.Text = " ";
            this.A1Radio.UseSelectable = true;
            // 
            // A2Radio
            // 
            this.A2Radio.AutoSize = true;
            this.A2Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2Radio.Location = new System.Drawing.Point(515, 396);
            this.A2Radio.Name = "A2Radio";
            this.A2Radio.Size = new System.Drawing.Size(26, 15);
            this.A2Radio.TabIndex = 37;
            this.A2Radio.Text = " ";
            this.A2Radio.UseSelectable = true;
            // 
            // A3Radio
            // 
            this.A3Radio.AutoSize = true;
            this.A3Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A3Radio.Location = new System.Drawing.Point(515, 467);
            this.A3Radio.Name = "A3Radio";
            this.A3Radio.Size = new System.Drawing.Size(26, 15);
            this.A3Radio.TabIndex = 38;
            this.A3Radio.Text = " ";
            this.A3Radio.UseSelectable = true;
            // 
            // A4Radio
            // 
            this.A4Radio.AutoSize = true;
            this.A4Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A4Radio.Location = new System.Drawing.Point(515, 536);
            this.A4Radio.Name = "A4Radio";
            this.A4Radio.Size = new System.Drawing.Size(26, 15);
            this.A4Radio.TabIndex = 39;
            this.A4Radio.Text = " ";
            this.A4Radio.UseSelectable = true;
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.CustomButton.Image = null;
            this.commentTextBox.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.commentTextBox.CustomButton.Name = "";
            this.commentTextBox.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.commentTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.commentTextBox.CustomButton.TabIndex = 1;
            this.commentTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.commentTextBox.CustomButton.UseSelectable = true;
            this.commentTextBox.CustomButton.Visible = false;
            this.commentTextBox.Lines = new string[0];
            this.commentTextBox.Location = new System.Drawing.Point(109, 581);
            this.commentTextBox.MaxLength = 32767;
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.PasswordChar = '\0';
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.SelectedText = "";
            this.commentTextBox.SelectionLength = 0;
            this.commentTextBox.SelectionStart = 0;
            this.commentTextBox.ShortcutsEnabled = true;
            this.commentTextBox.Size = new System.Drawing.Size(274, 64);
            this.commentTextBox.TabIndex = 40;
            this.commentTextBox.UseSelectable = true;
            this.commentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.commentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Location = new System.Drawing.Point(389, 581);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 64);
            this.AddButton.TabIndex = 41;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 659);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.A4Radio);
            this.Controls.Add(this.A3Radio);
            this.Controls.Add(this.A2Radio);
            this.Controls.Add(this.A1Radio);
            this.Controls.Add(this.A4TextBox);
            this.Controls.Add(this.A3TextBox);
            this.Controls.Add(this.A2TextBox);
            this.Controls.Add(this.A1TextBox);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.BlockComboBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.a4Label);
            this.Controls.Add(this.a3Label);
            this.Controls.Add(this.a2Label);
            this.Controls.Add(this.a1Label);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.CourseLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddQuestion";
            this.Resizable = false;
            this.Text = "Добавление вопроса";
            this.Load += new System.EventHandler(this.AddQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel CourseLabel;
        private MetroFramework.Controls.MetroLabel BlockLabel;
        private MetroFramework.Controls.MetroLabel QuestionLabel;
        private MetroFramework.Controls.MetroLabel a1Label;
        private MetroFramework.Controls.MetroLabel a2Label;
        private MetroFramework.Controls.MetroLabel a3Label;
        private MetroFramework.Controls.MetroLabel a4Label;
        private MetroFramework.Controls.MetroLabel commentLabel;
        private MetroFramework.Controls.MetroComboBox CourseComboBox;
        private MetroFramework.Controls.MetroComboBox BlockComboBox;
        private MetroFramework.Controls.MetroTextBox QuestionTextBox;
        private MetroFramework.Controls.MetroTextBox A1TextBox;
        private MetroFramework.Controls.MetroTextBox A2TextBox;
        private MetroFramework.Controls.MetroTextBox A3TextBox;
        private MetroFramework.Controls.MetroTextBox A4TextBox;
        private MetroFramework.Controls.MetroRadioButton A1Radio;
        private MetroFramework.Controls.MetroRadioButton A2Radio;
        private MetroFramework.Controls.MetroRadioButton A3Radio;
        private MetroFramework.Controls.MetroRadioButton A4Radio;
        private MetroFramework.Controls.MetroTextBox commentTextBox;
        private MetroFramework.Controls.MetroButton AddButton;
    }
}