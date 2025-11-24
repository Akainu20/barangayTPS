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

        private void FormTransactionHistory_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            try
            {
                // ✅ USE HISTORY-SPECIFIC METHOD
                DataTable transactionData = DBHelper.GetDetailedRequestsForHistory();
                dataGridTransactionHistory.DataSource = transactionData;

                // ❌ REMOVE THIS - We want to SHOW RequestID
                // if (dataGridTransactionHistory.Columns.Contains("RequestID"))
                // {
                //     dataGridTransactionHistory.Columns["RequestID"].Visible = false;
                // }

                // ✅ SET PROPERTIES AFTER data is loaded
                dataGridTransactionHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridTransactionHistory.MultiSelect = false;
                dataGridTransactionHistory.ReadOnly = true;
                dataGridTransactionHistory.RowHeadersVisible = false;
                dataGridTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // ✅ Visual styling for better selection
                dataGridTransactionHistory.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dataGridTransactionHistory.DefaultCellStyle.SelectionForeColor = Color.Black;

                MessageBox.Show($"Loaded {transactionData.Rows.Count} transactions. Select a row and click 'View Details'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction history: {ex.Message}");
            }
        }

        private void btnTransactionHistoryLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminLogin newForm = new FormAdminLogin();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTransactionHistoryResidentInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResidentInformation newForm = new FormResidentInformation();
            newForm.Show();
        }

        private void btnTransactionHistoryBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminDashboard newForm = new FormAdminDashboard();
            newForm.Show();
        }

        private void btnTransactionHistoryTransactionHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnHistoryRefresh_Click(object sender, EventArgs e)
        {
            LoadTransactionHistory(); // This will use the detailed method
        }

        // ✅ BUTTON CLICK METHOD - This is what users will use
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridTransactionHistory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridTransactionHistory.SelectedRows[0];

                try
                {
                    // Get the request data from the selected row
                    // ✅ Use "Request ID" (with space) since that's the display name
                    int requestID = Convert.ToInt32(selectedRow.Cells["Request ID"].Value);
                    string residentName = selectedRow.Cells["Resident Name"].Value?.ToString();
                    string documentType = selectedRow.Cells["Document Type"].Value?.ToString();
                    string dateRequested = selectedRow.Cells["Date Requested"].Value?.ToString();
                    string status = selectedRow.Cells["Status"].Value?.ToString();
                    string purpose = selectedRow.Cells["Purpose of Request"].Value?.ToString();

                    // Open DocumentStatus form and pass the request data
                    this.Hide();
                    FormDocumentStatus docStatusForm = new FormDocumentStatus(requestID, residentName, documentType, dateRequested, status);
                    docStatusForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error getting row data: {ex.Message}\n\nPlease make sure you selected a valid row.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request first by clicking on a row, then click 'View Details'.");
            }
        }

        private void FormTransactionHistory_Load_1(object sender, EventArgs e)
        {

        }
    }
}