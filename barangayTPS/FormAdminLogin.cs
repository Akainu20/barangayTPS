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
            this.Hide();
            FormAdminDashboard newForm = new FormAdminDashboard();
            newForm.Show();
        }
    }
}
