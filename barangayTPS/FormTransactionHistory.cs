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
    public partial class FormTransactionHistory : Form
    {
        public FormTransactionHistory()
        {
            InitializeComponent();
        }

        private void btnTransactionHistoryLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newForm = new FormLogin();
            newForm.Show();
        }

        private void btnTransactionHistoryDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminDashboard newForm = new FormAdminDashboard();
            newForm.Show();
        }

        private void btnBackAdminDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminDashboard newForm = new FormAdminDashboard();
            newForm.Show();
        }
    }
}
