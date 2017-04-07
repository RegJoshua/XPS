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
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
        }

        public ExamForm(User user, int numQuest)
        {
            InitializeComponent();
            dateLabel.Text = "Date: " + DateTime.Now.ToLongDateString();
            examUserLabel.Text = "User: " + user.FirstName + " " + user.LastName;

            int rowCount = numQuest / 5;
            Point pt = new Point();
            pt.X = 10;
            pt.Y = 10;
            int num = 1;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Text = (num).ToString();
                    button.BackColor = Color.Gray;
                    button.Location = pt;
                    button.Width = 30;
                    button.Height = 30;
                    navGroupBox.Controls.Add(button);
                    pt.X = pt.X + 35;
                    num++;
                }

                pt.X = 10;
                pt.Y = pt.Y + 35;
            }
        }

        private void ExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      
    }
}
