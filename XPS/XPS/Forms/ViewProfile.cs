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

/* NOTICE!!!!!
 * This form is an incomplete form. Originally, we wanted it to contain details
 * for each student's personal exams such as incorrect and correct answers on each
 * exam. We also wanted to display a table of all past user exams that is pulled
 * from the database. We need an option for students to change their passwords after
 * their initial account is created.
 * 
 */ 
namespace XPS.Forms
{
    public partial class ViewProfile : Form
    {
        User vpUser;
        public ViewProfile()
        {
            InitializeComponent();
        }

        //this will initialize the viewProfileForm with the user that was
        //passed in from the main menu form. It prints a welcome message + name
        public ViewProfile(User user)
        {
            InitializeComponent();
            vpUser = user;
            vpWelcomeLabel.Text = "Welcome, " + user.FirstName + " " + user.LastName;
        }

        //This is used to go back to the main menu once the user is complete with the view profile form.
        private void vpMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mm = new MainMenuForm(vpUser);
            mm.Show();
        }
    }
}
