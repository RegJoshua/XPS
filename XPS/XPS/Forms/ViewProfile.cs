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

namespace XPS.Forms
{
    public partial class ViewProfile : Form
    {
        User vpUser;
        public ViewProfile()
        {
            InitializeComponent();
        }

        public ViewProfile(User user)
        {
            InitializeComponent();
            vpUser = user;
            vpWelcomeLabel.Text = "Welcome, " + user.FirstName + " " + user.LastName;
        }

        private void vpMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mm = new MainMenuForm(vpUser);
            mm.Show();
        }
    }
}
