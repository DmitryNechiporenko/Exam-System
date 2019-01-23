namespace ExamSystem
{
    partial class DelBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelBlock));
            this.CourseLabel = new MetroFramework.Controls.MetroLabel();
            this.BlockLabel = new MetroFramework.Controls.MetroLabel();
            this.TextLabel = new MetroFramework.Controls.MetroLabel();
            this.UpdButton = new MetroFramework.Controls.MetroButton();
            this.DelButton = new MetroFramework.Controls.MetroButton();
            this.CourseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BlockComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BlockTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(71, 63);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(36, 19);
            this.CourseLabel.TabIndex = 14;
            this.CourseLabel.Text = "Курс";
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(69, 98);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(38, 19);
            this.BlockLabel.TabIndex = 15;
            this.BlockLabel.Text = "Блок";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(5, 133);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(102, 19);
            this.TextLabel.TabIndex = 16;
            this.TextLabel.Text = "Наименование";
            // 
            // UpdButton
            // 
            this.UpdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdButton.Location = new System.Drawing.Point(276, 203);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(113, 68);
            this.UpdButton.TabIndex = 4;
            this.UpdButton.Text = "Изменить";
            this.UpdButton.UseSelectable = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.Location = new System.Drawing.Point(395, 203);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(113, 68);
            this.DelButton.TabIndex = 5;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseSelectable = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.ItemHeight = 19;
            this.CourseComboBox.Location = new System.Drawing.Point(113, 63);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(400, 25);
            this.CourseComboBox.TabIndex = 1;
            this.CourseComboBox.UseSelectable = true;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // BlockComboBox
            // 
            this.BlockComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.BlockComboBox.FormattingEnabled = true;
            this.BlockComboBox.ItemHeight = 19;
            this.BlockComboBox.Location = new System.Drawing.Point(113, 98);
            this.BlockComboBox.Name = "BlockComboBox";
            this.BlockComboBox.Size = new System.Drawing.Size(400, 25);
            this.BlockComboBox.TabIndex = 2;
            this.BlockComboBox.UseSelectable = true;
            this.BlockComboBox.SelectedValueChanged += new System.EventHandler(this.BlockComboBox_SelectedValueChanged);
            // 
            // BlockTextBox
            // 
            // 
            // 
            // 
            this.BlockTextBox.CustomButton.Image = null;
            this.BlockTextBox.CustomButton.Location = new System.Drawing.Point(338, 2);
            this.BlockTextBox.CustomButton.Name = "";
            this.BlockTextBox.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.BlockTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BlockTextBox.CustomButton.TabIndex = 1;
            this.BlockTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BlockTextBox.CustomButton.UseSelectable = true;
            this.BlockTextBox.CustomButton.Visible = false;
            this.BlockTextBox.Lines = new string[0];
            this.BlockTextBox.Location = new System.Drawing.Point(113, 133);
            this.BlockTextBox.MaxLength = 32767;
            this.BlockTextBox.Multiline = true;
            this.BlockTextBox.Name = "BlockTextBox";
            this.BlockTextBox.PasswordChar = '\0';
            this.BlockTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BlockTextBox.SelectedText = "";
            this.BlockTextBox.SelectionLength = 0;
            this.BlockTextBox.SelectionStart = 0;
            this.BlockTextBox.ShortcutsEnabled = true;
            this.BlockTextBox.Size = new System.Drawing.Size(400, 64);
            this.BlockTextBox.TabIndex = 3;
            this.BlockTextBox.UseSelectable = true;
            this.BlockTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BlockTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 215);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(58, 56);
            this.metroButton1.TabIndex = 10046;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            // 
            // DelBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 284);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.BlockTextBox);
            this.Controls.Add(this.BlockComboBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.CourseLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DelBlock";
            this.Resizable = false;
            this.Text = "Изменение блоков";
            this.Load += new System.EventHandler(this.DelBlock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel CourseLabel;
        private MetroFramework.Controls.MetroLabel BlockLabel;
        private MetroFramework.Controls.MetroLabel TextLabel;
        private MetroFramework.Controls.MetroButton UpdButton;
        private MetroFramework.Controls.MetroButton DelButton;
        private MetroFramework.Controls.MetroComboBox CourseComboBox;
        private MetroFramework.Controls.MetroComboBox BlockComboBox;
        private MetroFramework.Controls.MetroTextBox BlockTextBox;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}