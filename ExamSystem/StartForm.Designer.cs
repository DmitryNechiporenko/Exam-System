namespace ExamSystem
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.LearnButton = new MetroFramework.Controls.MetroButton();
            this.examButton = new MetroFramework.Controls.MetroButton();
            this.adminButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LearnButton
            // 
            this.LearnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LearnButton.Location = new System.Drawing.Point(48, 110);
            this.LearnButton.Name = "LearnButton";
            this.LearnButton.Size = new System.Drawing.Size(214, 87);
            this.LearnButton.TabIndex = 2;
            this.LearnButton.Text = "Обучение";
            this.LearnButton.UseSelectable = true;
            this.LearnButton.Click += new System.EventHandler(this.LearnButton_Click);
            // 
            // examButton
            // 
            this.examButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.examButton.Location = new System.Drawing.Point(270, 110);
            this.examButton.Name = "examButton";
            this.examButton.Size = new System.Drawing.Size(214, 87);
            this.examButton.TabIndex = 3;
            this.examButton.Text = "Экзамен";
            this.examButton.UseSelectable = true;
            this.examButton.Click += new System.EventHandler(this.examButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.Location = new System.Drawing.Point(412, 250);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(103, 23);
            this.adminButton.TabIndex = 4;
            this.adminButton.Text = "Редактирование";
            this.adminButton.UseSelectable = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamSystem.Properties.Resources.civssm;
            this.pictureBox1.Location = new System.Drawing.Point(440, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(36, 217);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(58, 56);
            this.metroButton1.TabIndex = 10050;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 296);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.examButton);
            this.Controls.Add(this.LearnButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(538, 296);
            this.MinimumSize = new System.Drawing.Size(538, 296);
            this.Name = "StartForm";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Система тестирования";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton LearnButton;
        private MetroFramework.Controls.MetroButton examButton;
        private MetroFramework.Controls.MetroButton adminButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

