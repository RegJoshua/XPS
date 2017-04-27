namespace XPS.Forms
{
    partial class ReportsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportsComboBox = new System.Windows.Forms.ComboBox();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.reportSelectionLabel = new System.Windows.Forms.Label();
            this.userSelectionLabel = new System.Windows.Forms.Label();
            this.runReportButton = new System.Windows.Forms.Button();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(162, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Reports";
            // 
            // reportsComboBox
            // 
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.Items.AddRange(new object[] {
            "Individual Student Results",
            "Student Results by Category",
            "Test History"});
            this.reportsComboBox.Location = new System.Drawing.Point(87, 122);
            this.reportsComboBox.Name = "reportsComboBox";
            this.reportsComboBox.Size = new System.Drawing.Size(289, 21);
            this.reportsComboBox.TabIndex = 1;
            this.reportsComboBox.SelectedIndexChanged += new System.EventHandler(this.reportsComboBox_SelectedIndexChanged);
            // 
            // usersComboBox
            // 
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(87, 162);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(289, 21);
            this.usersComboBox.TabIndex = 2;
            this.usersComboBox.Visible = false;
            // 
            // reportSelectionLabel
            // 
            this.reportSelectionLabel.AutoSize = true;
            this.reportSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportSelectionLabel.Location = new System.Drawing.Point(12, 122);
            this.reportSelectionLabel.Name = "reportSelectionLabel";
            this.reportSelectionLabel.Size = new System.Drawing.Size(62, 20);
            this.reportSelectionLabel.TabIndex = 3;
            this.reportSelectionLabel.Text = "Report:";
            // 
            // userSelectionLabel
            // 
            this.userSelectionLabel.AutoSize = true;
            this.userSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSelectionLabel.Location = new System.Drawing.Point(12, 162);
            this.userSelectionLabel.Name = "userSelectionLabel";
            this.userSelectionLabel.Size = new System.Drawing.Size(47, 20);
            this.userSelectionLabel.TabIndex = 4;
            this.userSelectionLabel.Text = "User:";
            this.userSelectionLabel.Visible = false;
            // 
            // runReportButton
            // 
            this.runReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runReportButton.Location = new System.Drawing.Point(430, 119);
            this.runReportButton.Name = "runReportButton";
            this.runReportButton.Size = new System.Drawing.Size(172, 64);
            this.runReportButton.TabIndex = 5;
            this.runReportButton.Text = "Run Report";
            this.runReportButton.UseVisualStyleBackColor = true;
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(16, 203);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.Size = new System.Drawing.Size(586, 286);
            this.reportDataGridView.TabIndex = 6;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(614, 501);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.runReportButton);
            this.Controls.Add(this.userSelectionLabel);
            this.Controls.Add(this.reportSelectionLabel);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.reportsComboBox);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox reportsComboBox;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Label reportSelectionLabel;
        private System.Windows.Forms.Label userSelectionLabel;
        private System.Windows.Forms.Button runReportButton;
        private System.Windows.Forms.DataGridView reportDataGridView;
    }
}