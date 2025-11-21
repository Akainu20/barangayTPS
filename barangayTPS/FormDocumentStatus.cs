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
    public partial class FormDocumentStatus : Form
    {
        public FormDocumentStatus()
        {
            InitializeComponent();
        }

        private void btnDocumentStatusLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newForm = new FormLogin();
            newForm.Show();
        }

        private void btnDocumentStatusDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminDashboard newForm = new FormAdminDashboard();
            newForm.Show();
        }

        private void btnDocumentStatusTransactionHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTransactionHistory newForm = new FormTransactionHistory();
            newForm.Show();
        }

        private void btnBackToAdminDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTransactionHistory newForm = new FormTransactionHistory();
            newForm.Show();
        }
    }
}
