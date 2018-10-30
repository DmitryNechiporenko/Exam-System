namespace ExamSystem
{
    partial class LearnForm
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
            this.CourseBlocksListBox = new System.Windows.Forms.ListBox();
            this.ChoosedBlocksListBox = new System.Windows.Forms.ListBox();
            this.AddBlockButton = new System.Windows.Forms.Button();
            this.DeleteBlockButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ChooseCourseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(209, 36);
            this.CourseComboBox.MaxDropDownItems = 50;
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(200, 21);
            this.CourseComboBox.TabIndex = 0;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // CourseBlocksListBox
            // 
            this.CourseBlocksListBox.FormattingEnabled = true;
            this.CourseBlocksListBox.Location = new System.Drawing.Point(12, 63);
            this.CourseBlocksListBox.Name = "CourseBlocksListBox";
            this.CourseBlocksListBox.Size = new System.Drawing.Size(191, 303);
            this.CourseBlocksListBox.TabIndex = 1;
            this.CourseBlocksListBox.DoubleClick += new System.EventHandler(this.AddBlockButton_Click);
            // 
            // ChoosedBlocksListBox
            // 
            this.ChoosedBlocksListBox.FormattingEnabled = true;
            this.ChoosedBlocksListBox.Location = new System.Drawing.Point(415, 63);
            this.ChoosedBlocksListBox.Name = "ChoosedBlocksListBox";
            this.ChoosedBlocksListBox.Size = new System.Drawing.Size(191, 303);
            this.ChoosedBlocksListBox.TabIndex = 2;
            this.ChoosedBlocksListBox.DoubleClick += new System.EventHandler(this.DeleteBlockButton_Click);
            // 
            // AddBlockButton
            // 
            this.AddBlockButton.Location = new System.Drawing.Point(209, 63);
            this.AddBlockButton.Name = "AddBlockButton";
            this.AddBlockButton.Size = new System.Drawing.Size(200, 45);
            this.AddBlockButton.TabIndex = 3;
            this.AddBlockButton.Text = "Добавить блок";
            this.AddBlockButton.UseVisualStyleBackColor = true;
            this.AddBlockButton.Click += new System.EventHandler(this.AddBlockButton_Click);
            // 
            // DeleteBlockButton
            // 
            this.DeleteBlockButton.Location = new System.Drawing.Point(209, 114);
            this.DeleteBlockButton.Name = "DeleteBlockButton";
            this.DeleteBlockButton.Size = new System.Drawing.Size(200, 45);
            this.DeleteBlockButton.TabIndex = 4;
            this.DeleteBlockButton.Text = "Удалить блок";
            this.DeleteBlockButton.UseVisualStyleBackColor = true;
            this.DeleteBlockButton.Click += new System.EventHandler(this.DeleteBlockButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(209, 321);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 45);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Начать обучение";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ChooseCourseLabel
            // 
            this.ChooseCourseLabel.AutoSize = true;
            this.ChooseCourseLabel.Location = new System.Drawing.Point(260, 20);
            this.ChooseCourseLabel.Name = "ChooseCourseLabel";
            this.ChooseCourseLabel.Size = new System.Drawing.Size(83, 13);
            this.ChooseCourseLabel.TabIndex = 6;
            this.ChooseCourseLabel.Text = "Выберите курс";
            // 
            // LearnChooseBlocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 378);
            this.Controls.Add(this.ChooseCourseLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DeleteBlockButton);
            this.Controls.Add(this.AddBlockButton);
            this.Controls.Add(this.ChoosedBlocksListBox);
            this.Controls.Add(this.CourseBlocksListBox);
            this.Controls.Add(this.CourseComboBox);
            this.Name = "LearnChooseBlocksForm";
            this.Text = "Выбор блоков";
            this.Load += new System.EventHandler(this.LearnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.ListBox CourseBlocksListBox;
        private System.Windows.Forms.ListBox ChoosedBlocksListBox;
        private System.Windows.Forms.Button AddBlockButton;
        private System.Windows.Forms.Button DeleteBlockButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ChooseCourseLabel;
    }
}