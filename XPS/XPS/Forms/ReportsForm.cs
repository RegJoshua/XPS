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

namespace XPS.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void FillUserComboBox()
        {
            DatabaseManager db = new DatabaseManager();
            Dictionary<int, string> names = db.GetUserList();

            foreach (string name in names.Values)
            {
                usersComboBox.Items.Add(name);
            }
        }

        private void reportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportsComboBox.SelectedItem.ToString() == "Individual Student Results")
            {
                userSelectionLabel.Visible = true;
                usersComboBox.Visible = true;

                FillUserComboBox();
            }
        }
    }
}
