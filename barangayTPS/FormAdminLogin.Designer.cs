namespace barangayTPS
{
    partial class FormAdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLoginHeader = new Panel();
            Admin = new Label();
            btnAdminLogin = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            txtAdminLoginPassword = new TextBox();
            txtAdminLoginUsername = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbAdmin = new ComboBox();
            panelLoginHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLoginHeader
            // 
            panelLoginHeader.BackColor = Color.SeaGreen;
            panelLoginHeader.Controls.Add(cmbAdmin);
            panelLoginHeader.Controls.Add(Admin);
            panelLoginHeader.Controls.Add(btnAdminLogin);
            panelLoginHeader.Controls.Add(pictureBox1);
            panelLoginHeader.Controls.Add(label7);
            panelLoginHeader.Controls.Add(label6);
            panelLoginHeader.Controls.Add(txtAdminLoginPassword);
            panelLoginHeader.Controls.Add(txtAdminLoginUsername);
            panelLoginHeader.Controls.Add(label1);
            panelLoginHeader.Controls.Add(label3);
            panelLoginHeader.Controls.Add(label2);
            panelLoginHeader.Location = new Point(-104, -122);
            panelLoginHeader.Name = "panelLoginHeader";
            panelLoginHeader.Size = new Size(1375, 982);
            panelLoginHeader.TabIndex = 4;
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin.ForeColor = Color.White;
            Admin.Location = new Point(605, 429);
            Admin.Name = "Admin";
            Admin.Size = new Size(74, 28);
            Admin.TabIndex = 5;
            Admin.Text = "Admin";
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.White;
            btnAdminLogin.Location = new Point(605, 599);
            btnAdminLogin.Margin = new Padding(3, 4, 3, 4);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(86, 31);
            btnAdminLogin.TabIndex = 14;
            btnAdminLogin.Text = "Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.logo_removebg_preview;
            pictureBox1.Location = new Point(599, 179);
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
            label7.Location = new Point(457, 575);
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
            label6.Location = new Point(457, 505);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 9;
            label6.Text = "Username/Email";
            // 
            // txtAdminLoginPassword
            // 
            txtAdminLoginPassword.Location = new Point(457, 539);
            txtAdminLoginPassword.Multiline = true;
            txtAdminLoginPassword.Name = "txtAdminLoginPassword";
            txtAdminLoginPassword.PasswordChar = '*';
            txtAdminLoginPassword.Size = new Size(403, 32);
            txtAdminLoginPassword.TabIndex = 7;
            txtAdminLoginPassword.Text = "Enter password\r\n";
            // 
            // txtAdminLoginUsername
            // 
            txtAdminLoginUsername.Location = new Point(457, 472);
            txtAdminLoginUsername.Multiline = true;
            txtAdminLoginUsername.Name = "txtAdminLoginUsername";
            txtAdminLoginUsername.Size = new Size(403, 29);
            txtAdminLoginUsername.TabIndex = 6;
            txtAdminLoginUsername.Text = "Enter your username/email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(535, 303);
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
            label3.Location = new Point(599, 368);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 2;
            label3.Text = "Taytay, Rizal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(526, 343);
            label2.Name = "label2";
            label2.Size = new Size(265, 23);
            label2.TabIndex = 1;
            label2.Text = "Transaction Management System";
            // 
            // cmbAdmin
            // 
            cmbAdmin.FormattingEnabled = true;
            cmbAdmin.Location = new Point(590, 398);
            cmbAdmin.Name = "cmbAdmin";
            cmbAdmin.Size = new Size(101, 28);
            cmbAdmin.TabIndex = 15;
            cmbAdmin.Text = "Select role";
            // 
            // FormAdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 739);
            Controls.Add(panelLoginHeader);
            Name = "FormAdminLogin";
            Text = "FormAdminLogin";
            panelLoginHeader.ResumeLayout(false);
            panelLoginHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLoginHeader;
        private Button btnLogin;
        private Label lblSignup;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private TextBox txtLoginPassword;
        private TextBox txtLoginAdmin;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label Admin;
        private TextBox txtLoginUsername;
        private Button btnLoginAdmin;
        private Button btnAdminLogin;
        private TextBox txtAdminLoginPassword;
        private TextBox txtAdminLoginUsername;
        private ComboBox cmbAdmin;
    }
}