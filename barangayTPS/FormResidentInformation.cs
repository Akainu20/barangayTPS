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
    public partial class FormResidentInformation : Form
    {
        public FormResidentInformation()
        {
            InitializeComponent();
        }

        private void FormResidentInformation_Load(object sender, EventArgs e)
        {
            LoadResidentData();
        }

        private void LoadResidentData()
        {
            try
            {
                DataTable residentData = DBHelper.GetResidentData();
                dataGridResidentData.DataSource = residentData;
                MessageBox.Show($"Loaded {residentData.Rows.Count} residents from database");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading resident data: {ex.Message}");
            }
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminLogin newForm = new FormAdminLogin();
            newForm.Show();
        }

        private void btnResidentInfoResidentInformation_Click(object sender, EventArgs e)
        {

        }

        private void btnResidentInfoTransactionHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTransactionHistory newForm = new FormTransactionHistory();
            newForm.Show();
        }

        private void btnResidentInfoAdminDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminDashboard newForm = new FormAdminDashboard();
            newForm.Show();
        }

        private void btnResidentInformationBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminDashboard newForm = new FormAdminDashboard();
            newForm.Show();
        }

        private void dataGridResidentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnResidentInfoRefresh_Click(object sender, EventArgs e)
        {
            LoadResidentData();
        }

        // Remove this method if it exists - it's causing the error
        // private void FormResidentInformation_Load_2(object sender, EventArgs e)
        // {
        // }
    }
}