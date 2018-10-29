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
            this.DelButton = new System.Windows.Forms.Button();
            this.UpdButton = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.BlockTextBox = new System.Windows.Forms.TextBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.BlockComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(203, 128);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(100, 58);
            this.DelButton.TabIndex = 11;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // UpdButton
            // 
            this.UpdButton.Location = new System.Drawing.Point(85, 128);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(102, 58);
            this.UpdButton.TabIndex = 10;
            this.UpdButton.Text = "Изменить";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(82, 92);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(37, 13);
            this.TextLabel.TabIndex = 9;
            this.TextLabel.Text = "Текст";
            // 
            // BlockTextBox
            // 
            this.BlockTextBox.Location = new System.Drawing.Point(119, 89);
            this.BlockTextBox.Name = "BlockTextBox";
            this.BlockTextBox.Size = new System.Drawing.Size(184, 20);
            this.BlockTextBox.TabIndex = 8;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(82, 38);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(31, 13);
            this.CourseLabel.TabIndex = 7;
            this.CourseLabel.Text = "Курс";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(119, 35);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(184, 21);
            this.CourseComboBox.TabIndex = 6;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(82, 65);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(32, 13);
            this.BlockLabel.TabIndex = 13;
            this.BlockLabel.Text = "Блок";
            // 
            // BlockComboBox
            // 
            this.BlockComboBox.FormattingEnabled = true;
            this.BlockComboBox.Location = new System.Drawing.Point(119, 62);
            this.BlockComboBox.Name = "BlockComboBox";
            this.BlockComboBox.Size = new System.Drawing.Size(184, 21);
            this.BlockComboBox.TabIndex = 12;
            this.BlockComboBox.SelectedValueChanged += new System.EventHandler(this.BlockComboBox_SelectedValueChanged);
            // 
            // DelBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 217);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.BlockComboBox);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.BlockTextBox);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.CourseComboBox);
            this.Name = "DelBlock";
            this.Text = "Изменение блоков";
            this.Load += new System.EventHandler(this.DelBlock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox BlockTextBox;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label BlockLabel;
        private System.Windows.Forms.ComboBox BlockComboBox;
    }
}