using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XPS.Models;
using XPS.Forms;

namespace XPS.Forms
{
    public partial class AdminForm : Form
    {
        User adminUser;
        //AdminForm is created with the User object that is passed from
        //the main menu.
        public AdminForm(User user)
        {
            adminUser = user;
            InitializeComponent();
            //print a welcome message the admin at the top of the form.
            welcomeLabel.Text = "Welcome, " + user.FirstName + " " + user.LastName + ".";
           
        }

        /* private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
         * This will close the application when the user clicks on 'X'
         */
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /*  private void mainMenuButton_Click(object sender, EventArgs e)
         *  This will hide the adminForm and show the Main Menu Form.
         */
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mm = new MainMenuForm(adminUser);
            mm.Show();
        }

        /* private void addUserButton_Click(object sender, EventArgs e)
         * This will hide the adminForm and show the AddUserForm.
         */
        private void addUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm auf = new Forms.AddUserForm(this);
            auf.Show();
        }

        /* private void deleteUserButton_Click(object sender, EventArgs e)
         * This will hide the adminForm and show the deleteUserForm
         */
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUserForm duf = new DeleteUserForm(this);
            duf.Show();
        }
    }
}
