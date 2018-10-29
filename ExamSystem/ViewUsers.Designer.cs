namespace ExamSystem
{
    partial class ViewUsers
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
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.ViewExamButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExamsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.usersGridView.Location = new System.Drawing.Point(0, 0);
            this.usersGridView.MultiSelect = false;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(844, 450);
            this.usersGridView.TabIndex = 0;
            this.usersGridView.SelectionChanged += new System.EventHandler(this.usersGridView_SelectionChanged);
            // 
            // ViewExamButton
            // 
            this.ViewExamButton.Location = new System.Drawing.Point(850, 39);
            this.ViewExamButton.Name = "ViewExamButton";
            this.ViewExamButton.Size = new System.Drawing.Size(142, 50);
            this.ViewExamButton.TabIndex = 1;
            this.ViewExamButton.Text = "Посмотреть";
            this.ViewExamButton.UseVisualStyleBackColor = true;
            this.ViewExamButton.Visible = false;
            this.ViewExamButton.Click += new System.EventHandler(this.ViewExamButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(850, 388);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(142, 50);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExamsComboBox
            // 
            this.ExamsComboBox.FormattingEnabled = true;
            this.ExamsComboBox.Location = new System.Drawing.Point(850, 12);
            this.ExamsComboBox.Name = "ExamsComboBox";
            this.ExamsComboBox.Size = new System.Drawing.Size(142, 21);
            this.ExamsComboBox.TabIndex = 3;
            this.ExamsComboBox.Visible = false;
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.ExamsComboBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewExamButton);
            this.Controls.Add(this.usersGridView);
            this.Name = "ViewUsers";
            this.Text = "Просмотр пользователей";
            this.Load += new System.EventHandler(this.view_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Button ViewExamButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox ExamsComboBox;
    }
}