namespace XPS.Forms
{
    partial class AddUserForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.Label();
            this.aufLastNameBox = new System.Windows.Forms.TextBox();
            this.aufUserLabel = new System.Windows.Forms.Label();
            this.aufUserNameBox = new System.Windows.Forms.TextBox();
            this.aufPassLabel = new System.Windows.Forms.Label();
            this.aufPasswordBox = new System.Windows.Forms.TextBox();
            this.aufMustangLabel = new System.Windows.Forms.Label();
            this.aufMustangBox = new System.Windows.Forms.TextBox();
            this.aufUserTypeBox = new System.Windows.Forms.GroupBox();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.aufAddUserButton = new System.Windows.Forms.Button();
            this.aufCancelButton = new System.Windows.Forms.Button();
            this.adminMenuButton = new System.Windows.Forms.Button();
            this.aufUserTypeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(81, 24);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(85, 40);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(203, 20);
            this.firstNameBox.TabIndex = 1;
            // 
            // lastNameBox
            // 
            this.lastNameBox.AutoSize = true;
            this.lastNameBox.Location = new System.Drawing.Point(80, 73);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(58, 13);
            this.lastNameBox.TabIndex = 2;
            this.lastNameBox.Text = "Last Name";
            // 
            // aufLastNameBox
            // 
            this.aufLastNameBox.Location = new System.Drawing.Point(83, 89);
            this.aufLastNameBox.Name = "aufLastNameBox";
            this.aufLastNameBox.Size = new System.Drawing.Size(203, 20);
            this.aufLastNameBox.TabIndex = 3;
            // 
            // aufUserLabel
            // 
            this.aufUserLabel.AutoSize = true;
            this.aufUserLabel.Location = new System.Drawing.Point(82, 121);
            this.aufUserLabel.Name = "aufUserLabel";
            this.aufUserLabel.Size = new System.Drawing.Size(60, 13);
            this.aufUserLabel.TabIndex = 4;
            this.aufUserLabel.Text = "User Name";
            // 
            // aufUserNameBox
            // 
            this.aufUserNameBox.Location = new System.Drawing.Point(83, 137);
            this.aufUserNameBox.Name = "aufUserNameBox";
            this.aufUserNameBox.Size = new System.Drawing.Size(203, 20);
            this.aufUserNameBox.TabIndex = 5;
            // 
            // aufPassLabel
            // 
            this.aufPassLabel.AutoSize = true;
            this.aufPassLabel.Location = new System.Drawing.Point(81, 170);
            this.aufPassLabel.Name = "aufPassLabel";
            this.aufPassLabel.Size = new System.Drawing.Size(53, 13);
            this.aufPassLabel.TabIndex = 6;
            this.aufPassLabel.Text = "Password";
            // 
            // aufPasswordBox
            // 
            this.aufPasswordBox.Location = new System.Drawing.Point(84, 186);
            this.aufPasswordBox.Name = "aufPasswordBox";
            this.aufPasswordBox.Size = new System.Drawing.Size(203, 20);
            this.aufPasswordBox.TabIndex = 7;
            // 
            // aufMustangLabel
            // 
            this.aufMustangLabel.AutoSize = true;
            this.aufMustangLabel.Location = new System.Drawing.Point(82, 220);
            this.aufMustangLabel.Name = "aufMustangLabel";
            this.aufMustangLabel.Size = new System.Drawing.Size(62, 13);
            this.aufMustangLabel.TabIndex = 8;
            this.aufMustangLabel.Text = "Mustang ID";
            // 
            // aufMustangBox
            // 
            this.aufMustangBox.Location = new System.Drawing.Point(83, 236);
            this.aufMustangBox.Name = "aufMustangBox";
            this.aufMustangBox.Size = new System.Drawing.Size(203, 20);
            this.aufMustangBox.TabIndex = 9;
            // 
            // aufUserTypeBox
            // 
            this.aufUserTypeBox.Controls.Add(this.adminRadioButton);
            this.aufUserTypeBox.Controls.Add(this.studentRadioButton);
            this.aufUserTypeBox.Location = new System.Drawing.Point(83, 262);
            this.aufUserTypeBox.Name = "aufUserTypeBox";
            this.aufUserTypeBox.Size = new System.Drawing.Size(200, 73);
            this.aufUserTypeBox.TabIndex = 10;
            this.aufUserTypeBox.TabStop = false;
            this.aufUserTypeBox.Text = "User Type";
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Location = new System.Drawing.Point(7, 44);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(54, 17);
            this.adminRadioButton.TabIndex = 1;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(7, 20);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(62, 17);
            this.studentRadioButton.TabIndex = 0;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // aufAddUserButton
            // 
            this.aufAddUserButton.Location = new System.Drawing.Point(83, 350);
            this.aufAddUserButton.Name = "aufAddUserButton";
            this.aufAddUserButton.Size = new System.Drawing.Size(95, 30);
            this.aufAddUserButton.TabIndex = 11;
            this.aufAddUserButton.Text = "Add";
            this.aufAddUserButton.UseVisualStyleBackColor = true;
            this.aufAddUserButton.Click += new System.EventHandler(this.aufAddUserButton_Click);
            // 
            // aufCancelButton
            // 
            this.aufCancelButton.Location = new System.Drawing.Point(188, 350);
            this.aufCancelButton.Name = "aufCancelButton";
            this.aufCancelButton.Size = new System.Drawing.Size(95, 30);
            this.aufCancelButton.TabIndex = 12;
            this.aufCancelButton.Text = "Cancel";
            this.aufCancelButton.UseVisualStyleBackColor = true;
            // 
            // adminMenuButton
            // 
            this.adminMenuButton.Location = new System.Drawing.Point(299, 371);
            this.adminMenuButton.Name = "adminMenuButton";
            this.adminMenuButton.Size = new System.Drawing.Size(75, 23);
            this.adminMenuButton.TabIndex = 13;
            this.adminMenuButton.Text = "Admin Menu";
            this.adminMenuButton.UseVisualStyleBackColor = true;
            this.adminMenuButton.Click += new System.EventHandler(this.adminMenuButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(375, 397);
            this.Controls.Add(this.adminMenuButton);
            this.Controls.Add(this.aufCancelButton);
            this.Controls.Add(this.aufAddUserButton);
            this.Controls.Add(this.aufUserTypeBox);
            this.Controls.Add(this.aufMustangBox);
            this.Controls.Add(this.aufMustangLabel);
            this.Controls.Add(this.aufPasswordBox);
            this.Controls.Add(this.aufPassLabel);
            this.Controls.Add(this.aufUserNameBox);
            this.Controls.Add(this.aufUserLabel);
            this.Controls.Add(this.aufLastNameBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.firstNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUserForm_FormClosing);
            this.aufUserTypeBox.ResumeLayout(false);
            this.aufUserTypeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label lastNameBox;
        private System.Windows.Forms.TextBox aufLastNameBox;
        private System.Windows.Forms.Label aufUserLabel;
        private System.Windows.Forms.TextBox aufUserNameBox;
        private System.Windows.Forms.Label aufPassLabel;
        private System.Windows.Forms.TextBox aufPasswordBox;
        private System.Windows.Forms.Label aufMustangLabel;
        private System.Windows.Forms.TextBox aufMustangBox;
        private System.Windows.Forms.GroupBox aufUserTypeBox;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.Button aufAddUserButton;
        private System.Windows.Forms.Button aufCancelButton;
        private System.Windows.Forms.Button adminMenuButton;
    }
}