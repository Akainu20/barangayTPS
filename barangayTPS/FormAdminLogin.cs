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

        private void cmbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FormUserLogin = cmbAdmin.SelectedItem.ToString();

            switch (FormUserLogin)
            {
                case "Admin":
                    FormAdminLogin form2 = new FormAdminLogin();
                    form2.Show();
                    this.Hide();
                    break;
                case "Resident":
                    FormUserLogin form1 = new FormUserLogin();
                    form1.Show();
                    this.Hide();
                    break;

                default:
                    break;
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            // Use the exact credentials that were just created
            string username = "Admin";
            string password = "Admin123";

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
    }
}
