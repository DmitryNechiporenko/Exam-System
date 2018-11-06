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
            this.SuspendLayout();
            // 
            // LearnButton
            // 
            this.LearnButton.Location = new System.Drawing.Point(20, 63);
            this.LearnButton.Name = "LearnButton";
            this.LearnButton.Size = new System.Drawing.Size(214, 87);
            this.LearnButton.TabIndex = 2;
            this.LearnButton.Text = "Обучение";
            this.LearnButton.UseSelectable = true;
            this.LearnButton.Click += new System.EventHandler(this.LearnButton_Click);
            // 
            // examButton
            // 
            this.examButton.Location = new System.Drawing.Point(242, 63);
            this.examButton.Name = "examButton";
            this.examButton.Size = new System.Drawing.Size(214, 87);
            this.examButton.TabIndex = 3;
            this.examButton.Text = "Экзамен";
            this.examButton.UseSelectable = true;
            this.examButton.Click += new System.EventHandler(this.examButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(353, 188);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(103, 23);
            this.adminButton.TabIndex = 4;
            this.adminButton.Text = "Редактирование";
            this.adminButton.UseSelectable = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 218);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.examButton);
            this.Controls.Add(this.LearnButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "Система тестирования";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton LearnButton;
        private MetroFramework.Controls.MetroButton examButton;
        private MetroFramework.Controls.MetroButton adminButton;
    }
}

