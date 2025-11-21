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
    public partial class FormAvailableDocuments : Form
    {
        public FormAvailableDocuments()
        {
            InitializeComponent();
        }

        private void btnResidentLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newForm = new FormLogin();
            newForm.Show();
        }

        private void btnResidentDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResidentDashboard newForm = new FormResidentDashboard();
            newForm.Show();
        }

        private void btnBackToAdminDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResidentDashboard newForm = new FormResidentDashboard();
            newForm.Show();
        }
    }
}
