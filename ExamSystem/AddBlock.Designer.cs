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
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.BlockTextBox = new System.Windows.Forms.TextBox();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(104, 24);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(185, 21);
            this.CourseComboBox.TabIndex = 0;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(54, 27);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(31, 13);
            this.CourseLabel.TabIndex = 1;
            this.CourseLabel.Text = "Курс";
            // 
            // BlockTextBox
            // 
            this.BlockTextBox.Location = new System.Drawing.Point(104, 51);
            this.BlockTextBox.Name = "BlockTextBox";
            this.BlockTextBox.Size = new System.Drawing.Size(185, 20);
            this.BlockTextBox.TabIndex = 2;
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.Location = new System.Drawing.Point(54, 54);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(32, 13);
            this.BlockLabel.TabIndex = 3;
            this.BlockLabel.Text = "Блок";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(57, 99);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(232, 53);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 175);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.BlockTextBox);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.CourseComboBox);
            this.Name = "AddBlock";
            this.Text = "Добавление блока";
            this.Load += new System.EventHandler(this.AddBlock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.TextBox BlockTextBox;
        private System.Windows.Forms.Label BlockLabel;
        private System.Windows.Forms.Button AddButton;
    }
}