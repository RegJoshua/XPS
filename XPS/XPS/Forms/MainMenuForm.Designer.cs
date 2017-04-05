namespace XPS
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.sideMenu = new System.Windows.Forms.SplitContainer();
            this.adminButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.takeTestButton = new System.Windows.Forms.Button();
            this.numGroupBox = new System.Windows.Forms.GroupBox();
            this.timedGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.catGroupBox = new System.Windows.Forms.GroupBox();
            this.imCheckBox = new System.Windows.Forms.CheckBox();
            this.seCheckBox = new System.Windows.Forms.CheckBox();
            this.sysCheckBox = new System.Windows.Forms.CheckBox();
            this.acCheckBox = new System.Windows.Forms.CheckBox();
            this.progCheckBox = new System.Windows.Forms.CheckBox();
            this.dsCheckBox = new System.Windows.Forms.CheckBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.questionComboBox = new System.Windows.Forms.ComboBox();
            this.generateTestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sideMenu)).BeginInit();
            this.sideMenu.Panel1.SuspendLayout();
            this.sideMenu.Panel2.SuspendLayout();
            this.sideMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.numGroupBox.SuspendLayout();
            this.timedGroupBox.SuspendLayout();
            this.catGroupBox.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sideMenu.IsSplitterFixed = true;
            this.sideMenu.Location = new System.Drawing.Point(0, 24);
            this.sideMenu.Name = "sideMenu";
            // 
            // sideMenu.Panel1
            // 
            this.sideMenu.Panel1.BackColor = System.Drawing.Color.Maroon;
            this.sideMenu.Panel1.Controls.Add(this.adminButton);
            this.sideMenu.Panel1.Controls.Add(this.groupBox1);
            this.sideMenu.Panel1.Controls.Add(this.pictureBox2);
            this.sideMenu.Panel1.Controls.Add(this.label4);
            this.sideMenu.Panel1.Controls.Add(this.homeButton);
            this.sideMenu.Panel1.Controls.Add(this.aboutButton);
            this.sideMenu.Panel1.Controls.Add(this.profileButton);
            this.sideMenu.Panel1.Controls.Add(this.takeTestButton);
            // 
            // sideMenu.Panel2
            // 
            this.sideMenu.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sideMenu.Panel2.Controls.Add(this.generateTestButton);
            this.sideMenu.Panel2.Controls.Add(this.numGroupBox);
            this.sideMenu.Panel2.Controls.Add(this.timedGroupBox);
            this.sideMenu.Panel2.Controls.Add(this.catGroupBox);
            this.sideMenu.Panel2.Controls.Add(this.dateLabel);
            this.sideMenu.Size = new System.Drawing.Size(689, 424);
            this.sideMenu.SplitterDistance = 181;
            this.sideMenu.TabIndex = 0;
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.Gold;
            this.adminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminButton.Location = new System.Drawing.Point(0, 218);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(178, 36);
            this.adminButton.TabIndex = 10;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userTypeLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(30, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(103, 18);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Raul Escatel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account Type:";
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.ForeColor = System.Drawing.Color.White;
            this.userTypeLabel.Location = new System.Drawing.Point(99, 70);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(44, 13);
            this.userTypeLabel.TabIndex = 6;
            this.userTypeLabel.Text = "Student";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(163, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Gold;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homeButton.Location = new System.Drawing.Point(0, 94);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(178, 36);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Gold;
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aboutButton.Location = new System.Drawing.Point(0, 272);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(178, 35);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Gold;
            this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profileButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profileButton.Location = new System.Drawing.Point(0, 176);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(178, 36);
            this.profileButton.TabIndex = 1;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            // 
            // takeTestButton
            // 
            this.takeTestButton.BackColor = System.Drawing.Color.Gold;
            this.takeTestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.takeTestButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.takeTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeTestButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.takeTestButton.Location = new System.Drawing.Point(0, 136);
            this.takeTestButton.Name = "takeTestButton";
            this.takeTestButton.Size = new System.Drawing.Size(178, 34);
            this.takeTestButton.TabIndex = 0;
            this.takeTestButton.Text = "Take Test";
            this.takeTestButton.UseVisualStyleBackColor = false;
            this.takeTestButton.Click += new System.EventHandler(this.takeTestButton_Click);
            // 
            // numGroupBox
            // 
            this.numGroupBox.Controls.Add(this.questionComboBox);
            this.numGroupBox.Location = new System.Drawing.Point(325, 24);
            this.numGroupBox.Name = "numGroupBox";
            this.numGroupBox.Size = new System.Drawing.Size(128, 67);
            this.numGroupBox.TabIndex = 12;
            this.numGroupBox.TabStop = false;
            this.numGroupBox.Text = "Number of Questions";
            // 
            // timedGroupBox
            // 
            this.timedGroupBox.Controls.Add(this.noRadioButton);
            this.timedGroupBox.Controls.Add(this.yesRadioButton);
            this.timedGroupBox.Location = new System.Drawing.Point(205, 24);
            this.timedGroupBox.Name = "timedGroupBox";
            this.timedGroupBox.Size = new System.Drawing.Size(80, 75);
            this.timedGroupBox.TabIndex = 11;
            this.timedGroupBox.TabStop = false;
            this.timedGroupBox.Text = "Timed";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(7, 43);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(39, 17);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(7, 20);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // catGroupBox
            // 
            this.catGroupBox.Controls.Add(this.imCheckBox);
            this.catGroupBox.Controls.Add(this.seCheckBox);
            this.catGroupBox.Controls.Add(this.sysCheckBox);
            this.catGroupBox.Controls.Add(this.acCheckBox);
            this.catGroupBox.Controls.Add(this.progCheckBox);
            this.catGroupBox.Controls.Add(this.dsCheckBox);
            this.catGroupBox.Location = new System.Drawing.Point(13, 24);
            this.catGroupBox.Name = "catGroupBox";
            this.catGroupBox.Size = new System.Drawing.Size(164, 188);
            this.catGroupBox.TabIndex = 10;
            this.catGroupBox.TabStop = false;
            this.catGroupBox.Text = "Categories";
            // 
            // imCheckBox
            // 
            this.imCheckBox.AutoSize = true;
            this.imCheckBox.Location = new System.Drawing.Point(6, 133);
            this.imCheckBox.Name = "imCheckBox";
            this.imCheckBox.Size = new System.Drawing.Size(143, 17);
            this.imCheckBox.TabIndex = 5;
            this.imCheckBox.Text = "Information Management";
            this.imCheckBox.UseVisualStyleBackColor = true;
            // 
            // seCheckBox
            // 
            this.seCheckBox.AutoSize = true;
            this.seCheckBox.Location = new System.Drawing.Point(6, 110);
            this.seCheckBox.Name = "seCheckBox";
            this.seCheckBox.Size = new System.Drawing.Size(127, 17);
            this.seCheckBox.TabIndex = 4;
            this.seCheckBox.Text = "Software Engineering";
            this.seCheckBox.UseVisualStyleBackColor = true;
            // 
            // sysCheckBox
            // 
            this.sysCheckBox.AutoSize = true;
            this.sysCheckBox.Location = new System.Drawing.Point(6, 87);
            this.sysCheckBox.Name = "sysCheckBox";
            this.sysCheckBox.Size = new System.Drawing.Size(65, 17);
            this.sysCheckBox.TabIndex = 3;
            this.sysCheckBox.Text = "Systems";
            this.sysCheckBox.UseVisualStyleBackColor = true;
            // 
            // acCheckBox
            // 
            this.acCheckBox.AutoSize = true;
            this.acCheckBox.Location = new System.Drawing.Point(6, 64);
            this.acCheckBox.Name = "acCheckBox";
            this.acCheckBox.Size = new System.Drawing.Size(148, 17);
            this.acCheckBox.TabIndex = 2;
            this.acCheckBox.Text = "Algorithms and Complexity";
            this.acCheckBox.UseVisualStyleBackColor = true;
            // 
            // progCheckBox
            // 
            this.progCheckBox.AutoSize = true;
            this.progCheckBox.Location = new System.Drawing.Point(6, 43);
            this.progCheckBox.Name = "progCheckBox";
            this.progCheckBox.Size = new System.Drawing.Size(87, 17);
            this.progCheckBox.TabIndex = 1;
            this.progCheckBox.Text = "Programming";
            this.progCheckBox.UseVisualStyleBackColor = true;
            // 
            // dsCheckBox
            // 
            this.dsCheckBox.AutoSize = true;
            this.dsCheckBox.Location = new System.Drawing.Point(7, 20);
            this.dsCheckBox.Name = "dsCheckBox";
            this.dsCheckBox.Size = new System.Drawing.Size(116, 17);
            this.dsCheckBox.TabIndex = 0;
            this.dsCheckBox.Text = "Discrete Structures";
            this.dsCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.dateLabel.Location = new System.Drawing.Point(362, 409);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(65, 12);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "currentDate";
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
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Maroon;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(689, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // questionComboBox
            // 
            this.questionComboBox.FormattingEnabled = true;
            this.questionComboBox.Items.AddRange(new object[] {
            "30",
            "45",
            "60"});
            this.questionComboBox.Location = new System.Drawing.Point(39, 20);
            this.questionComboBox.Name = "questionComboBox";
            this.questionComboBox.Size = new System.Drawing.Size(45, 21);
            this.questionComboBox.TabIndex = 0;
            // 
            // generateTestButton
            // 
            this.generateTestButton.BackColor = System.Drawing.Color.Maroon;
            this.generateTestButton.ForeColor = System.Drawing.Color.White;
            this.generateTestButton.Location = new System.Drawing.Point(364, 176);
            this.generateTestButton.Name = "generateTestButton";
            this.generateTestButton.Size = new System.Drawing.Size(90, 30);
            this.generateTestButton.TabIndex = 13;
            this.generateTestButton.Text = "Generate Test";
            this.generateTestButton.UseVisualStyleBackColor = false;
            this.generateTestButton.Click += new System.EventHandler(this.generateTestButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 448);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.sideMenu.Panel1.ResumeLayout(false);
            this.sideMenu.Panel1.PerformLayout();
            this.sideMenu.Panel2.ResumeLayout(false);
            this.sideMenu.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideMenu)).EndInit();
            this.sideMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.numGroupBox.ResumeLayout(false);
            this.timedGroupBox.ResumeLayout(false);
            this.timedGroupBox.PerformLayout();
            this.catGroupBox.ResumeLayout(false);
            this.catGroupBox.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer sideMenu;
        private System.Windows.Forms.Button takeTestButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.GroupBox timedGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.GroupBox catGroupBox;
        private System.Windows.Forms.CheckBox imCheckBox;
        private System.Windows.Forms.CheckBox seCheckBox;
        private System.Windows.Forms.CheckBox sysCheckBox;
        private System.Windows.Forms.CheckBox acCheckBox;
        private System.Windows.Forms.CheckBox progCheckBox;
        private System.Windows.Forms.CheckBox dsCheckBox;
        private System.Windows.Forms.GroupBox numGroupBox;
        private System.Windows.Forms.ComboBox questionComboBox;
        private System.Windows.Forms.Button generateTestButton;
    }
}

