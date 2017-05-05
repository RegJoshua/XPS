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
        //The user using XPS.
        private User thisUser;
        private DatabaseManager db = null;
        //Stores all of the userIDs and User Names. 
        private Dictionary<int, string> names = null;

        public ReportsForm(User adminUser)
        {
            thisUser = adminUser;
            InitializeComponent();
            db = new DatabaseManager();
            names = db.GetUserList();
        }

        /// <summary>
        /// This method populates the Users Combo Box with the Users from the database.
        /// </summary>
        private void FillUserComboBox()
        {
            Dictionary<int, string> names = db.GetUserList();

            foreach (string name in names.Values)
            {
                usersComboBox.Items.Add(name);
            }
        }

        /// <summary>
        /// This method is called whenever a new report is selected from the combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the user is running the Individual Student Results report, they are able
            //to select a user.
            if (reportsComboBox.SelectedItem.ToString() == "Individual Student Results")
            {
                userSelectionLabel.Visible = true;
                usersComboBox.Visible = true;

                FillUserComboBox();
            }
            else
            {
                userSelectionLabel.Visible = false;
                usersComboBox.Visible = false;
            }
               
        }


        /// <summary>
        /// This button runs the report. It receives a Dataset object from the dbManager 
        /// and uses it to populate a DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runReportButton_Click(object sender, EventArgs e)
        {
            string reportName ="";
            string queryString = "";
            int userID = 0;
            DataSet dataSet = null;

            //If the user failed to select a report. 
            if (reportsComboBox.SelectedItem != null)
            {
                reportName = reportsComboBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a report to run.");
            }

            //If the report user selects the individual student results report.
            if (reportName == "Individual Student Results")
            {
                //Finds the UserID.
                if (usersComboBox.SelectedItem != null)
                {
                    foreach (KeyValuePair<int, string> pair in names)
                    {
                        if (pair.Value == usersComboBox.SelectedItem.ToString())
                        {
                            userID = pair.Key;
                        }
                    }

                    //Formats the query string for the specific user.
                    queryString = String.Format(Queries.REPORT_INDIVIDUAL_STUDENT_RESULTS, userID);
                    //Gets the dataset from the dbManager.
                    dataSet = db.RunReport(queryString);
                }
                else
                {
                    MessageBox.Show("Please select a user.");

                }
            }

            //If the user selects the Test History report.
            else if (reportName == "Test History")
            {
                queryString = Queries.REPORT_TEST_HISTORY;
                //Gets the dataset from the dbManager.
                dataSet = db.RunReport(queryString);
            }

            //If the user selects the Results by Category report.
            else if (reportName == "Results by Category")
            {
                queryString = Queries.REPORT_RESULTS_BY_CATEGORY;
                //Gets the dataset from the dbManager.
                dataSet = db.RunReport(queryString);
            }

            //Binds the datagridview to the dataset.
            if(dataSet != null) reportDataGridView.DataSource = dataSet.Tables[0];
        }

        private void ReportsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Returns to the admin form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arfAdminMenuBtn_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm(thisUser);
            af.Show();
            this.Hide();
        }
    }
}
