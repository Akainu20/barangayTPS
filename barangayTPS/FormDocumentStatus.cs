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
            FormAdminLogin newForm = new FormAdminLogin();
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
            FormAdminDashboard newForm = new FormAdminDashboard();
            newForm.Show();
        }

        private void txtResidentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRequestID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnMarkAsReady_Click(object sender, EventArgs e)
        {

        }

        private void btnReject_Click(object sender, EventArgs e)
        {

        }

        private void btnMarkAsComplete_Click(object sender, EventArgs e)
        {

        }

        private void FormDocumentStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
