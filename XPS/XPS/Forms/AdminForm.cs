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
        public AdminForm(User user)
        {
            adminUser = user;
            InitializeComponent();
            welcomeLabel.Text = "Welcome, " + user.FirstName + " " + user.LastName + ".";
           
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mm = new MainMenuForm(adminUser);
            mm.Show();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm auf = new Forms.AddUserForm(adminUser);
            auf.Show();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUserForm duf = new DeleteUserForm(adminUser);
            duf.Show();
        }
    }
}
