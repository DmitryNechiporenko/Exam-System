namespace ExamSystem
{
    partial class adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminform));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.DelCourseButton = new MetroFramework.Controls.MetroButton();
            this.AddCourseButton = new MetroFramework.Controls.MetroButton();
            this.CourseLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.DelBlockButton = new MetroFramework.Controls.MetroButton();
            this.AddBlockButton = new MetroFramework.Controls.MetroButton();
            this.BlockLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.DelQuesButton = new MetroFramework.Controls.MetroButton();
            this.AddQuesButton = new MetroFramework.Controls.MetroButton();
            this.QuestionLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 58);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(435, 353);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.DelCourseButton);
            this.metroTabPage1.Controls.Add(this.AddCourseButton);
            this.metroTabPage1.Controls.Add(this.CourseLabel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(427, 311);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Курсы";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // DelCourseButton
            // 
            this.DelCourseButton.Location = new System.Drawing.Point(114, 197);
            this.DelCourseButton.Name = "DelCourseButton";
            this.DelCourseButton.Size = new System.Drawing.Size(181, 75);
            this.DelCourseButton.TabIndex = 4;
            this.DelCourseButton.Text = "Удалить/Изменить";
            this.DelCourseButton.UseSelectable = true;
            this.DelCourseButton.Click += new System.EventHandler(this.DelCourseButton_Click);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(114, 90);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(181, 75);
            this.AddCourseButton.TabIndex = 3;
            this.AddCourseButton.Text = "Добавить";
            this.AddCourseButton.UseSelectable = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CourseLabel.Location = new System.Drawing.Point(174, 43);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(59, 25);
            this.CourseLabel.TabIndex = 2;
            this.CourseLabel.Text = "Курсы";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.DelBlockButton);
            this.metroTabPage2.Controls.Add(this.AddBlockButton);
            this.metroTabPage2.Controls.Add(this.BlockLabel);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(427, 311);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Блоки";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // DelBlockButton
            // 
            this.DelBlockButton.Location = new System.Drawing.Point(114, 197);
            this.DelBlockButton.Name = "DelBlockButton";
            this.DelBlockButton.Size = new System.Drawing.Size(181, 75);
            this.DelBlockButton.TabIndex = 7;
            this.DelBlockButton.Text = "Удалить/Изменить";
            this.DelBlockButton.UseSelectable = true;
            this.DelBlockButton.Click += new System.EventHandler(this.DelBlockButton_Click);
            // 
            // AddBlockButton
            // 
            this.AddBlockButton.Location = new System.Drawing.Point(114, 90);
            this.AddBlockButton.Name = "AddBlockButton";
            this.AddBlockButton.Size = new System.Drawing.Size(181, 75);
            this.AddBlockButton.TabIndex = 6;
            this.AddBlockButton.Text = "Добавить";
            this.AddBlockButton.UseSelectable = true;
            this.AddBlockButton.Click += new System.EventHandler(this.AddBlockButton_Click);
            // 
            // BlockLabel
            // 
            this.BlockLabel.AutoSize = true;
            this.BlockLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.BlockLabel.Location = new System.Drawing.Point(174, 43);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(59, 25);
            this.BlockLabel.TabIndex = 5;
            this.BlockLabel.Text = "Блоки";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.DelQuesButton);
            this.metroTabPage3.Controls.Add(this.AddQuesButton);
            this.metroTabPage3.Controls.Add(this.QuestionLabel);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(427, 311);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Вопросы";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // DelQuesButton
            // 
            this.DelQuesButton.Location = new System.Drawing.Point(114, 197);
            this.DelQuesButton.Name = "DelQuesButton";
            this.DelQuesButton.Size = new System.Drawing.Size(181, 75);
            this.DelQuesButton.TabIndex = 10;
            this.DelQuesButton.Text = "Удалить/Изменить";
            this.DelQuesButton.UseSelectable = true;
            this.DelQuesButton.Click += new System.EventHandler(this.DelQuesButton_Click);
            // 
            // AddQuesButton
            // 
            this.AddQuesButton.Location = new System.Drawing.Point(114, 90);
            this.AddQuesButton.Name = "AddQuesButton";
            this.AddQuesButton.Size = new System.Drawing.Size(181, 75);
            this.AddQuesButton.TabIndex = 9;
            this.AddQuesButton.Text = "Добавить";
            this.AddQuesButton.UseSelectable = true;
            this.AddQuesButton.Click += new System.EventHandler(this.AddQuesButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.QuestionLabel.Location = new System.Drawing.Point(159, 43);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(82, 25);
            this.QuestionLabel.TabIndex = 8;
            this.QuestionLabel.Text = "Вопросы";
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroButton1);
            this.metroTabPage4.Controls.Add(this.metroLabel1);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(427, 311);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Пользователи";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(114, 90);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(181, 75);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Просмотр/Удаление";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(146, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Пользователи";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamSystem.Properties.Resources.civssm;
            this.pictureBox1.Location = new System.Drawing.Point(377, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminform";
            this.Text = "Редактирование";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel CourseLabel;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroButton DelCourseButton;
        private MetroFramework.Controls.MetroButton AddCourseButton;
        private MetroFramework.Controls.MetroButton DelBlockButton;
        private MetroFramework.Controls.MetroButton AddBlockButton;
        private MetroFramework.Controls.MetroLabel BlockLabel;
        private MetroFramework.Controls.MetroButton DelQuesButton;
        private MetroFramework.Controls.MetroButton AddQuesButton;
        private MetroFramework.Controls.MetroLabel QuestionLabel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}