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
            this.LearnButton = new System.Windows.Forms.Button();
            this.examButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.курсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LearnButton
            // 
            this.LearnButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LearnButton.Location = new System.Drawing.Point(12, 72);
            this.LearnButton.Name = "LearnButton";
            this.LearnButton.Size = new System.Drawing.Size(214, 56);
            this.LearnButton.TabIndex = 2;
            this.LearnButton.Text = "Обучение";
            this.LearnButton.UseVisualStyleBackColor = false;
            this.LearnButton.Click += new System.EventHandler(this.LearnButton_Click);
            // 
            // examButton
            // 
            this.examButton.Location = new System.Drawing.Point(253, 72);
            this.examButton.Name = "examButton";
            this.examButton.Size = new System.Drawing.Size(214, 56);
            this.examButton.TabIndex = 3;
            this.examButton.Text = "Экзамен";
            this.examButton.UseVisualStyleBackColor = true;
            this.examButton.Click += new System.EventHandler(this.examButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсыToolStripMenuItem,
            this.блокиToolStripMenuItem,
            this.вопросыToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "Меню";
            // 
            // курсыToolStripMenuItem
            // 
            this.курсыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьИзменитьToolStripMenuItem});
            this.курсыToolStripMenuItem.Name = "курсыToolStripMenuItem";
            this.курсыToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.курсыToolStripMenuItem.Text = "Курсы";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // удалитьИзменитьToolStripMenuItem
            // 
            this.удалитьИзменитьToolStripMenuItem.Name = "удалитьИзменитьToolStripMenuItem";
            this.удалитьИзменитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.удалитьИзменитьToolStripMenuItem.Text = "Удалить/Изменить";
            this.удалитьИзменитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьИзменитьToolStripMenuItem_Click);
            // 
            // блокиToolStripMenuItem
            // 
            this.блокиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2,
            this.удалитьИзменитьToolStripMenuItem1});
            this.блокиToolStripMenuItem.Name = "блокиToolStripMenuItem";
            this.блокиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.блокиToolStripMenuItem.Text = "Блоки";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьToolStripMenuItem2_Click);
            // 
            // удалитьИзменитьToolStripMenuItem1
            // 
            this.удалитьИзменитьToolStripMenuItem1.Name = "удалитьИзменитьToolStripMenuItem1";
            this.удалитьИзменитьToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.удалитьИзменитьToolStripMenuItem1.Text = "Удалить/Изменить";
            this.удалитьИзменитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьИзменитьToolStripMenuItem1_Click);
            // 
            // вопросыToolStripMenuItem
            // 
            this.вопросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.вопросыToolStripMenuItem.Name = "вопросыToolStripMenuItem";
            this.вопросыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.вопросыToolStripMenuItem.Text = "Вопросы";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить/Изменить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.просмотрToolStripMenuItem.Text = "Просмотр/Удаление";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(479, 140);
            this.Controls.Add(this.examButton);
            this.Controls.Add(this.LearnButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LearnButton;
        private System.Windows.Forms.Button examButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
    }
}

