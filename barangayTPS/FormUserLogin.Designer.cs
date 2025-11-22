namespace barangayTPS
{
    partial class FormUserLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLoginHeader = new Panel();
            cmbUser = new ComboBox();
            btnUserLogin = new Button();
            lblSignup = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            txtUserLoginPassword = new TextBox();
            txtUserLoginUsername = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            Admin = new Label();
            panelLoginHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLoginHeader
            // 
            panelLoginHeader.BackColor = Color.SeaGreen;
            panelLoginHeader.Controls.Add(cmbUser);
            panelLoginHeader.Controls.Add(Admin);
            panelLoginHeader.Controls.Add(btnUserLogin);
            panelLoginHeader.Controls.Add(lblSignup);
            panelLoginHeader.Controls.Add(label8);
            panelLoginHeader.Controls.Add(pictureBox1);
            panelLoginHeader.Controls.Add(label7);
            panelLoginHeader.Controls.Add(label6);
            panelLoginHeader.Controls.Add(txtUserLoginPassword);
            panelLoginHeader.Controls.Add(txtUserLoginUsername);
            panelLoginHeader.Controls.Add(label1);
            panelLoginHeader.Controls.Add(label3);
            panelLoginHeader.Controls.Add(label2);
            panelLoginHeader.Location = new Point(-3, -7);
            panelLoginHeader.Name = "panelLoginHeader";
            panelLoginHeader.Size = new Size(1375, 982);
            panelLoginHeader.TabIndex = 3;
            // 
            // cmbUser
            // 
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(495, 280);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(97, 28);
            cmbUser.TabIndex = 16;
            cmbUser.Text = "Select role";
            // 
            // btnUserLogin
            // 
            btnUserLogin.BackColor = Color.White;
            btnUserLogin.Location = new Point(501, 480);
            btnUserLogin.Margin = new Padding(3, 4, 3, 4);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(86, 31);
            btnUserLogin.TabIndex = 14;
            btnUserLogin.Text = "Login";
            btnUserLogin.UseVisualStyleBackColor = false;
            btnUserLogin.Click += btnLogin_Click;
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.BackColor = Color.Transparent;
            lblSignup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignup.ForeColor = Color.Yellow;
            lblSignup.Location = new Point(580, 542);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(63, 20);
            lblSignup.TabIndex = 13;
            lblSignup.Text = "Sign Up";
            lblSignup.Click += lblSignup_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(447, 542);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 12;
            label8.Text = "Don't have account? \r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.logo_removebg_preview;
            pictureBox1.Location = new Point(495, 60);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(353, 456);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 10;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(353, 386);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 9;
            label6.Text = "Username/Email";
            label6.Click += label6_Click;
            // 
            // txtUserLoginPassword
            // 
            txtUserLoginPassword.Location = new Point(353, 420);
            txtUserLoginPassword.Multiline = true;
            txtUserLoginPassword.Name = "txtUserLoginPassword";
            txtUserLoginPassword.PasswordChar = '*';
            txtUserLoginPassword.Size = new Size(403, 32);
            txtUserLoginPassword.TabIndex = 7;
            txtUserLoginPassword.Text = "Enter password\r\n";
            // 
            // txtUserLoginUsername
            // 
            txtUserLoginUsername.Location = new Point(353, 353);
            txtUserLoginUsername.Multiline = true;
            txtUserLoginUsername.Name = "txtUserLoginUsername";
            txtUserLoginUsername.Size = new Size(403, 29);
            txtUserLoginUsername.TabIndex = 6;
            txtUserLoginUsername.Text = "Enter your username/email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(431, 184);
            label1.Name = "label1";
            label1.Size = new Size(265, 38);
            label1.TabIndex = 0;
            label1.Text = "Barangay San Juan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(495, 249);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 2;
            label3.Text = "Taytay, Rizal";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(422, 224);
            label2.Name = "label2";
            label2.Size = new Size(265, 23);
            label2.TabIndex = 1;
            label2.Text = "Transaction Management System";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(260, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(8, 28);
            comboBox1.TabIndex = 4;
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin.ForeColor = Color.White;
            Admin.Location = new Point(514, 311);
            Admin.Name = "Admin";
            Admin.Size = new Size(54, 28);
            Admin.TabIndex = 15;
            Admin.Text = "User";
            // 
            // FormUserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1166, 739);
            Controls.Add(comboBox1);
            Controls.Add(panelLoginHeader);
            Name = "FormUserLogin";
            Text = "FormLogin";
            panelLoginHeader.ResumeLayout(false);
            panelLoginHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLoginHeader;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUsername;
        private PictureBox pictureBox1;
        private Label lblSignup;
        private Label label8;
        private Button btnLogin;
        private Button btnUserLogin;
        private TextBox txtUserLoginPassword;
        private TextBox txtUserLoginUsername;
        private Button button1;
        private ComboBox cmbUser;
        private ComboBox comboBox1;
        private Label Admin;
    }
}
