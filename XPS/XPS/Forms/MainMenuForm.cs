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

/* ABOUT FORM STILL NEEDS WORK.
 * 
 * 
 * 
 */
namespace XPS
{
    public partial class MainMenuForm : Form
    {
        User mainUser; //will need to pass user to exam form form
        int[] categories = new int[8]; //needed to store what the user checks for categories

        public MainMenuForm()
        {
            InitializeComponent();
        }

        //create a form with the user that is passed from the login form
        public MainMenuForm(User user)
        {
            mainUser = user; //set the mainUser to the user that is passed from login
            InitializeComponent();
            //instead of having two forms, we just made certain components visible/not visible.
            catGroupBox.Visible = false;
            timedGroupBox.Visible = false;
            numGroupBox.Visible = false;
            generateTestButton.Visible = false;
            FormBorderStyle = FormBorderStyle.Sizable;
            TopMost = true;

            //Print user name at the bottom left of the main menu form
            nameLabel.Text = user.FirstName + " " + user.LastName;

            //if User is an Admin Type, we will change the label to admin
            //and make the admin button visible for extra features
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

        /* private void MainMenuForm_Load(object sender, EventArgs e)
         *  MainMenuForm_Load just loads the current date and prints it.
         */
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        /* private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
         * MainMenuForm_FormClosing is used to close the application in case the user hits
         * the 'X' button.
         */
        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /* private void adminButton_Click(object sender, EventArgs e)
         *  if User is an Admin type, the button will be visible which
         *  allows the user to open a new form, adminForm which mainUser
         *  is passed to.
         */
        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm(mainUser);
            af.Show();
        }

        /* private void aboutButton_Click(object sender, EventArgs e)
         *  aboutButton_Click just prints a message box with information about XPS.
         */
        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\t       Exam Preparation Software (XPS)\n" +
                "---------------------------------------------------------------------------------" +
                "\nXPS is a test taking preparation application. XPS simulates the" +
                " MFT Computer Science Exit Exam. When you are ready to take your" +
                " practice exam, press the 'Take Test' button. You are allowed to" +
                " select any of the given categories, if your test is timed," +
                " and the amount of questions you want on your exam. You are given" +
                " two (2) minuutes per question. After your test is completed, you" +
                " will be given a report based on the questions you answered during" +
                " your time taking the test. These reports will be stored on your profile" +
                " page. We at PrepT Software hope your experience with XPS will improve" +
                " your chances at passing the MFT Computer Science Exit Exam.", "XPS - About");
        }

        /* private void takeTestButton_Click(object sender, EventArgs e)
         * takeTestButton_Click makes certain components visible for the user.
         * They will choose what categories, if it is timed, and number of questions
         * for the exam.
         */
        private void takeTestButton_Click(object sender, EventArgs e)
        {
            catGroupBox.Visible = true;
            timedGroupBox.Visible = true;
            numGroupBox.Visible = true;
            questionComboBox.SelectedIndex = 0;
            generateTestButton.Visible = true;
            yesRadioButton.Checked = true;
        }

        /* private void homeButton_Click(object sender, EventArgs e)
         * homeButton_Click does the oppositve of takeTestButton_Click.
         * If the user selects the home button, we want to hide the components
         * and show the main menu screen.        
         */
        private void homeButton_Click(object sender, EventArgs e)
        {
            catGroupBox.Visible = false;
            timedGroupBox.Visible = false;
            numGroupBox.Visible = false;
            generateTestButton.Visible = false;
        }

        private void generateTestButton_Click(object sender, EventArgs e)
        {
            //get whatever string is selected from the combobox (Num of questions user wants)
            string selected = this.questionComboBox.GetItemText(this.questionComboBox.SelectedItem);
            //parse the string into an int and pass it as a parameter to the examForm.
            int num = Int32.Parse(selected);
            bool timed;
            //if timed is selected, bool timed is true, else false.
            if (yesRadioButton.Checked == true)
            {
                timed = true;
            }
            else
                timed = false;

            //user must select at least on category
            if (dsCheckBox.Checked == false && progCheckBox.Checked == false && acCheckBox.Checked == false
                 && sysCheckBox.Checked == false && seCheckBox.Checked == false && imCheckBox.Checked == false && otherCheckBox.Checked == false)
                MessageBox.Show("Must select at least one category to take the test.");
            else
            {
                this.Hide();
                //create an examForm with the mainUser, number of questions, if it is timed
                //and send the categories array based on what is checked or not.
                ExamForm ef = new Forms.ExamForm(mainUser, num, timed, categories);
                ef.Show();
            }


        }

        /* Everything below here will just see if one of the categories is checked when
         * the user selects 'Take Test'. If it is checked, we change the element in an array
         * from 0 to 1. (0 is not checked, 1 is checked). The array we store the information in
         * is categories[]. This array is then passed to the Exam Form where we will use it to
         * get the corresponding questions based on what is checked.
         */
        private void dsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //1 is checked, 0 is not checked
            if (dsCheckBox.Checked == true)
                categories[1] = 1;
            else
                categories[1] = 0;
        }

        private void progCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (progCheckBox.Checked == true)
                categories[2] = 1;
            else
                categories[2] = 0;
        }

        private void acCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (acCheckBox.Checked == true)          
                categories[3] = 1;           
            else
                categories[3] = 0;
        }

        private void sysCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sysCheckBox.Checked == true)           
                categories[4] = 1;         
            else
                categories[4] = 0;
        }

        private void seCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (seCheckBox.Checked == true)           
                categories[5] = 1;            
            else
                categories[5] = 0;
        }

        private void imCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (imCheckBox.Checked == true)           
                categories[6] = 1;          
            else
                categories[6] = 0;
        }

        private void otherCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (otherCheckBox.Checked == true)           
                categories[7] = 1;           
            else
                categories[7] = 0;
        }
    }
}
