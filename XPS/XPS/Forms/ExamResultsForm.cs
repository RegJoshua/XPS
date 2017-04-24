using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPS.Models;
using System.Windows.Forms;

namespace XPS.Forms
{
    public partial class ExamResultsForm : Form
    {
        public ExamResultsForm(Test ts, User user)
        {
            InitializeComponent();

            erfNameLabel.Text = user.FirstName + " " + user.LastName;

            int minute, seconds;
            minute = (int)ts.Time / 60;
            seconds = (int)ts.Time % 60;

            erfTimeTextBx.Text = minute.ToString() + ":" + seconds.ToString();

            int correct = ts.Correct;
            erfCorrectTxtBx.Text = ts.Correct.ToString();

            int attempted = ts.Attempted;
            erfAttemptedTxtBx.Text = ts.Attempted.ToString();

            float score =((float)correct/(float)attempted)*100;
            erfScoreTextBox.Text = score.ToString();

            int incorrect = attempted - correct;
            erfIncorrectTxtBx.Text =incorrect.ToString();



            erfTestIDLabel.Text = ts.TestID.ToString();
        }

        private void erfHomeButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();

            this.Close();
            
        }



 
    }
}
