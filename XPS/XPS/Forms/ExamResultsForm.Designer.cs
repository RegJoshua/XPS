namespace XPS.Forms
{
    partial class ExamResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamResultsForm));
            this.erfMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erfHeadingGroupBox = new System.Windows.Forms.GroupBox();
            this.erfTestIDTextBx = new System.Windows.Forms.TextBox();
            this.erfTestIDLabel = new System.Windows.Forms.Label();
            this.erfTimeTextBx = new System.Windows.Forms.TextBox();
            this.srfResultsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.erfTimeLabel = new System.Windows.Forms.Label();
            this.erfNameLabel = new System.Windows.Forms.Label();
            this.erfScoreTextBox = new System.Windows.Forms.TextBox();
            this.erfCorrectLabel = new System.Windows.Forms.Label();
            this.erfIncorrectLabel = new System.Windows.Forms.Label();
            this.erfAttemptedLabel = new System.Windows.Forms.Label();
            this.erfCorrectTxtBx = new System.Windows.Forms.TextBox();
            this.erfIncorrectTxtBx = new System.Windows.Forms.TextBox();
            this.erfAttemptedTxtBx = new System.Windows.Forms.TextBox();
            this.erfHomeButton = new System.Windows.Forms.Button();
            this.erfMainMenuStrip.SuspendLayout();
            this.erfHeadingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // erfMainMenuStrip
            // 
            this.erfMainMenuStrip.BackColor = System.Drawing.Color.Maroon;
            this.erfMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.erfMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.erfMainMenuStrip.Name = "erfMainMenuStrip";
            this.erfMainMenuStrip.Size = new System.Drawing.Size(863, 24);
            this.erfMainMenuStrip.TabIndex = 2;
            this.erfMainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // erfHeadingGroupBox
            // 
            this.erfHeadingGroupBox.BackColor = System.Drawing.Color.Maroon;
            this.erfHeadingGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.erfHeadingGroupBox.Controls.Add(this.erfTestIDTextBx);
            this.erfHeadingGroupBox.Controls.Add(this.erfTestIDLabel);
            this.erfHeadingGroupBox.Controls.Add(this.erfTimeTextBx);
            this.erfHeadingGroupBox.Controls.Add(this.srfResultsLabel);
            this.erfHeadingGroupBox.Controls.Add(this.pictureBox1);
            this.erfHeadingGroupBox.Controls.Add(this.erfTimeLabel);
            this.erfHeadingGroupBox.Controls.Add(this.erfNameLabel);
            this.erfHeadingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfHeadingGroupBox.ForeColor = System.Drawing.Color.Gold;
            this.erfHeadingGroupBox.Location = new System.Drawing.Point(0, 36);
            this.erfHeadingGroupBox.Name = "erfHeadingGroupBox";
            this.erfHeadingGroupBox.Size = new System.Drawing.Size(863, 140);
            this.erfHeadingGroupBox.TabIndex = 9;
            this.erfHeadingGroupBox.TabStop = false;
            // 
            // erfTestIDTextBx
            // 
            this.erfTestIDTextBx.Enabled = false;
            this.erfTestIDTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfTestIDTextBx.ForeColor = System.Drawing.Color.Maroon;
            this.erfTestIDTextBx.Location = new System.Drawing.Point(87, 95);
            this.erfTestIDTextBx.Name = "erfTestIDTextBx";
            this.erfTestIDTextBx.ReadOnly = true;
            this.erfTestIDTextBx.Size = new System.Drawing.Size(100, 29);
            this.erfTestIDTextBx.TabIndex = 20;
            this.erfTestIDTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // erfTestIDLabel
            // 
            this.erfTestIDLabel.AutoSize = true;
            this.erfTestIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfTestIDLabel.ForeColor = System.Drawing.Color.Gold;
            this.erfTestIDLabel.Location = new System.Drawing.Point(15, 104);
            this.erfTestIDLabel.Name = "erfTestIDLabel";
            this.erfTestIDLabel.Size = new System.Drawing.Size(67, 18);
            this.erfTestIDLabel.TabIndex = 19;
            this.erfTestIDLabel.Text = "Test ID:";
            // 
            // erfTimeTextBx
            // 
            this.erfTimeTextBx.Enabled = false;
            this.erfTimeTextBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfTimeTextBx.ForeColor = System.Drawing.Color.Maroon;
            this.erfTimeTextBx.Location = new System.Drawing.Point(87, 60);
            this.erfTimeTextBx.Name = "erfTimeTextBx";
            this.erfTimeTextBx.ReadOnly = true;
            this.erfTimeTextBx.Size = new System.Drawing.Size(100, 29);
            this.erfTimeTextBx.TabIndex = 18;
            this.erfTimeTextBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // srfResultsLabel
            // 
            this.srfResultsLabel.AutoSize = true;
            this.srfResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srfResultsLabel.Location = new System.Drawing.Point(348, 96);
            this.srfResultsLabel.Name = "srfResultsLabel";
            this.srfResultsLabel.Size = new System.Drawing.Size(181, 31);
            this.srfResultsLabel.TabIndex = 17;
            this.srfResultsLabel.Text = "Exam Results";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(741, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // erfTimeLabel
            // 
            this.erfTimeLabel.AutoSize = true;
            this.erfTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfTimeLabel.ForeColor = System.Drawing.Color.Gold;
            this.erfTimeLabel.Location = new System.Drawing.Point(27, 69);
            this.erfTimeLabel.Name = "erfTimeLabel";
            this.erfTimeLabel.Size = new System.Drawing.Size(50, 18);
            this.erfTimeLabel.TabIndex = 14;
            this.erfTimeLabel.Text = "Time:";
            // 
            // erfNameLabel
            // 
            this.erfNameLabel.AutoSize = true;
            this.erfNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.erfNameLabel.Location = new System.Drawing.Point(30, 32);
            this.erfNameLabel.Name = "erfNameLabel";
            this.erfNameLabel.Size = new System.Drawing.Size(0, 25);
            this.erfNameLabel.TabIndex = 13;
            // 
            // erfScoreTextBox
            // 
            this.erfScoreTextBox.Enabled = false;
            this.erfScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfScoreTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.erfScoreTextBox.Location = new System.Drawing.Point(354, 193);
            this.erfScoreTextBox.Name = "erfScoreTextBox";
            this.erfScoreTextBox.ReadOnly = true;
            this.erfScoreTextBox.Size = new System.Drawing.Size(161, 80);
            this.erfScoreTextBox.TabIndex = 10;
            this.erfScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // erfCorrectLabel
            // 
            this.erfCorrectLabel.AutoSize = true;
            this.erfCorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfCorrectLabel.ForeColor = System.Drawing.Color.Maroon;
            this.erfCorrectLabel.Location = new System.Drawing.Point(325, 308);
            this.erfCorrectLabel.Name = "erfCorrectLabel";
            this.erfCorrectLabel.Size = new System.Drawing.Size(84, 24);
            this.erfCorrectLabel.TabIndex = 11;
            this.erfCorrectLabel.Text = "Correct:";
            this.erfCorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // erfIncorrectLabel
            // 
            this.erfIncorrectLabel.AutoSize = true;
            this.erfIncorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfIncorrectLabel.ForeColor = System.Drawing.Color.Maroon;
            this.erfIncorrectLabel.Location = new System.Drawing.Point(311, 352);
            this.erfIncorrectLabel.Name = "erfIncorrectLabel";
            this.erfIncorrectLabel.Size = new System.Drawing.Size(98, 24);
            this.erfIncorrectLabel.TabIndex = 12;
            this.erfIncorrectLabel.Text = "Incorrect:";
            this.erfIncorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // erfAttemptedLabel
            // 
            this.erfAttemptedLabel.AutoSize = true;
            this.erfAttemptedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfAttemptedLabel.ForeColor = System.Drawing.Color.Maroon;
            this.erfAttemptedLabel.Location = new System.Drawing.Point(299, 391);
            this.erfAttemptedLabel.Name = "erfAttemptedLabel";
            this.erfAttemptedLabel.Size = new System.Drawing.Size(110, 24);
            this.erfAttemptedLabel.TabIndex = 13;
            this.erfAttemptedLabel.Text = "Attempted:";
            this.erfAttemptedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // erfCorrectTxtBx
            // 
            this.erfCorrectTxtBx.Enabled = false;
            this.erfCorrectTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfCorrectTxtBx.ForeColor = System.Drawing.Color.Maroon;
            this.erfCorrectTxtBx.Location = new System.Drawing.Point(429, 308);
            this.erfCorrectTxtBx.Name = "erfCorrectTxtBx";
            this.erfCorrectTxtBx.ReadOnly = true;
            this.erfCorrectTxtBx.Size = new System.Drawing.Size(100, 29);
            this.erfCorrectTxtBx.TabIndex = 14;
            this.erfCorrectTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // erfIncorrectTxtBx
            // 
            this.erfIncorrectTxtBx.Enabled = false;
            this.erfIncorrectTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfIncorrectTxtBx.ForeColor = System.Drawing.Color.Maroon;
            this.erfIncorrectTxtBx.Location = new System.Drawing.Point(429, 352);
            this.erfIncorrectTxtBx.Name = "erfIncorrectTxtBx";
            this.erfIncorrectTxtBx.ReadOnly = true;
            this.erfIncorrectTxtBx.Size = new System.Drawing.Size(100, 29);
            this.erfIncorrectTxtBx.TabIndex = 15;
            this.erfIncorrectTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // erfAttemptedTxtBx
            // 
            this.erfAttemptedTxtBx.Enabled = false;
            this.erfAttemptedTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfAttemptedTxtBx.ForeColor = System.Drawing.Color.Maroon;
            this.erfAttemptedTxtBx.Location = new System.Drawing.Point(429, 391);
            this.erfAttemptedTxtBx.Name = "erfAttemptedTxtBx";
            this.erfAttemptedTxtBx.ReadOnly = true;
            this.erfAttemptedTxtBx.Size = new System.Drawing.Size(100, 29);
            this.erfAttemptedTxtBx.TabIndex = 16;
            this.erfAttemptedTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // erfHomeButton
            // 
            this.erfHomeButton.BackColor = System.Drawing.Color.Maroon;
            this.erfHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfHomeButton.ForeColor = System.Drawing.Color.Gold;
            this.erfHomeButton.Location = new System.Drawing.Point(704, 443);
            this.erfHomeButton.Name = "erfHomeButton";
            this.erfHomeButton.Size = new System.Drawing.Size(123, 47);
            this.erfHomeButton.TabIndex = 17;
            this.erfHomeButton.Text = "HOME";
            this.erfHomeButton.UseVisualStyleBackColor = false;
            this.erfHomeButton.Click += new System.EventHandler(this.erfHomeButton_Click);
            // 
            // ExamResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(863, 505);
            this.Controls.Add(this.erfHomeButton);
            this.Controls.Add(this.erfAttemptedTxtBx);
            this.Controls.Add(this.erfIncorrectTxtBx);
            this.Controls.Add(this.erfCorrectTxtBx);
            this.Controls.Add(this.erfAttemptedLabel);
            this.Controls.Add(this.erfIncorrectLabel);
            this.Controls.Add(this.erfCorrectLabel);
            this.Controls.Add(this.erfScoreTextBox);
            this.Controls.Add(this.erfHeadingGroupBox);
            this.Controls.Add(this.erfMainMenuStrip);
            this.Name = "ExamResultsForm";
            this.Text = "ExamResultsForm";
            this.erfMainMenuStrip.ResumeLayout(false);
            this.erfMainMenuStrip.PerformLayout();
            this.erfHeadingGroupBox.ResumeLayout(false);
            this.erfHeadingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip erfMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label erfTimeLabel;
        private System.Windows.Forms.Label erfNameLabel;
        private System.Windows.Forms.GroupBox erfHeadingGroupBox;
        private System.Windows.Forms.Label srfResultsLabel;
        private System.Windows.Forms.TextBox erfScoreTextBox;
        private System.Windows.Forms.TextBox erfTimeTextBx;
        private System.Windows.Forms.Label erfCorrectLabel;
        private System.Windows.Forms.Label erfIncorrectLabel;
        private System.Windows.Forms.Label erfAttemptedLabel;
        private System.Windows.Forms.TextBox erfCorrectTxtBx;
        private System.Windows.Forms.TextBox erfIncorrectTxtBx;
        private System.Windows.Forms.TextBox erfAttemptedTxtBx;
        private System.Windows.Forms.TextBox erfTestIDTextBx;
        private System.Windows.Forms.Label erfTestIDLabel;
        private System.Windows.Forms.Button erfHomeButton;
    }
}