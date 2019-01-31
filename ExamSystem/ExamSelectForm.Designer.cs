namespace ExamSystem
{
    partial class ExamSelectForm
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
            this.ChooseExamTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.BlockButton = new MetroFramework.Controls.MetroButton();
            this.FinalButton = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ChooseExamTypeLabel
            // 
            this.ChooseExamTypeLabel.AutoSize = true;
            this.ChooseExamTypeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ChooseExamTypeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ChooseExamTypeLabel.Location = new System.Drawing.Point(23, 30);
            this.ChooseExamTypeLabel.Name = "ChooseExamTypeLabel";
            this.ChooseExamTypeLabel.Size = new System.Drawing.Size(203, 25);
            this.ChooseExamTypeLabel.TabIndex = 0;
            this.ChooseExamTypeLabel.Text = "Выберите тип экзамена";
            // 
            // BlockButton
            // 
            this.BlockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlockButton.Location = new System.Drawing.Point(23, 68);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(101, 68);
            this.BlockButton.TabIndex = 1;
            this.BlockButton.Text = "По блокам";
            this.BlockButton.UseSelectable = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // FinalButton
            // 
            this.FinalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinalButton.Location = new System.Drawing.Point(148, 68);
            this.FinalButton.Name = "FinalButton";
            this.FinalButton.Size = new System.Drawing.Size(101, 68);
            this.FinalButton.TabIndex = 2;
            this.FinalButton.Text = "Итоговый";
            this.FinalButton.UseSelectable = true;
            this.FinalButton.Click += new System.EventHandler(this.FinalButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 142);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 10037;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            // 
            // ExamSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 166);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.FinalButton);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.ChooseExamTypeLabel);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "ExamSelectForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "ExamSelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ChooseExamTypeLabel;
        private MetroFramework.Controls.MetroButton BlockButton;
        private MetroFramework.Controls.MetroButton FinalButton;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}