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
        User deleteUser;

        public DeleteUserForm(User user)
        {
            deleteUser = user;
            //DeleteUserForm.Text = user.FirstName + " " + user.LastName;
            InitializeComponent();
        }

        private void DeleterUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dAdminMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm(deleteUser);
            af.Show();
        }

        private void dGetUserButton_Click(object sender, EventArgs e)
        {
            thisOne = new DatabaseManager();
            deleteMe = thisOne.GetUser(Int32.Parse(dMustangBox.Text));
            dFirstnameBox.Text = deleteMe.FirstName;
            dLastnameBox.Text = deleteMe.LastName;
        }

        private void dDeleteUserButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to delete " + deleteMe.FirstName + " " + deleteMe.LastName);
            thisOne.DeleteUser(deleteMe.UserID);
        }

        private void dCancelButton_Click(object sender, EventArgs e)
        {
            dMustangBox.Text = "";
            dFirstnameBox.Text = "";
            dLastnameBox.Text = "";
        }
    }
}
