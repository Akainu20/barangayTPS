namespace barangayTPS
{
    partial class FormSignup
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
            panelSignupHeader = new Panel();
            pictureBox1 = new PictureBox();
            btnCreateAccount = new Button();
            label8 = new Label();
            txtSignupPassword = new TextBox();
            label6 = new Label();
            txtSignupUsername = new TextBox();
            lblBrgySanJuan = new Label();
            lblTaytayRizal = new Label();
            lblTransactionManagementSystem = new Label();
            panelSignupHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSignupHeader
            // 
            panelSignupHeader.BackColor = Color.SeaGreen;
            panelSignupHeader.Controls.Add(pictureBox1);
            panelSignupHeader.Controls.Add(btnCreateAccount);
            panelSignupHeader.Controls.Add(label8);
            panelSignupHeader.Controls.Add(txtSignupPassword);
            panelSignupHeader.Controls.Add(label6);
            panelSignupHeader.Controls.Add(txtSignupUsername);
            panelSignupHeader.Controls.Add(lblBrgySanJuan);
            panelSignupHeader.Controls.Add(lblTaytayRizal);
            panelSignupHeader.Controls.Add(lblTransactionManagementSystem);
            panelSignupHeader.Location = new Point(-104, -32);
            panelSignupHeader.Name = "panelSignupHeader";
            panelSignupHeader.Size = new Size(1275, 803);
            panelSignupHeader.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.logo_removebg_preview;
            pictureBox1.Location = new Point(603, 139);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.White;
            btnCreateAccount.Location = new Point(589, 552);
            btnCreateAccount.Margin = new Padding(3, 4, 3, 4);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(131, 39);
            btnCreateAccount.TabIndex = 15;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(456, 510);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 14;
            label8.Text = "Confirm Password";
            // 
            // txtSignupPassword
            // 
            txtSignupPassword.Location = new Point(456, 475);
            txtSignupPassword.Multiline = true;
            txtSignupPassword.Name = "txtSignupPassword";
            txtSignupPassword.PasswordChar = '*';
            txtSignupPassword.Size = new Size(422, 32);
            txtSignupPassword.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(456, 434);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 9;
            label6.Text = "Username/Email";
            // 
            // txtSignupUsername
            // 
            txtSignupUsername.Location = new Point(456, 402);
            txtSignupUsername.Multiline = true;
            txtSignupUsername.Name = "txtSignupUsername";
            txtSignupUsername.Size = new Size(422, 29);
            txtSignupUsername.TabIndex = 6;
            txtSignupUsername.Text = "Create admin username/email";
            // 
            // lblBrgySanJuan
            // 
            lblBrgySanJuan.AutoSize = true;
            lblBrgySanJuan.BackColor = Color.Transparent;
            lblBrgySanJuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrgySanJuan.ForeColor = Color.White;
            lblBrgySanJuan.Location = new Point(541, 253);
            lblBrgySanJuan.Name = "lblBrgySanJuan";
            lblBrgySanJuan.Size = new Size(265, 38);
            lblBrgySanJuan.TabIndex = 0;
            lblBrgySanJuan.Text = "Barangay San Juan";
            // 
            // lblTaytayRizal
            // 
            lblTaytayRizal.AutoSize = true;
            lblTaytayRizal.BackColor = Color.Transparent;
            lblTaytayRizal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaytayRizal.ForeColor = Color.White;
            lblTaytayRizal.ImageAlign = ContentAlignment.MiddleLeft;
            lblTaytayRizal.Location = new Point(617, 325);
            lblTaytayRizal.Name = "lblTaytayRizal";
            lblTaytayRizal.Size = new Size(103, 23);
            lblTaytayRizal.TabIndex = 2;
            lblTaytayRizal.Text = "Taytay, Rizal";
            // 
            // lblTransactionManagementSystem
            // 
            lblTransactionManagementSystem.AutoSize = true;
            lblTransactionManagementSystem.BackColor = Color.Transparent;
            lblTransactionManagementSystem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionManagementSystem.ForeColor = Color.White;
            lblTransactionManagementSystem.ImageAlign = ContentAlignment.MiddleLeft;
            lblTransactionManagementSystem.Location = new Point(532, 293);
            lblTransactionManagementSystem.Name = "lblTransactionManagementSystem";
            lblTransactionManagementSystem.Size = new Size(265, 23);
            lblTransactionManagementSystem.TabIndex = 1;
            lblTransactionManagementSystem.Text = "Transaction Management System";
            lblTransactionManagementSystem.Click += lblTransactionManagementSystem_Click;
            // 
            // FormSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 739);
            Controls.Add(panelSignupHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSignup";
            Text = "FormSignup";
            panelSignupHeader.ResumeLayout(false);
            panelSignupHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSignupHeader;
        private Label label6;
        private TextBox txtSignupUsername;
        private Label lblBrgySanJuan;
        private Label lblTaytayRizal;
        private Label lblTransactionManagementSystem;
        private Label label8;
        private TextBox txtSignupPassword;
        private Button btnCreateAccount;
        private PictureBox pictureBox1;
    }
}