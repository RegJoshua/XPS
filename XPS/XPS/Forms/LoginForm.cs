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
    public partial class LoginForm : Form
    {
        //Creating instances of User and DatabaseManager.
        User user = new User();
        DatabaseManager db = new DatabaseManager();

        public LoginForm()
        {
            InitializeComponent();
        }

        /* loginButton_Click() will perform when the login button is clicked.
         * This will check if the username or password textbox is empty. If it is,
         * there will be a messageBox that will show the error. If there is any text
         * entered in both boxes, it will call the validateUser() method within the 
         * database manager class. If it returns null, there was no user in the database.
         * If the username and password match, the main menu will show.
         */
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Username or Password cannot be empty. Please enter your credentials.");
                usernameBox.Text = "";
                passwordBox.Text = "";
            }
            else
            {
                try
                {
                    user = db.ValidateUser(usernameBox.Text, passwordBox.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Trouble connecting to database. Try again later.");
                    Application.Exit(); //want the form to close if error is thrown after
                                        //user chooses "ok" on messagebox.
                }

                //db.ValidateUser() returns null if not authenticated.
                if(user == null)
                {
                    MessageBox.Show("Username/Password is incorrect. Try again.");
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                    usernameBox.Focus();
                }
                else
                {
                    this.Hide();
                    MainMenuForm mm = new MainMenuForm(user);
                    mm.Show();
                }
            }//else
        }//method

        /* usernameBox_KeyDown() will check if there is anything in the textbox.
         * if the textbox is empty, there will be an error message. 
         * else the focus will transfer to the password box.
         */ 
        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(usernameBox.Text == "")
                {
                    MessageBox.Show("Invalid Username or Password. Try again.", "Invalid Login", MessageBoxButtons.OK);
                    usernameBox.Text = "";
                }
                else
                {
                    passwordBox.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        /* passwordBox_KeyDown will check if the passwordBox is empty. 
         * If it is, there will be an error message.
         * else, the loginButton will perform a click initiating the loginButton_Click() method.
         * 
         */ 
        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(passwordBox.Text == "")
                {
                    MessageBox.Show("Invalid Username or Password. Try again.", "Invalid Login", MessageBoxButtons.OK);
                    passwordBox.Text = "";
                }
                else
                {
                    loginButton.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        /* Used to close the application when the user presses 'X' in the corner.*/
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
