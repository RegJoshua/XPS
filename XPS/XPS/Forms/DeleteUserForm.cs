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
        DatabaseManager thisOne;
        User deleteMe;
        User adminUser;

        public DeleteUserForm(User user)
        {
            adminUser = user;
            
            InitializeComponent();
        }

        private void DeleterUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dAdminMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm(adminUser);
            af.Show();
        }

        private void dGetUserButton_Click(object sender, EventArgs e)
        {

            try
            {
                thisOne = new DatabaseManager();
                deleteMe = thisOne.GetUser(Int32.Parse(dMustangBox.Text));
                dFirstnameBox.Text = deleteMe.FirstName;
                dLastnameBox.Text = deleteMe.LastName;
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
                deleteMe.FirstName + " " + deleteMe.LastName + "?",
                "About to delete", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    bool deleteSuccessful = thisOne.DeleteUser(deleteMe.UserID);
                    if (deleteSuccessful)
                    {
                        MessageBox.Show(deleteMe.FirstName +
                       " " + deleteMe.LastName + " deleted from users table.");

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
