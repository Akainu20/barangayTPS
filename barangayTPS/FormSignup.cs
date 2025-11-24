using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barangayTPS
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtSignupUsername.Text.Trim();
            string password = txtSignupPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                username == "Create admin username/email" || password == "Enter password")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            int result = DBHelper.InsertUser(username, password, "Resident");

            if (result > 0)
            {
                this.Hide();
                new FormUserLogin().Show();
            }
            else
            {
                MessageBox.Show("Failed to create account. Username may already exist.");
            }
        }

        private void lblTransactionManagementSystem_Click(object sender, EventArgs e)
        {

        }
    }
}