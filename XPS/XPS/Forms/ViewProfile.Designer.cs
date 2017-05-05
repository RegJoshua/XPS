namespace XPS.Forms
{
    partial class ViewProfile
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
            this.vpWelcomeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vpMenuButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vpWelcomeLabel
            // 
            this.vpWelcomeLabel.AutoSize = true;
            this.vpWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpWelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.vpWelcomeLabel.Location = new System.Drawing.Point(170, 23);
            this.vpWelcomeLabel.Name = "vpWelcomeLabel";
            this.vpWelcomeLabel.Size = new System.Drawing.Size(110, 24);
            this.vpWelcomeLabel.TabIndex = 0;
            this.vpWelcomeLabel.Text = "Welcome, ";
            this.vpWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.vpWelcomeLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 72);
            this.panel1.TabIndex = 1;
            // 
            // vpMenuButton
            // 
            this.vpMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.vpMenuButton.BackColor = System.Drawing.Color.Maroon;
            this.vpMenuButton.ForeColor = System.Drawing.Color.White;
            this.vpMenuButton.Location = new System.Drawing.Point(229, 378);
            this.vpMenuButton.Name = "vpMenuButton";
            this.vpMenuButton.Size = new System.Drawing.Size(82, 32);
            this.vpMenuButton.TabIndex = 2;
            this.vpMenuButton.Text = "Main Menu";
            this.vpMenuButton.UseVisualStyleBackColor = false;
            this.vpMenuButton.Click += new System.EventHandler(this.vpMenuButton_Click);
            // 
            // ViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(550, 422);
            this.Controls.Add(this.vpMenuButton);
            this.Controls.Add(this.panel1);
            this.Name = "ViewProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label vpWelcomeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button vpMenuButton;
    }
}