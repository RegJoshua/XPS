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

        public ExamForm(User user)
        {
            InitializeComponent();
            examUserLabel.Text = "User: " + user.FirstName + " " + user.LastName;
        }

        private void ExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
