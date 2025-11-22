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
    public partial class FormResidentDashboard : Form
    {
        public FormResidentDashboard()
        {
            InitializeComponent();
        }

        private void FormResidentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResidentDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnResidentLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUserLogin newForm = new FormUserLogin();
            newForm.Show();
        }

        private void btnRequestNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDocumentRequest newForm = new FormDocumentRequest();
            newForm.Show();
        }

        private void btnViewNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAvailableDocuments newForm = new FormAvailableDocuments();
            newForm.Show();
        }
    }
}