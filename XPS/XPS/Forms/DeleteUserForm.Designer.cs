namespace XPS.Forms
{
    partial class DeleteUserForm
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
            this.dMustangIDLabel = new System.Windows.Forms.Label();
            this.dFirstnameLabel = new System.Windows.Forms.Label();
            this.dLastnameLabel = new System.Windows.Forms.Label();
            this.dMustangBox = new System.Windows.Forms.TextBox();
            this.dFirstnameBox = new System.Windows.Forms.TextBox();
            this.dLastnameBox = new System.Windows.Forms.TextBox();
            this.dVerifyBox = new System.Windows.Forms.TextBox();
            this.dGetUserButton = new System.Windows.Forms.Button();
            this.dDeleteUserButton = new System.Windows.Forms.Button();
            this.dAdminMenu = new System.Windows.Forms.Button();
            this.dCancelButton = new System.Windows.Forms.Button();
            this.dInstructionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dMustangIDLabel
            // 
            this.dMustangIDLabel.AutoSize = true;
            this.dMustangIDLabel.Location = new System.Drawing.Point(55, 32);
            this.dMustangIDLabel.Name = "dMustangIDLabel";
            this.dMustangIDLabel.Size = new System.Drawing.Size(62, 13);
            this.dMustangIDLabel.TabIndex = 0;
            this.dMustangIDLabel.Text = "Mustang ID";
            // 
            // dFirstnameLabel
            // 
            this.dFirstnameLabel.AutoSize = true;
            this.dFirstnameLabel.Location = new System.Drawing.Point(56, 91);
            this.dFirstnameLabel.Name = "dFirstnameLabel";
            this.dFirstnameLabel.Size = new System.Drawing.Size(57, 13);
            this.dFirstnameLabel.TabIndex = 1;
            this.dFirstnameLabel.Text = "First Name";
            this.dFirstnameLabel.Visible = false;
            // 
            // dLastnameLabel
            // 
            this.dLastnameLabel.AutoSize = true;
            this.dLastnameLabel.Location = new System.Drawing.Point(56, 147);
            this.dLastnameLabel.Name = "dLastnameLabel";
            this.dLastnameLabel.Size = new System.Drawing.Size(58, 13);
            this.dLastnameLabel.TabIndex = 2;
            this.dLastnameLabel.Text = "Last Name";
            this.dLastnameLabel.Visible = false;
            // 
            // dMustangBox
            // 
            this.dMustangBox.Location = new System.Drawing.Point(58, 48);
            this.dMustangBox.Name = "dMustangBox";
            this.dMustangBox.Size = new System.Drawing.Size(203, 20);
            this.dMustangBox.TabIndex = 3;
            // 
            // dFirstnameBox
            // 
            this.dFirstnameBox.Location = new System.Drawing.Point(58, 107);
            this.dFirstnameBox.Name = "dFirstnameBox";
            this.dFirstnameBox.Size = new System.Drawing.Size(203, 20);
            this.dFirstnameBox.TabIndex = 4;
            this.dFirstnameBox.Visible = false;
            // 
            // dLastnameBox
            // 
            this.dLastnameBox.Location = new System.Drawing.Point(58, 163);
            this.dLastnameBox.Name = "dLastnameBox";
            this.dLastnameBox.Size = new System.Drawing.Size(203, 20);
            this.dLastnameBox.TabIndex = 5;
            this.dLastnameBox.Visible = false;
            // 
            // dVerifyBox
            // 
            this.dVerifyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dVerifyBox.Location = new System.Drawing.Point(58, 201);
            this.dVerifyBox.Multiline = true;
            this.dVerifyBox.Name = "dVerifyBox";
            this.dVerifyBox.ReadOnly = true;
            this.dVerifyBox.Size = new System.Drawing.Size(203, 82);
            this.dVerifyBox.TabIndex = 6;
            this.dVerifyBox.Text = "If this is the user  to delete, click the \"Delete User\" button. Otherwise, click " +
    "the \"Cancel\" button.";
            this.dVerifyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dVerifyBox.Visible = false;
            // 
            // dGetUserButton
            // 
            this.dGetUserButton.BackColor = System.Drawing.Color.Maroon;
            this.dGetUserButton.ForeColor = System.Drawing.Color.White;
            this.dGetUserButton.Location = new System.Drawing.Point(58, 290);
            this.dGetUserButton.Name = "dGetUserButton";
            this.dGetUserButton.Size = new System.Drawing.Size(75, 23);
            this.dGetUserButton.TabIndex = 7;
            this.dGetUserButton.Text = "Get User";
            this.dGetUserButton.UseVisualStyleBackColor = false;
            this.dGetUserButton.Click += new System.EventHandler(this.dGetUserButton_Click);
            // 
            // dDeleteUserButton
            // 
            this.dDeleteUserButton.BackColor = System.Drawing.Color.Maroon;
            this.dDeleteUserButton.ForeColor = System.Drawing.Color.White;
            this.dDeleteUserButton.Location = new System.Drawing.Point(186, 289);
            this.dDeleteUserButton.Name = "dDeleteUserButton";
            this.dDeleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.dDeleteUserButton.TabIndex = 8;
            this.dDeleteUserButton.Text = "Delete User";
            this.dDeleteUserButton.UseVisualStyleBackColor = false;
            this.dDeleteUserButton.Visible = false;
            this.dDeleteUserButton.Click += new System.EventHandler(this.dDeleteUserButton_Click);
            // 
            // dAdminMenu
            // 
            this.dAdminMenu.BackColor = System.Drawing.Color.Maroon;
            this.dAdminMenu.ForeColor = System.Drawing.Color.White;
            this.dAdminMenu.Location = new System.Drawing.Point(58, 320);
            this.dAdminMenu.Name = "dAdminMenu";
            this.dAdminMenu.Size = new System.Drawing.Size(75, 23);
            this.dAdminMenu.TabIndex = 9;
            this.dAdminMenu.Text = "Admin Menu";
            this.dAdminMenu.UseVisualStyleBackColor = false;
            this.dAdminMenu.Click += new System.EventHandler(this.dAdminMenu_Click);
            // 
            // dCancelButton
            // 
            this.dCancelButton.BackColor = System.Drawing.Color.Maroon;
            this.dCancelButton.ForeColor = System.Drawing.Color.White;
            this.dCancelButton.Location = new System.Drawing.Point(186, 320);
            this.dCancelButton.Name = "dCancelButton";
            this.dCancelButton.Size = new System.Drawing.Size(75, 23);
            this.dCancelButton.TabIndex = 10;
            this.dCancelButton.Text = "Cancel";
            this.dCancelButton.UseVisualStyleBackColor = false;
            this.dCancelButton.Click += new System.EventHandler(this.dCancelButton_Click);
            // 
            // dInstructionBox
            // 
            this.dInstructionBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dInstructionBox.Location = new System.Drawing.Point(58, 79);
            this.dInstructionBox.Multiline = true;
            this.dInstructionBox.Name = "dInstructionBox";
            this.dInstructionBox.ReadOnly = true;
            this.dInstructionBox.Size = new System.Drawing.Size(203, 104);
            this.dInstructionBox.TabIndex = 11;
            this.dInstructionBox.Text = "To delete a user, first enter the MustangID, without the \'M\' prefix, in the Musta" +
    "ngID box. Then click \"Get User\" to display the user\'s name.";
            this.dInstructionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(323, 366);
            this.Controls.Add(this.dInstructionBox);
            this.Controls.Add(this.dCancelButton);
            this.Controls.Add(this.dAdminMenu);
            this.Controls.Add(this.dDeleteUserButton);
            this.Controls.Add(this.dGetUserButton);
            this.Controls.Add(this.dVerifyBox);
            this.Controls.Add(this.dLastnameBox);
            this.Controls.Add(this.dFirstnameBox);
            this.Controls.Add(this.dMustangBox);
            this.Controls.Add(this.dLastnameLabel);
            this.Controls.Add(this.dFirstnameLabel);
            this.Controls.Add(this.dMustangIDLabel);
            this.Name = "DeleteUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleterUserForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dMustangIDLabel;
        private System.Windows.Forms.Label dFirstnameLabel;
        private System.Windows.Forms.Label dLastnameLabel;
        private System.Windows.Forms.TextBox dMustangBox;
        private System.Windows.Forms.TextBox dFirstnameBox;
        private System.Windows.Forms.TextBox dLastnameBox;
        private System.Windows.Forms.TextBox dVerifyBox;
        private System.Windows.Forms.Button dGetUserButton;
        private System.Windows.Forms.Button dDeleteUserButton;
        private System.Windows.Forms.Button dAdminMenu;
        private System.Windows.Forms.Button dCancelButton;
        private System.Windows.Forms.TextBox dInstructionBox;
    }
}