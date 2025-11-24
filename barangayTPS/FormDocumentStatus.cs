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
    public partial class FormDocumentStatus : Form
    {
        // ✅ ADD THIS FIELD right here (at class level)
        private int _requestID;

        // ✅ ADD THIS CONSTRUCTOR right here
        public FormDocumentStatus(int requestID, string residentName, string documentType, string dateRequested, string status)
        {
            InitializeComponent();
            _requestID = requestID;

            // Populate the form fields
            txtRequestID.Text = requestID.ToString();
            txtResidentName.Text = residentName;
            txtDocType.Text = documentType;
            txtDate.Text = dateRequested;
            txtStatus.Text = status;
        }

        // Keep your existing default constructor
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

        // ✅ UPDATED BUTTON METHODS WITH CRUD FUNCTIONALITY
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (UpdateRequestStatus("Accepted"))
            {
                MessageBox.Show("Request accepted successfully!");
                txtStatus.Text = "Accepted";
            }
        }

        private void btnMarkAsReady_Click(object sender, EventArgs e)
        {
            if (UpdateRequestStatus("Ready"))
            {
                MessageBox.Show("Request marked as ready!");
                txtStatus.Text = "Ready";
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (UpdateRequestStatus("Rejected"))
            {
                MessageBox.Show("Request rejected!");
                txtStatus.Text = "Rejected";
            }
        }

        private void btnMarkAsComplete_Click(object sender, EventArgs e)
        {
            if (UpdateRequestStatus("Completed"))
            {
                MessageBox.Show("Request completed!");
                txtStatus.Text = "Completed";
            }
        }

        private void FormDocumentStatus_Load(object sender, EventArgs e)
        {
            // Optional: Add any initialization code here if needed
            if (_requestID == 0)
            {
                MessageBox.Show("No request selected. Please select a request from Transaction History.");
            }
        }

        // ✅ ADD THIS CRUD METHOD
        private bool UpdateRequestStatus(string newStatus)
        {
            try
            {
                using (var conn = new SQLiteConnection(DBHelper.connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Requests SET Status = @status WHERE RequestID = @requestID";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@requestID", _requestID);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating status: {ex.Message}");
                return false;
            }
        }

        // ✅ ADD THIS METHOD FOR RESIDENT INFORMATION BUTTON (if you have one)
        private void btnDocumentStatusResidentInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResidentInformation newForm = new FormResidentInformation();
            newForm.Show();
        }
    }
}