using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace barangayTPS
{
    public partial class FormAdminDashboard : Form
    {
        // ✅ ADD THIS MISSING METHOD
        private void LoadRequests()
        {
            try
            {
                // ✅ USE DASHBOARD-SPECIFIC METHOD
                DataTable requests = DBHelper.GetRecentRequestsForDashboard();
                dataGridRecentRequest.DataSource = requests;

                // Hide RequestID column
                if (dataGridRecentRequest.Columns.Contains("RequestID"))
                {
                    dataGridRecentRequest.Columns["RequestID"].Visible = false;
                }

                // Optional: Rename columns for better display
                if (dataGridRecentRequest.Columns.Contains("Date Requested"))
                {
                    dataGridRecentRequest.Columns["Date Requested"].HeaderText = "Date";
                }

                // ✅ Make columns fill the grid
                dataGridRecentRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading requests: {ex.Message}");
            }
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

        // ✅ UPDATED FILTER BUTTONS
        private void btnTotalRequest_Click(object sender, EventArgs e)
        {
            // ✅ Show ALL requests (no filter)
            dataGridRecentRequest.DataSource = DBHelper.GetRecentRequestsForDashboard();
        }

        private void btnResidentInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResidentInformation newForm = new FormResidentInformation();
            newForm.Show();
        }

        private void btnRecentRequestRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests(); // This will use GetRecentRequestsForDashboard
        }

        private void btnPendingRequest_Click(object sender, EventArgs e)
        {
            dataGridRecentRequest.DataSource = DBHelper.GetRecentRequestsForDashboard(
                "Status = @s",
                new SQLiteParameter("@s", "Pending")
            );
        }

        private void btnCompletedRequest_Click(object sender, EventArgs e)
        {
            dataGridRecentRequest.DataSource = DBHelper.GetRecentRequestsForDashboard(
                "Status = @s",
                new SQLiteParameter("@s", "Completed")
            );
        }

        private void btnRejectedRequest_Click(object sender, EventArgs e)
        {
            dataGridRecentRequest.DataSource = DBHelper.GetRecentRequestsForDashboard(
                "Status = @s",
                new SQLiteParameter("@s", "Rejected")
            );
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }
    }
}