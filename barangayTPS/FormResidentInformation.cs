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

                if (residentData.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No resident data found.\n\n" +
                        "This usually happens when:\n" +
                        "1. No document requests have been submitted yet, OR\n" +
                        "2. Requests were submitted without username/fullname information\n\n" +
                        "Ask residents to submit document requests first through the 'Request Now' feature.",
                        "No Data Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    dataGridResidentData.DataSource = residentData;
                }
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
    }
}