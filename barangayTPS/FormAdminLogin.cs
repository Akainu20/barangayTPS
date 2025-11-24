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
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {
            // Set initial placeholder text and color
            txtAdminLoginUsername.Text = "Enter your Email/Admin Account";
            txtAdminLoginUsername.ForeColor = SystemColors.GrayText;

            txtAdminLoginPassword.Text = "Enter password";
            txtAdminLoginPassword.PasswordChar = '\0';
            txtAdminLoginPassword.ForeColor = SystemColors.GrayText;

            // Set combo box default
            cmbAdmin.Text = "Select role";
        }

        private void cmbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAdmin.SelectedItem == null) return;

            string selectedRole = cmbAdmin.SelectedItem.ToString();

            switch (selectedRole)
            {
                case "Admin":
                    // Already on admin login form
                    MessageBox.Show("You are already on the Admin login page.");
                    break;
                case "Resident":
                    this.Hide();
                    new FormUserLogin().Show();
                    break;
                default:
                    break;
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            // ✅ USE ACTUAL USER INPUT
            string username = txtAdminLoginUsername.Text.Trim();
            string password = txtAdminLoginPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                username == "Enter your Email/Admin Account" || password == "Enter password")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string role = DBHelper.AuthenticateUser(username, password);

            if (role == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            if (role != "Admin")
            {
                MessageBox.Show($"Access denied. Role is: {role}");
                return;
            }

            // LOGIN SUCCESS
            MessageBox.Show("Admin login successful!");
            this.Hide();
            new FormAdminDashboard().Show();
        }

        private void txtAdminLoginUsername_Enter(object sender, EventArgs e)
        {
            if (txtAdminLoginUsername.Text == "Enter your Email/Admin Account")
            {
                txtAdminLoginUsername.Text = "";
                txtAdminLoginUsername.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtAdminLoginPassword_Enter(object sender, EventArgs e)
        {
            if (txtAdminLoginPassword.Text == "Enter password")
            {
                txtAdminLoginPassword.Text = "";
                txtAdminLoginPassword.PasswordChar = '*';
                txtAdminLoginPassword.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtAdminLoginUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdminLoginUsername.Text))
            {
                txtAdminLoginUsername.Text = "Enter your Email/Admin Account";
                txtAdminLoginUsername.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtAdminLoginPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdminLoginPassword.Text))
            {
                txtAdminLoginPassword.Text = "Enter password";
                txtAdminLoginPassword.PasswordChar = '\0';
                txtAdminLoginPassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtAdminLoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdminLogin_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}