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
            this.ChoosedBlocksListBox = new System.Windows.Forms.ListBox();
            this.CourseBlocksListBox = new System.Windows.Forms.ListBox();
            this.AddBlockButton = new MetroFramework.Controls.MetroButton();
            this.DeleteBlockButton = new MetroFramework.Controls.MetroButton();
            this.StartButton = new MetroFramework.Controls.MetroButton();
            this.ChooseCourseLabel = new MetroFramework.Controls.MetroLabel();
            this.CourseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // ChoosedBlocksListBox
            // 
            this.ChoosedBlocksListBox.FormattingEnabled = true;
            this.ChoosedBlocksListBox.Location = new System.Drawing.Point(425, 106);
            this.ChoosedBlocksListBox.Name = "ChoosedBlocksListBox";
            this.ChoosedBlocksListBox.Size = new System.Drawing.Size(191, 303);
            this.ChoosedBlocksListBox.TabIndex = 2;
            this.ChoosedBlocksListBox.DoubleClick += new System.EventHandler(this.DeleteBlockButton_Click);
            // 
            // CourseBlocksListBox
            // 
            this.CourseBlocksListBox.FormattingEnabled = true;
            this.CourseBlocksListBox.Location = new System.Drawing.Point(22, 106);
            this.CourseBlocksListBox.Name = "CourseBlocksListBox";
            this.CourseBlocksListBox.Size = new System.Drawing.Size(191, 303);
            this.CourseBlocksListBox.TabIndex = 7;
            // 
            // AddBlockButton
            // 
            this.AddBlockButton.Location = new System.Drawing.Point(219, 106);
            this.AddBlockButton.Name = "AddBlockButton";
            this.AddBlockButton.Size = new System.Drawing.Size(200, 45);
            this.AddBlockButton.TabIndex = 8;
            this.AddBlockButton.Text = "Добавить блок";
            this.AddBlockButton.UseSelectable = true;
            this.AddBlockButton.Click += new System.EventHandler(this.AddBlockButton_Click);
            // 
            // DeleteBlockButton
            // 
            this.DeleteBlockButton.Location = new System.Drawing.Point(219, 157);
            this.DeleteBlockButton.Name = "DeleteBlockButton";
            this.DeleteBlockButton.Size = new System.Drawing.Size(200, 45);
            this.DeleteBlockButton.TabIndex = 9;
            this.DeleteBlockButton.Text = "Удалить блок";
            this.DeleteBlockButton.UseSelectable = true;
            this.DeleteBlockButton.Click += new System.EventHandler(this.DeleteBlockButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(219, 364);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 45);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Начать обучение";
            this.StartButton.UseSelectable = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ChooseCourseLabel
            // 
            this.ChooseCourseLabel.AutoSize = true;
            this.ChooseCourseLabel.Location = new System.Drawing.Point(265, 47);
            this.ChooseCourseLabel.Name = "ChooseCourseLabel";
            this.ChooseCourseLabel.Size = new System.Drawing.Size(99, 19);
            this.ChooseCourseLabel.TabIndex = 11;
            this.ChooseCourseLabel.Text = "Выберите курс";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.ItemHeight = 23;
            this.CourseComboBox.Location = new System.Drawing.Point(219, 69);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(200, 29);
            this.CourseComboBox.TabIndex = 12;
            this.CourseComboBox.UseSelectable = true;
            this.CourseComboBox.SelectedValueChanged += new System.EventHandler(this.CourseComboBox_SelectedValueChanged);
            // 
            // LearnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 433);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.ChooseCourseLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DeleteBlockButton);
            this.Controls.Add(this.AddBlockButton);
            this.Controls.Add(this.CourseBlocksListBox);
            this.Controls.Add(this.ChoosedBlocksListBox);
            this.Name = "LearnForm";
            this.Text = "Выбор блоков";
            this.Load += new System.EventHandler(this.LearnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ChoosedBlocksListBox;
        private System.Windows.Forms.ListBox CourseBlocksListBox;
        private MetroFramework.Controls.MetroButton AddBlockButton;
        private MetroFramework.Controls.MetroButton DeleteBlockButton;
        private MetroFramework.Controls.MetroButton StartButton;
        private MetroFramework.Controls.MetroLabel ChooseCourseLabel;
        private MetroFramework.Controls.MetroComboBox CourseComboBox;
    }
}