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

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FormUserLogin = cmbUser.SelectedItem.ToString();

            switch (FormUserLogin)
            {
                case "Admin":
                    FormAdminLogin form2 = new FormAdminLogin();
                    form2.Show();
                    this.Hide();
                    break;
                case "Resident":
                    FormUserLogin form1 = new FormUserLogin();
                    form1.Show();
                    this.Hide();
                    break;

                default:
                    break;
            }
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignup newForm = new FormSignup();
            newForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserLoginUsername.Text.Trim();
            string password = txtUserLoginPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (username == "Enter your username/email")
            {
                MessageBox.Show("Please enter your actual username.");
                return;
            }

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

        private void FormUserLogin_Load(object sender, EventArgs e)
        {
        }
    }
}