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
    public partial class AddUserForm : Form
    {
        User addUser;
        public AddUserForm(User user)
        {
            addUser = user;
            InitializeComponent();
        }

        private void AddUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void adminMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm(addUser);
            af.Show();
        }

        private void aufAddUserButton_Click(object sender, EventArgs e)
        {
            User theNewUser = new User();

            try
            {
                theNewUser.UserID = Int32.Parse(this.aufMustangBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter only integers for the M number.");
            }

            theNewUser.FirstName = firstNameBox.Text;
            theNewUser.LastName = aufLastNameBox.Text;
            theNewUser.UserName = aufUserNameBox.Text;
            theNewUser.PassWord = aufPasswordBox.Text;

            if (studentRadioButton.Checked)
                theNewUser.UserType = 'S';
            else
                theNewUser.UserType = 'A';

            DatabaseManager thisOne = new DatabaseManager();

            bool success = thisOne.InsertUser(theNewUser);
            if (success)
                MessageBox.Show(theNewUser.FirstName + " " + theNewUser.LastName + " added to database.");
            else
                MessageBox.Show("User not added.");
        }
    }
}
