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
                DataTable transactionData = DBHelper.GetRequests();
                dataGridTransactionHistory.DataSource = transactionData;
                MessageBox.Show($"Loaded {transactionData.Rows.Count} transactions");
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
            LoadTransactionHistory(); // This will refresh the data
        }
    }
}