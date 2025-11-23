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
        private string _username;

        public FormAvailableDocuments(string username)
        {
            InitializeComponent();
            _username = username;
        }
        public FormAvailableDocuments()
        {
            InitializeComponent();
        }

        private void btnResidentLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUserLogin newForm = new FormUserLogin();
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

        private void FormAvailableDocuments_Load(object sender, EventArgs e)
        {

        }
    }
}
