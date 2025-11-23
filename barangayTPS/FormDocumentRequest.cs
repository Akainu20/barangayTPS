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
    public partial class FormDocumentRequest : Form
    {
        private string _username;

        public FormDocumentRequest(string username)
        {
            InitializeComponent();
            _username = username;
        }
        public FormDocumentRequest()
        {
            InitializeComponent();
        }

        private void btnBackResidentDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResidentDashboard newForm = new FormResidentDashboard();
            newForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResidentDashboard newForm = new FormResidentDashboard();
            newForm.Show();
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName.Text.Trim();
            int age = int.Parse(txtAge.Text.Trim());
            string address = txtAddress.Text.Trim();
            string contact = txtContactNumber.Text.Trim();
            string docType = cmbDocType.SelectedValue.ToString();
            string purpose = txtRequestReason.Text.Trim();
            string status = "Pending";
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            int result = DBHelper.InsertRequest(
                _username,
                fullname,
                age,
                address,
                contact,
                docType,
                purpose,
                status,
                date
            );

            if (result > 0)
            {
                MessageBox.Show("Request submitted successfully!");
                this.Hide();
                new FormResidentDashboard(_username).Show();
            }
            else
            {
                MessageBox.Show("Failed to submit request.");
            }
        }

        private void FormDocumentRequest_Load(object sender, EventArgs e)
        {
            cmbDocType.DataSource = DBHelper.GetDocumentTypes();
            cmbDocType.DisplayMember = "DocumentType";
            cmbDocType.ValueMember = "DocumentType";

            txtUsername.Text = _username;
        }
    }
}
