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
            this.components = new System.ComponentModel.Container();
            this.examUserLabel = new System.Windows.Forms.Label();
            this.testIDLabel = new System.Windows.Forms.Label();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.answer5RadioButton = new System.Windows.Forms.RadioButton();
            this.answer4RadioButton = new System.Windows.Forms.RadioButton();
            this.answer3RadioButton = new System.Windows.Forms.RadioButton();
            this.answer2RadioButton = new System.Windows.Forms.RadioButton();
            this.answer1RadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveQuestionButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.examMenuStrip = new System.Windows.Forms.MenuStrip();
            this.navGroupBox = new System.Windows.Forms.GroupBox();
            this.catLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.remainLabel = new System.Windows.Forms.Label();
            this.cdLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.questionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // examUserLabel
            // 
            this.examUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.examUserLabel.AutoSize = true;
            this.examUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examUserLabel.Location = new System.Drawing.Point(12, 609);
            this.examUserLabel.Name = "examUserLabel";
            this.examUserLabel.Size = new System.Drawing.Size(51, 20);
            this.examUserLabel.TabIndex = 0;
            this.examUserLabel.Text = "User: ";
            // 
            // testIDLabel
            // 
            this.testIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.testIDLabel.AutoSize = true;
            this.testIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testIDLabel.Location = new System.Drawing.Point(1026, 609);
            this.testIDLabel.Name = "testIDLabel";
            this.testIDLabel.Size = new System.Drawing.Size(69, 20);
            this.testIDLabel.TabIndex = 1;
            this.testIDLabel.Text = "Test ID: ";
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionGroupBox.Controls.Add(this.answer5RadioButton);
            this.questionGroupBox.Controls.Add(this.answer4RadioButton);
            this.questionGroupBox.Controls.Add(this.answer3RadioButton);
            this.questionGroupBox.Controls.Add(this.answer2RadioButton);
            this.questionGroupBox.Controls.Add(this.answer1RadioButton);
            this.questionGroupBox.Controls.Add(this.pictureBox1);
            this.questionGroupBox.Controls.Add(this.saveQuestionButton);
            this.questionGroupBox.Controls.Add(this.questionLabel);
            this.questionGroupBox.Location = new System.Drawing.Point(235, 120);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Size = new System.Drawing.Size(750, 448);
            this.questionGroupBox.TabIndex = 2;
            this.questionGroupBox.TabStop = false;
            // 
            // answer5RadioButton
            // 
            this.answer5RadioButton.AutoSize = true;
            this.answer5RadioButton.Location = new System.Drawing.Point(18, 402);
            this.answer5RadioButton.Name = "answer5RadioButton";
            this.answer5RadioButton.Size = new System.Drawing.Size(69, 17);
            this.answer5RadioButton.TabIndex = 7;
            this.answer5RadioButton.TabStop = true;
            this.answer5RadioButton.Text = "Answer 5";
            this.answer5RadioButton.UseVisualStyleBackColor = true;
            // 
            // answer4RadioButton
            // 
            this.answer4RadioButton.AutoSize = true;
            this.answer4RadioButton.Location = new System.Drawing.Point(18, 379);
            this.answer4RadioButton.Name = "answer4RadioButton";
            this.answer4RadioButton.Size = new System.Drawing.Size(69, 17);
            this.answer4RadioButton.TabIndex = 6;
            this.answer4RadioButton.TabStop = true;
            this.answer4RadioButton.Text = "Answer 4";
            this.answer4RadioButton.UseVisualStyleBackColor = true;
            // 
            // answer3RadioButton
            // 
            this.answer3RadioButton.AutoSize = true;
            this.answer3RadioButton.Location = new System.Drawing.Point(18, 356);
            this.answer3RadioButton.Name = "answer3RadioButton";
            this.answer3RadioButton.Size = new System.Drawing.Size(69, 17);
            this.answer3RadioButton.TabIndex = 5;
            this.answer3RadioButton.TabStop = true;
            this.answer3RadioButton.Text = "Answer 3";
            this.answer3RadioButton.UseVisualStyleBackColor = true;
            // 
            // answer2RadioButton
            // 
            this.answer2RadioButton.AutoSize = true;
            this.answer2RadioButton.Location = new System.Drawing.Point(18, 333);
            this.answer2RadioButton.Name = "answer2RadioButton";
            this.answer2RadioButton.Size = new System.Drawing.Size(69, 17);
            this.answer2RadioButton.TabIndex = 4;
            this.answer2RadioButton.TabStop = true;
            this.answer2RadioButton.Text = "Answer 2";
            this.answer2RadioButton.UseVisualStyleBackColor = true;
            // 
            // answer1RadioButton
            // 
            this.answer1RadioButton.AutoSize = true;
            this.answer1RadioButton.Location = new System.Drawing.Point(18, 310);
            this.answer1RadioButton.Name = "answer1RadioButton";
            this.answer1RadioButton.Size = new System.Drawing.Size(69, 17);
            this.answer1RadioButton.TabIndex = 3;
            this.answer1RadioButton.TabStop = true;
            this.answer1RadioButton.Text = "Answer 1";
            this.answer1RadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(240, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 121);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // saveQuestionButton
            // 
            this.saveQuestionButton.BackColor = System.Drawing.Color.Maroon;
            this.saveQuestionButton.ForeColor = System.Drawing.Color.White;
            this.saveQuestionButton.Location = new System.Drawing.Point(652, 402);
            this.saveQuestionButton.Name = "saveQuestionButton";
            this.saveQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.saveQuestionButton.TabIndex = 1;
            this.saveQuestionButton.Text = "Save";
            this.saveQuestionButton.UseVisualStyleBackColor = false;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(6, 16);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(734, 65);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "This question label will have the question.";
            // 
            // examMenuStrip
            // 
            this.examMenuStrip.BackColor = System.Drawing.Color.Maroon;
            this.examMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.examMenuStrip.Name = "examMenuStrip";
            this.examMenuStrip.Size = new System.Drawing.Size(1156, 24);
            this.examMenuStrip.TabIndex = 3;
            this.examMenuStrip.Text = "menuStrip1";
            // 
            // navGroupBox
            // 
            this.navGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.navGroupBox.Location = new System.Drawing.Point(35, 159);
            this.navGroupBox.Name = "navGroupBox";
            this.navGroupBox.Size = new System.Drawing.Size(194, 357);
            this.navGroupBox.TabIndex = 4;
            this.navGroupBox.TabStop = false;
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLabel.ForeColor = System.Drawing.Color.Maroon;
            this.catLabel.Location = new System.Drawing.Point(35, 37);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(101, 20);
            this.catLabel.TabIndex = 5;
            this.catLabel.Text = "Categories:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.dateLabel.Location = new System.Drawing.Point(38, 66);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(49, 16);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date: ";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextButton.BackColor = System.Drawing.Color.Maroon;
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(892, 575);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.previousButton.BackColor = System.Drawing.Color.Maroon;
            this.previousButton.ForeColor = System.Drawing.Color.White;
            this.previousButton.Location = new System.Drawing.Point(253, 575);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 8;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // remainLabel
            // 
            this.remainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remainLabel.AutoSize = true;
            this.remainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainLabel.ForeColor = System.Drawing.Color.Maroon;
            this.remainLabel.Location = new System.Drawing.Point(981, 136);
            this.remainLabel.Name = "remainLabel";
            this.remainLabel.Size = new System.Drawing.Size(163, 24);
            this.remainLabel.TabIndex = 9;
            this.remainLabel.Text = "Remaining Time";
            // 
            // cdLabel
            // 
            this.cdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cdLabel.AutoSize = true;
            this.cdLabel.Location = new System.Drawing.Point(1060, 188);
            this.cdLabel.Name = "cdLabel";
            this.cdLabel.Size = new System.Drawing.Size(60, 13);
            this.cdLabel.TabIndex = 10;
            this.cdLabel.Text = "countdown";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1156, 638);
            this.Controls.Add(this.cdLabel);
            this.Controls.Add(this.remainLabel);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.navGroupBox);
            this.Controls.Add(this.questionGroupBox);
            this.Controls.Add(this.testIDLabel);
            this.Controls.Add(this.examUserLabel);
            this.Controls.Add(this.examMenuStrip);
            this.MainMenuStrip = this.examMenuStrip;
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamForm_FormClosing);
            this.questionGroupBox.ResumeLayout(false);
            this.questionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label examUserLabel;
        private System.Windows.Forms.Label testIDLabel;
        private System.Windows.Forms.GroupBox questionGroupBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton answer5RadioButton;
        private System.Windows.Forms.RadioButton answer4RadioButton;
        private System.Windows.Forms.RadioButton answer3RadioButton;
        private System.Windows.Forms.RadioButton answer2RadioButton;
        private System.Windows.Forms.RadioButton answer1RadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveQuestionButton;
        private System.Windows.Forms.MenuStrip examMenuStrip;
        private System.Windows.Forms.GroupBox navGroupBox;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label remainLabel;
        private System.Windows.Forms.Label cdLabel;
        private System.Windows.Forms.Timer timer1;
    }
}