namespace barangayTPS
{
    partial class FormResidentInformation
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
            lblAdminWelcome = new Label();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel9 = new Panel();
            panelAdminWelcome = new Panel();
            btnResidentInfoLogout = new Button();
            btnResidentInfoAdminDashboard = new Button();
            btnResidentInfoTransactionHistory = new Button();
            panelAdminSidebar = new Panel();
            btnResidentInformationBack = new Button();
            btnResidentInfoResidentInformation = new Button();
            label4 = new Label();
            panelResidentInformation = new Panel();
            btnResidentInfoRefresh = new Button();
            dataGridResidentData = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelAdminWelcome.SuspendLayout();
            panelAdminSidebar.SuspendLayout();
            panelResidentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResidentData).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdminWelcome
            // 
            lblAdminWelcome.AutoSize = true;
            lblAdminWelcome.BackColor = Color.SeaGreen;
            lblAdminWelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminWelcome.ForeColor = Color.White;
            lblAdminWelcome.Location = new Point(454, 21);
            lblAdminWelcome.Name = "lblAdminWelcome";
            lblAdminWelcome.Size = new Size(475, 46);
            lblAdminWelcome.TabIndex = 12;
            lblAdminWelcome.Text = "Welcome to Your Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notification_bell;
            pictureBox1.Location = new Point(1247, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.profile_picture;
            pictureBox6.Location = new Point(1286, 24);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Gold;
            panel9.Location = new Point(0, 75);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(1575, 16);
            panel9.TabIndex = 2;
            // 
            // panelAdminWelcome
            // 
            panelAdminWelcome.BackColor = Color.SeaGreen;
            panelAdminWelcome.Controls.Add(lblAdminWelcome);
            panelAdminWelcome.Controls.Add(pictureBox1);
            panelAdminWelcome.Controls.Add(pictureBox6);
            panelAdminWelcome.Controls.Add(panel9);
            panelAdminWelcome.Location = new Point(2, -15);
            panelAdminWelcome.Margin = new Padding(3, 4, 3, 4);
            panelAdminWelcome.Name = "panelAdminWelcome";
            panelAdminWelcome.Size = new Size(1339, 83);
            panelAdminWelcome.TabIndex = 12;
            // 
            // btnResidentInfoLogout
            // 
            btnResidentInfoLogout.BackColor = Color.White;
            btnResidentInfoLogout.Location = new Point(18, 233);
            btnResidentInfoLogout.Name = "btnResidentInfoLogout";
            btnResidentInfoLogout.Size = new Size(179, 41);
            btnResidentInfoLogout.TabIndex = 11;
            btnResidentInfoLogout.Text = "Logout\r\n";
            btnResidentInfoLogout.UseVisualStyleBackColor = false;
            btnResidentInfoLogout.Click += btnAdminLogout_Click;
            // 
            // btnResidentInfoAdminDashboard
            // 
            btnResidentInfoAdminDashboard.BackColor = Color.White;
            btnResidentInfoAdminDashboard.Location = new Point(18, 39);
            btnResidentInfoAdminDashboard.Name = "btnResidentInfoAdminDashboard";
            btnResidentInfoAdminDashboard.Size = new Size(179, 41);
            btnResidentInfoAdminDashboard.TabIndex = 10;
            btnResidentInfoAdminDashboard.Text = "Dashboard";
            btnResidentInfoAdminDashboard.UseVisualStyleBackColor = false;
            btnResidentInfoAdminDashboard.Click += btnResidentInfoAdminDashboard_Click;
            // 
            // btnResidentInfoTransactionHistory
            // 
            btnResidentInfoTransactionHistory.BackColor = Color.White;
            btnResidentInfoTransactionHistory.Location = new Point(18, 107);
            btnResidentInfoTransactionHistory.Name = "btnResidentInfoTransactionHistory";
            btnResidentInfoTransactionHistory.Size = new Size(179, 41);
            btnResidentInfoTransactionHistory.TabIndex = 9;
            btnResidentInfoTransactionHistory.Text = "Transaction History\r\n";
            btnResidentInfoTransactionHistory.UseVisualStyleBackColor = false;
            btnResidentInfoTransactionHistory.Click += btnResidentInfoTransactionHistory_Click;
            // 
            // panelAdminSidebar
            // 
            panelAdminSidebar.BackColor = Color.SeaGreen;
            panelAdminSidebar.Controls.Add(btnResidentInformationBack);
            panelAdminSidebar.Controls.Add(btnResidentInfoResidentInformation);
            panelAdminSidebar.Controls.Add(btnResidentInfoLogout);
            panelAdminSidebar.Controls.Add(btnResidentInfoAdminDashboard);
            panelAdminSidebar.Controls.Add(btnResidentInfoTransactionHistory);
            panelAdminSidebar.Location = new Point(-2, 63);
            panelAdminSidebar.Name = "panelAdminSidebar";
            panelAdminSidebar.Size = new Size(219, 923);
            panelAdminSidebar.TabIndex = 11;
            // 
            // btnResidentInformationBack
            // 
            btnResidentInformationBack.Location = new Point(18, 297);
            btnResidentInformationBack.Name = "btnResidentInformationBack";
            btnResidentInformationBack.Size = new Size(179, 42);
            btnResidentInformationBack.TabIndex = 34;
            btnResidentInformationBack.Text = "Back";
            btnResidentInformationBack.UseVisualStyleBackColor = true;
            btnResidentInformationBack.Click += btnResidentInformationBack_Click;
            // 
            // btnResidentInfoResidentInformation
            // 
            btnResidentInfoResidentInformation.BackColor = Color.White;
            btnResidentInfoResidentInformation.Location = new Point(18, 171);
            btnResidentInfoResidentInformation.Name = "btnResidentInfoResidentInformation";
            btnResidentInfoResidentInformation.Size = new Size(179, 41);
            btnResidentInfoResidentInformation.TabIndex = 16;
            btnResidentInfoResidentInformation.Text = "Resident Information";
            btnResidentInfoResidentInformation.UseVisualStyleBackColor = false;
            btnResidentInfoResidentInformation.Click += btnResidentInfoResidentInformation_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 24);
            label4.Name = "label4";
            label4.Size = new Size(247, 35);
            label4.TabIndex = 9;
            label4.Text = "Resident Iformation";
            // 
            // panelResidentInformation
            // 
            panelResidentInformation.BackColor = Color.SeaGreen;
            panelResidentInformation.Controls.Add(btnResidentInfoRefresh);
            panelResidentInformation.Controls.Add(label4);
            panelResidentInformation.Controls.Add(dataGridResidentData);
            panelResidentInformation.Location = new Point(223, 234);
            panelResidentInformation.Name = "panelResidentInformation";
            panelResidentInformation.Size = new Size(1106, 550);
            panelResidentInformation.TabIndex = 10;
            // 
            // btnResidentInfoRefresh
            // 
            btnResidentInfoRefresh.Location = new Point(975, 26);
            btnResidentInfoRefresh.Name = "btnResidentInfoRefresh";
            btnResidentInfoRefresh.Size = new Size(120, 37);
            btnResidentInfoRefresh.TabIndex = 14;
            btnResidentInfoRefresh.Text = "Refresh";
            btnResidentInfoRefresh.UseVisualStyleBackColor = true;
            btnResidentInfoRefresh.Click += btnResidentInfoRefresh_Click;
            // 
            // dataGridResidentData
            // 
            dataGridResidentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridResidentData.BackgroundColor = Color.White;
            dataGridResidentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResidentData.Location = new Point(10, 79);
            dataGridResidentData.Name = "dataGridResidentData";
            dataGridResidentData.ReadOnly = true;
            dataGridResidentData.RowHeadersWidth = 51;
            dataGridResidentData.Size = new Size(1085, 362);
            dataGridResidentData.TabIndex = 3;
            dataGridResidentData.CellContentClick += dataGridResidentData_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 4;
            label2.Text = "Overview of Resident Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(317, 41);
            label1.TabIndex = 3;
            label1.Text = "Resident Information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(223, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(1106, 87);
            panel3.TabIndex = 9;
            // 
            // FormResidentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 971);
            Controls.Add(panelAdminWelcome);
            Controls.Add(panelAdminSidebar);
            Controls.Add(panelResidentInformation);
            Controls.Add(panel3);
            Name = "FormResidentInformation";
            Text = "FormResidentInformation";
            Load += FormResidentInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelAdminWelcome.ResumeLayout(false);
            panelAdminWelcome.PerformLayout();
            panelAdminSidebar.ResumeLayout(false);
            panelResidentInformation.ResumeLayout(false);
            panelResidentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridResidentData).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblAdminWelcome;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private Panel panel9;
        private Panel panelAdminWelcome;
        private Button btnResidentInfoLogout;
        private Button btnResidentInfoAdminDashboard;
        private Button btnResidentInfoTransactionHistory;
        private Panel panelAdminSidebar;
        private Label label4;
        private Panel panelResidentInformation;
        private DataGridView dataGridResidentData;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Button btnResidentInfoResidentInformation;
        private Button btnResidentInformationBack;
        private Button btnResidentInfoRefresh;
    }
}