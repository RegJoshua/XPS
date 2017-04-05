using XPS.Properties;
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

namespace XPS
{
    public partial class MainMenuForm : Form
    {
        User mainUser;

        public MainMenuForm()
        {
            InitializeComponent();
        }
        
        public MainMenuForm(User user)
        {
            mainUser = user;
            InitializeComponent();
            catGroupBox.Visible = false;
            timedGroupBox.Visible = false;
            numGroupBox.Visible = false;
            generateTestButton.Visible = false;
            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = true;

            nameLabel.Text = user.FirstName + " " + user.LastName;
            if (user.UserType == 'A')
            {
                userTypeLabel.Text = "Admin";
                adminButton.Visible = true;
            }
            else
            {
                userTypeLabel.Text = "Student";
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm(mainUser);
            af.Show();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t\tXPS\n" + "-------------------------------------------" +
                "\nXPS is a test taking preparation application. XPS simulates the" +
                " Computer Science Exit Exam.");
        }

        private void takeTestButton_Click(object sender, EventArgs e)
        {
            catGroupBox.Visible = true;
            timedGroupBox.Visible = true;
            numGroupBox.Visible = true;
            generateTestButton.Visible = true;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            catGroupBox.Visible = false;
            timedGroupBox.Visible = false;
            numGroupBox.Visible = false;
            generateTestButton.Visible = false;
        }

        private void generateTestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm ef = new Forms.ExamForm(mainUser);
            ef.Show();
        }
    }
}
