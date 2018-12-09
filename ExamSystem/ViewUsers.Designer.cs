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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsers));
            this.usersGridView = new MetroFramework.Controls.MetroGrid();
            this.ViewExamButton = new MetroFramework.Controls.MetroButton();
            this.DeleteButton = new MetroFramework.Controls.MetroButton();
            this.ExamsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goBackButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AllowUserToResizeRows = false;
            this.usersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.usersGridView.EnableHeadersVisualStyles = false;
            this.usersGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersGridView.Location = new System.Drawing.Point(20, 60);
            this.usersGridView.MultiSelect = false;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(880, 470);
            this.usersGridView.TabIndex = 4;
            this.usersGridView.SelectionChanged += new System.EventHandler(this.usersGridView_SelectionChanged);
            // 
            // ViewExamButton
            // 
            this.ViewExamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewExamButton.Location = new System.Drawing.Point(909, 146);
            this.ViewExamButton.Name = "ViewExamButton";
            this.ViewExamButton.Size = new System.Drawing.Size(270, 58);
            this.ViewExamButton.TabIndex = 5;
            this.ViewExamButton.Text = "Посмотреть экзамен";
            this.ViewExamButton.UseSelectable = true;
            this.ViewExamButton.Click += new System.EventHandler(this.ViewExamButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Location = new System.Drawing.Point(909, 472);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(270, 58);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить пользователя";
            this.DeleteButton.UseSelectable = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExamsComboBox
            // 
            this.ExamsComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.ExamsComboBox.FormattingEnabled = true;
            this.ExamsComboBox.ItemHeight = 23;
            this.ExamsComboBox.Location = new System.Drawing.Point(909, 111);
            this.ExamsComboBox.Name = "ExamsComboBox";
            this.ExamsComboBox.Size = new System.Drawing.Size(270, 29);
            this.ExamsComboBox.TabIndex = 7;
            this.ExamsComboBox.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamSystem.Properties.Resources.civssm;
            this.pictureBox1.Location = new System.Drawing.Point(1095, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10037;
            this.pictureBox1.TabStop = false;
            // 
            // goBackButton
            // 
            this.goBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBackButton.Location = new System.Drawing.Point(294, 30);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(37, 21);
            this.goBackButton.Style = MetroFramework.MetroColorStyle.White;
            this.goBackButton.TabIndex = 10038;
            this.goBackButton.Text = "<<";
            this.goBackButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.goBackButton.UseCustomBackColor = true;
            this.goBackButton.UseSelectable = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 550);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExamsComboBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewExamButton);
            this.Controls.Add(this.usersGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewUsers";
            this.Resizable = false;
            this.Text = "Просмотр пользователей";
            this.Load += new System.EventHandler(this.view_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid usersGridView;
        private MetroFramework.Controls.MetroButton ViewExamButton;
        private MetroFramework.Controls.MetroButton DeleteButton;
        private MetroFramework.Controls.MetroComboBox ExamsComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton goBackButton;
    }
}