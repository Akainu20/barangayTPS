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

            MessageBox.Show($"Creating account: Username='{username}', Password='{password}'");

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check if user entered actual values (not placeholders)
            if (username == "Create admin username/email" || password == "Enter password")
            {
                MessageBox.Show("Please enter actual username and password values.");
                return;
            }

            try
            {
                // THIS IS THE KEY LINE - Actually insert the user into the database
                int result = DBHelper.InsertUser(username, password, "Resident");

                if (result > 0)
                {
                    MessageBox.Show($"Account '{username}' created successfully! You can now login.");
                    this.Hide();
                    new FormUserLogin().Show();
                }
                else
                {
                    MessageBox.Show("Failed to create account. Username may already exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}");
            }
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {
            // Database should already be initialized
        }

        // Add these methods to clear placeholder text
        private void txtSignupUsername_Enter(object sender, EventArgs e)
        {
            if (txtSignupUsername.Text == "Create admin username/email")
            {
                txtSignupUsername.Text = "";
                txtSignupUsername.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSignupPassword_Enter(object sender, EventArgs e)
        {
            if (txtSignupPassword.Text == "Enter password")
            {
                txtSignupPassword.Text = "";
                txtSignupPassword.PasswordChar = '*';
                txtSignupPassword.ForeColor = SystemColors.WindowText;
            }
        }

        // Optional: Add placeholder text back if fields are left empty
        private void txtSignupUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSignupUsername.Text))
            {
                txtSignupUsername.Text = "Create admin username/email";
                txtSignupUsername.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtSignupPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSignupPassword.Text))
            {
                txtSignupPassword.Text = "Enter password";
                txtSignupPassword.PasswordChar = '\0';
                txtSignupPassword.ForeColor = SystemColors.GrayText;
            }
        }
    }
}