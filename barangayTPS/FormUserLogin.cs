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
            if (txtLoginUsername == null || txtLoginPassword == null)
            {
                MessageBox.Show("Please enter Username/Password.");
                return;
            }

            string username = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text.Trim();

            string role = DBHelper.AuthenticateUser(username, password);

            if (role == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            if (role == "Resident")
            {
                this.Hide();
                new FormResidentDashboard(username).Show();
            }
            else if (role == "Admin")
            {
                this.Hide();
                new FormAdminDashboard().Show();
            }

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
