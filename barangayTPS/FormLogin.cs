namespace barangayTPS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResidentDashboard newForm = new FormResidentDashboard();
            newForm.Show();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignup newForm = new FormSignup();
            newForm.Show();
        }
    }
}
