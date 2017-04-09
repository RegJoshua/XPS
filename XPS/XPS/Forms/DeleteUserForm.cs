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
    public partial class DeleteUserForm : Form
    {
        private DatabaseManager _thisOne;
        private User _deleteMe;
        //User adminUser;
        private AdminForm _AdminForm;



        public DeleteUserForm(AdminForm anAdminForm)
        {
            //adminUser = user;

            _AdminForm = anAdminForm;
            
            InitializeComponent();
        }

        private void DeleteUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            _AdminForm.Show();
        }

        private void dAdminMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            _AdminForm.Show();

        }

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

        private void dDeleteUserButton_Click(object sender, EventArgs e)
        {
           
            DialogResult result1 = MessageBox.Show("Do you want to delete " +
                _deleteMe.FirstName + " " + _deleteMe.LastName + "?",
                "About to delete", MessageBoxButtons.YesNo);
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
            else
            {
                dMustangBox.Text = "";
                dFirstnameBox.Text = "";
                dLastnameBox.Text = "";
            }

            //MessageBox.Show("You are about to delete " + deleteMe.FirstName + " " + deleteMe.LastName);

            //thisOne.DeleteUser(deleteMe.UserID);
            /*
            dFirstnameBox.Text = "";
            dLastnameBox.Text = "";
            dInstructionBox.Show();
            dVerifyBox.Hide();
            dDeleteUserButton.Hide();
            dFirstnameLabel.Hide();
            dFirstnameBox.Hide();
            dLastnameLabel.Hide();
            dLastnameBox.Hide();
            */
        }

        private void dCancelButton_Click(object sender, EventArgs e)
        {
            dMustangBox.Text = "";
            dFirstnameBox.Text = "";
            dLastnameBox.Text = "";
        }
    }
}
