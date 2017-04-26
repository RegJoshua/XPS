namespace XPS.Forms
{
    partial class AdminForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.adminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.viewReportButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(122, 54);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(139, 18);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "firstName lastName";
            // 
            // adminMenuStrip
            // 
            this.adminMenuStrip.BackColor = System.Drawing.Color.Maroon;
            this.adminMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.adminMenuStrip.Name = "adminMenuStrip";
            this.adminMenuStrip.Size = new System.Drawing.Size(382, 24);
            this.adminMenuStrip.TabIndex = 1;
            this.adminMenuStrip.Text = "menuStrip1";
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.Location = new System.Drawing.Point(140, 137);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(110, 30);
            this.addUserButton.TabIndex = 2;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteUserButton.Location = new System.Drawing.Point(140, 173);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(110, 30);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // viewReportButton
            // 
            this.viewReportButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewReportButton.Location = new System.Drawing.Point(140, 209);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(110, 30);
            this.viewReportButton.TabIndex = 4;
            this.viewReportButton.Text = "View Reports";
            this.viewReportButton.UseVisualStyleBackColor = false;
            this.viewReportButton.Click += new System.EventHandler(this.viewReportButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainMenuButton.Location = new System.Drawing.Point(140, 245);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(110, 30);
            this.mainMenuButton.TabIndex = 5;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(382, 402);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.viewReportButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.adminMenuStrip);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.adminMenuStrip;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.MenuStrip adminMenuStrip;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button viewReportButton;
        private System.Windows.Forms.Button mainMenuButton;
    }
}