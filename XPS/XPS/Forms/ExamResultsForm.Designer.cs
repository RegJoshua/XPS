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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.erfTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.erfNameLabe = new System.Windows.Forms.Label();
            this.erfCategoryLabel = new System.Windows.Forms.Label();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.srfResultsLabel = new System.Windows.Forms.Label();
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
            this.erfHeadingGroupBox.Controls.Add(this.srfResultsLabel);
            this.erfHeadingGroupBox.Controls.Add(this.pictureBox1);
            this.erfHeadingGroupBox.Controls.Add(this.erfTimeLabel);
            this.erfHeadingGroupBox.Controls.Add(this.label3);
            this.erfHeadingGroupBox.Controls.Add(this.erfNameLabe);
            this.erfHeadingGroupBox.Controls.Add(this.erfCategoryLabel);
            this.erfHeadingGroupBox.Controls.Add(this.userTypeLabel);
            this.erfHeadingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfHeadingGroupBox.ForeColor = System.Drawing.Color.Gold;
            this.erfHeadingGroupBox.Location = new System.Drawing.Point(0, 36);
            this.erfHeadingGroupBox.Name = "erfHeadingGroupBox";
            this.erfHeadingGroupBox.Size = new System.Drawing.Size(863, 140);
            this.erfHeadingGroupBox.TabIndex = 9;
            this.erfHeadingGroupBox.TabStop = false;
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
            this.erfTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfTimeLabel.ForeColor = System.Drawing.Color.Gold;
            this.erfTimeLabel.Location = new System.Drawing.Point(31, 96);
            this.erfTimeLabel.Name = "erfTimeLabel";
            this.erfTimeLabel.Size = new System.Drawing.Size(42, 16);
            this.erfTimeLabel.TabIndex = 14;
            this.erfTimeLabel.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(99, 96);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "The Time";
            // 
            // erfNameLabe
            // 
            this.erfNameLabe.AutoSize = true;
            this.erfNameLabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfNameLabe.ForeColor = System.Drawing.Color.Gold;
            this.erfNameLabe.Location = new System.Drawing.Point(30, 32);
            this.erfNameLabe.Name = "erfNameLabe";
            this.erfNameLabe.Size = new System.Drawing.Size(145, 25);
            this.erfNameLabe.TabIndex = 13;
            this.erfNameLabe.Text = "Raul Escatel";
            // 
            // erfCategoryLabel
            // 
            this.erfCategoryLabel.AutoSize = true;
            this.erfCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erfCategoryLabel.ForeColor = System.Drawing.Color.Gold;
            this.erfCategoryLabel.Location = new System.Drawing.Point(31, 65);
            this.erfCategoryLabel.Name = "erfCategoryLabel";
            this.erfCategoryLabel.Size = new System.Drawing.Size(66, 16);
            this.erfCategoryLabel.TabIndex = 4;
            this.erfCategoryLabel.Text = "Category:";
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.BackColor = System.Drawing.Color.White;
            this.userTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.userTypeLabel.Location = new System.Drawing.Point(99, 65);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.userTypeLabel.TabIndex = 6;
            this.userTypeLabel.Text = "Categories?";
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
            // ExamResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(863, 492);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label erfNameLabe;
        private System.Windows.Forms.Label erfCategoryLabel;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.GroupBox erfHeadingGroupBox;
        private System.Windows.Forms.Label srfResultsLabel;
    }
}