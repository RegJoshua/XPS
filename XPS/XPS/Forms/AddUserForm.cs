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
    /**********************************************************************
     * 
     * class AddUserForm
     * Administrators add users to the database using this form.
     * 
    **********************************************************************/
    public partial class AddUserForm : Form
    {
        // a reference to the user's open admin form 
        private AdminForm _AdminForm = null;

        /**********************************************************************
         * 
         * constructor
         * @param: AdminForm anAdminForm
         * 
        **********************************************************************/
        public AddUserForm(AdminForm anAdminForm)
        {
            _AdminForm = anAdminForm;
            InitializeComponent();
        }

        /**********************************************************************
         * 
         * private void AddUserForm_FormClosing
         * @param: object sender, FormClosingEventArgs e
         * @return: NA
         * @closes this form and displays the Admin Form
         * 
        **********************************************************************/
        private void AddUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _AdminForm.Show();
        }

        /**********************************************************************
         * 
         * private void adminMenuButton_Click
         * @param: object sender, EventArgs e
         * @return: NA
         * @closes this form and displays the Admin Form
         * 
        **********************************************************************/
        private void adminMenuButton_Click(object sender, EventArgs e)
        {
            _AdminForm.Show();
            this.Hide();
        }

        /**********************************************************************
         * 
         * private void aufAddUserButton_Click
         * @param: object sender, EventArgs e
         * @return: NA
         * @instantiates a new user with attributes as indicated by the Admin;
         * includes extensive data validation
         * 
        **********************************************************************/
        private void aufAddUserButton_Click(object sender, EventArgs e)
        {
            // Create new user
            User theNewUser = new User();

            // ensure mustang id box is not blank
            if (aufMustangBox.Text != "" )
                try
                {
                    { theNewUser.UserID = Int32.Parse(aufMustangBox.Text); }
                }
                catch(Exception ex)
                { MessageBox.Show("Please leave off the 'M' from M number.");
                    aufMustangBox.Text = "";
                }            
            else MessageBox.Show("Please enter the Mustang ID without the 'M'");

            // ensure first name box not blank
            if (auffirstNameBox.Text != "")
            { theNewUser.FirstName = auffirstNameBox.Text; }
            else MessageBox.Show("First Name can't be blank.");

            // ensure last name box not blank
            if (aufLastNameBox.Text != "")
            { theNewUser.LastName = aufLastNameBox.Text; }
            else MessageBox.Show("Last Name can't be blank.");

            // ensure user name box not blank
            if (aufUserNameBox.Text != "")
            { theNewUser.UserName = aufUserNameBox.Text; }
            else MessageBox.Show("User Name can't be blank.");

            // ensure password box not blank
            if (aufPasswordBox.Text != "")
            { theNewUser.PassWord = aufPasswordBox.Text; }
            else MessageBox.Show("Password can't be blank.");

            // default is student; only if admin button clicked is new user an admin
            if (adminRadioButton.Checked)
                theNewUser.UserType = 'A';
            else
                theNewUser.UserType = 'S';

            // create a database manager object
            DatabaseManager thisOne = new DatabaseManager();

            // if all fields are complete, create the new user
            if (
                auffirstNameBox.Text != "" &&
                aufLastNameBox.Text != "" &&
                aufUserNameBox.Text != "" &&
                aufPasswordBox.Text != "" &&
                aufMustangBox.Text != "")
            {
                try
                {
                bool success = thisOne.InsertUser(theNewUser);
                if (success)
                    {
                        MessageBox.Show(theNewUser.FirstName + " " + theNewUser.LastName + " added to database.");
                        auffirstNameBox.Text = "";
                        aufLastNameBox.Text = "";
                        aufUserNameBox.Text = "";
                        aufPasswordBox.Text = "";
                        aufMustangBox.Text = "";
                    }
                    
                else
                    MessageBox.Show("User not added.");
                }
                catch (InvalidOperationException) { }
            }
        }
    }
}
