namespace XPS.Forms
{
    partial class ExamForm
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
            this.examUserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // examUserLabel
            // 
            this.examUserLabel.AutoSize = true;
            this.examUserLabel.Location = new System.Drawing.Point(2, 243);
            this.examUserLabel.Name = "examUserLabel";
            this.examUserLabel.Size = new System.Drawing.Size(35, 13);
            this.examUserLabel.TabIndex = 0;
            this.examUserLabel.Text = "User: ";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.examUserLabel);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label examUserLabel;
    }
}