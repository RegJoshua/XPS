using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XPS.Logic;
using XPS.Models;

namespace XPS.Forms
{
    public partial class ReportsForm : Form
    {
        User thisUser;
        private DatabaseManager db = null;
        private Dictionary<int, string> names = null;

        public ReportsForm(User adminUser)
        {
            thisUser = adminUser;
            InitializeComponent();
            db = new DatabaseManager();
            names = db.GetUserList();
        }

        private void FillUserComboBox()
        {
            Dictionary<int, string> names = db.GetUserList();

            foreach (string name in names.Values)
            {
                usersComboBox.Items.Add(name);
            }
        }

        private void reportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportsComboBox.SelectedItem.ToString() == "Individual Student Results")
            {
                userSelectionLabel.Visible = true;
                usersComboBox.Visible = true;

                FillUserComboBox();
            }
            //else
            //{
            //    userSelectionLabel.Visible = false;
            //    usersComboBox.Visible = false;
            //}
               
        }

        private void runReportButton_Click(object sender, EventArgs e)
        {
            string reportName ="";

            if(reportsComboBox.SelectedItem != null)
            {
                reportName = reportsComboBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a report to run.");
            }
            
            string queryString = "";
            int userID = 0;
            DataSet dataSet = null;

            if (reportName == "Individual Student Results")
            {
                if (usersComboBox.SelectedItem != null)
                {
                    foreach (KeyValuePair<int, string> pair in names)
                    {
                        if (pair.Value == usersComboBox.SelectedItem.ToString())
                        {
                            userID = pair.Key;
                        }
                    }

                    queryString = String.Format(Queries.REPORT_INDIVIDUAL_STUDENT_RESULTS, userID);
                    dataSet = db.RunReport(queryString);
                }
                else
                {
                    MessageBox.Show("Please select a user.");

                }
            }

            else if (reportName == "Test History")
            {
                queryString = Queries.REPORT_TEST_HISTORY;
                dataSet = db.RunReport(queryString);
            }

            else if (reportName == "Results by Category")
            {
                queryString = Queries.REPORT_RESULTS_BY_CATEGORY;
                dataSet = db.RunReport(queryString);
            }

            if(dataSet != null) reportDataGridView.DataSource = dataSet.Tables[0];
        }

        private void ReportsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void arfAdminMenuBtn_Click(object sender, EventArgs e)
        {
            
            AdminForm af = new AdminForm(thisUser);
            af.Show();
            this.Hide();
        }
    }
}
