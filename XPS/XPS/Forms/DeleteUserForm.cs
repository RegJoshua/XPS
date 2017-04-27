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
    /************************************************************************** 
     * Class Delete User Form
     * 
     * Administrators use this form to delete users from the database. The 
     * administrator enters the Mustang ID of the user to be deleted and then
     * clicks the "Get User" key. XPS displays the first and last name of the 
     * user to be deleted for confirmation. If the correct user is displayed, 
     * the admin clicks the "Delete User" button; if not, admin selects the
     * "Cancel" button and the form returns to its opening state.
     *     
    **************************************************************************/
    public partial class DeleteUserForm : Form
    {
        // create the objects used by the form in the deletion process
        private DatabaseManager _thisOne;
        private User _deleteMe;
        private AdminForm _AdminForm;

        /**********************************************************************
         * 
         * Constructor
         * @param: AdminForm anAdminForm
         * 
        **********************************************************************/

        public DeleteUserForm(AdminForm anAdminForm)
        {
            _AdminForm = anAdminForm;
            
            InitializeComponent();
        }

        /**********************************************************************
         * 
         * private void DeleteUserForm_FormClosing
         * @param: object sender, FormClosingEventArgs e
         * @return: NA
         * @closes this form and displays the admin form passed into the 
         * constructor
         * 
        **********************************************************************/
        private void DeleteUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           _AdminForm.Show();
        }

        /**********************************************************************
         * 
         * private void dAdminMenu_Click
         * @param: object sender, EventArgs e
         * @return: NA
         * @closes this form and displays the admin form passed into the 
         * constructor
         * 
        **********************************************************************/
        private void dAdminMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            _AdminForm.Show();
        }

        /**********************************************************************
         * 
         * private dGetUserButton_Click
         * @param: object sender, EventArgs e
         * @return: NA
         * @queries the database through the database manager with the 
         * Mustang ID entered by the user.
         * 
        **********************************************************************/
        private void dGetUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                _thisOne = new DatabaseManager();
                _deleteMe = _thisOne.GetUser(Int32.Parse(dMustangBox.Text));
                dFirstnameBox.Text = _deleteMe.FirstName;
                dLastnameBox.Text = _deleteMe.LastName;
                dInstructionBox.Hide();
                dVerifyBox.Show();
                dDeleteUserButton.Show();
                dFirstnameLabel.Show();
                dFirstnameBox.Show();
                dLastnameLabel.Show();
                dLastnameBox.Show();
                dMustangBox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("No record found for that Mustang ID.");
                dMustangBox.Text = "";
            }
        }

        /**********************************************************************
         * 
         * private dDeleteUserButton_Click
         * @param: object sender, EventArgs e
         * @return: NA
         * @First displays confirmation message box; upon confirmation, deletes
         * user from database through the agency of the database manager. Absent
         * confirmation, restores form to its opening configuration.
         * 
        **********************************************************************/
        private void dDeleteUserButton_Click(object sender, EventArgs e)
        {
           // first display confirmation message box
            DialogResult result1 = MessageBox.Show("Do you want to delete " +
                _deleteMe.FirstName + " " + _deleteMe.LastName + "?",
                "About to delete", MessageBoxButtons.YesNo);

            // if confirmed, delete the user
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    bool deleteSuccessful = _thisOne.DeleteUser(_deleteMe.UserID);
                    if (deleteSuccessful)
                    {
                        MessageBox.Show(_deleteMe.FirstName +
                       " " + _deleteMe.LastName + " deleted from users table.");

                        dMustangBox.Text = "";
                        dFirstnameBox.Text = "";
                        dLastnameBox.Text = "";
                        dInstructionBox.Show();
                        dVerifyBox.Hide();
                        dDeleteUserButton.Hide();
                        dFirstnameLabel.Hide();
                        dFirstnameBox.Hide();
                        dLastnameLabel.Hide();
                        dLastnameBox.Hide();
                    }
                }
                catch (Exception ex) { }
            }
            // if "no" was selected on confirmation, display form in opening
            // configuration
            else 
            {
                dMustangBox.Text = "";
                dFirstnameBox.Text = "";
                dLastnameBox.Text = "";
                dInstructionBox.Show();
                dVerifyBox.Hide();
                dDeleteUserButton.Hide();
                dFirstnameLabel.Hide();
                dFirstnameBox.Hide();
                dLastnameLabel.Hide();
                dLastnameBox.Hide();
            }
        }

        /**********************************************************************
         * 
         * private dCancelButton_Click
         * @param: object sender, EventArgs e
         * @return: NA
         * @restores form to its opening configuration.
         * 
        **********************************************************************/
        private void dCancelButton_Click(object sender, EventArgs e)
        {
            dMustangBox.Text = "";
            dFirstnameBox.Text = "";
            dFirstnameBox.Hide();
            dLastnameBox.Text = "";
            dLastnameBox.Hide();
            dDeleteUserButton.Hide();
            dVerifyBox.Hide();
            dInstructionBox.Show();
        }
    }
}
