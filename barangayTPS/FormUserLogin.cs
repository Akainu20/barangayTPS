namespace barangayTPS
{
    public partial class FormUserLogin : Form
    {
        public FormUserLogin()
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

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FormUserLogin = cmbUser.SelectedItem.ToString();

            switch (FormUserLogin)
            {
                case "Resident":
                    FormUserLogin form1 = new FormUserLogin();
                    form1.Show();
                    this.Hide();
                    break;
                case "Admin":
                    FormAdminLogin form2 = new FormAdminLogin();
                    form2.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
