namespace XPS.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginMenuStrip = new System.Windows.Forms.MenuStrip();
            this.msuLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.underLabel = new System.Windows.Forms.Label();
            this.boxPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.boxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginMenuStrip
            // 
            this.loginMenuStrip.BackColor = System.Drawing.Color.Maroon;
            this.loginMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.loginMenuStrip.Name = "loginMenuStrip";
            this.loginMenuStrip.Size = new System.Drawing.Size(615, 24);
            this.loginMenuStrip.TabIndex = 0;
            this.loginMenuStrip.Text = "loginMenuStrip";
            // 
            // msuLabel
            // 
            this.msuLabel.AutoSize = true;
            this.msuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msuLabel.ForeColor = System.Drawing.Color.Maroon;
            this.msuLabel.Location = new System.Drawing.Point(161, 68);
            this.msuLabel.Name = "msuLabel";
            this.msuLabel.Size = new System.Drawing.Size(291, 29);
            this.msuLabel.TabIndex = 1;
            this.msuLabel.Text = "MSU Computer Science";
            this.msuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(249, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exit Exam";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginLabel.Location = new System.Drawing.Point(197, 179);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(53, 20);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login";
            // 
            // underLabel
            // 
            this.underLabel.AutoSize = true;
            this.underLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.underLabel.Location = new System.Drawing.Point(213, 199);
            this.underLabel.Name = "underLabel";
            this.underLabel.Size = new System.Drawing.Size(163, 13);
            this.underLabel.TabIndex = 4;
            this.underLabel.Text = "__________________________";
            // 
            // boxPanel
            // 
            this.boxPanel.Controls.Add(this.loginButton);
            this.boxPanel.Controls.Add(this.passwordBox);
            this.boxPanel.Controls.Add(this.passwordLabel);
            this.boxPanel.Controls.Add(this.usernameBox);
            this.boxPanel.Controls.Add(this.usernameLabel);
            this.boxPanel.Location = new System.Drawing.Point(201, 234);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(230, 214);
            this.boxPanel.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Maroon;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(104, 134);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(35, 73);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(144, 20);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordLabel.Location = new System.Drawing.Point(32, 57);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(35, 16);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(144, 20);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameBox_KeyDown);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(32, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(615, 502);
            this.Controls.Add(this.boxPanel);
            this.Controls.Add(this.underLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msuLabel);
            this.Controls.Add(this.loginMenuStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.loginMenuStrip;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XPS - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.boxPanel.ResumeLayout(false);
            this.boxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip loginMenuStrip;
        private System.Windows.Forms.Label msuLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label underLabel;
        private System.Windows.Forms.Panel boxPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label usernameLabel;
    }
}