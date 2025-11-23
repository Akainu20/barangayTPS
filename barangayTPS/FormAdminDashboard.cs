using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barangayTPS
{
    public partial class FormAdminDashboard : Form
    {
        private void LoadRequests()
        {
            dataGridRecentRequest.DataSource = DBHelper.GetRequests();
        }
        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminLogin newForm = new FormAdminLogin();
            newForm.Show();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTransactionHistory newForm = new FormTransactionHistory();
            newForm.Show();
        }

        private void btnTotalRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnResidentInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResidentInformation newForm = new FormResidentInformation();
            newForm.Show();
        }

        private void btnRecentRequestRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void btnPendingRequest_Click(object sender, EventArgs e)
        {
            dataGridRecentRequest.DataSource =
        DBHelper.GetRequests("Status = @s",
        new SQLiteParameter("@s", "Pending"));
        }

        private void btnCompletedRequest_Click(object sender, EventArgs e)
        {
            dataGridRecentRequest.DataSource =
        DBHelper.GetRequests("Status = @s",
        new SQLiteParameter("@s", "Completed"));
        }

        private void btnRejectedRequest_Click(object sender, EventArgs e)
        {
            dataGridRecentRequest.DataSource =
        DBHelper.GetRequests("Status = @s",
        new SQLiteParameter("@s", "Rejected"));
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }
    }
}
