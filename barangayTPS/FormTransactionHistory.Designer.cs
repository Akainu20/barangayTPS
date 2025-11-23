namespace barangayTPS
{
    partial class FormTransactionHistory
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
            panel9 = new Panel();
            panelTransactionWelcome = new Panel();
            btnBackAdminDashboard = new Button();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnTransactionHistoryLogout = new Button();
            btnTransactionHistoryDashboard = new Button();
            btnTransactionHistoryTransactionHistory = new Button();
            panelTransactionSidebar = new Panel();
            btnTransactionHistoryBack = new Button();
            btnTransactionHistoryResidentInformation = new Button();
            panelTransactionHistory = new Panel();
            label4 = new Label();
            btnHistoryRefresh = new Button();
            dataGridTransactionHistory = new DataGridView();
            RequestID = new DataGridViewTextBoxColumn();
            ResidentName = new DataGridViewTextBoxColumn();
            DocumentType = new DataGridViewTextBoxColumn();
            DateRequested = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            RequestPurpose = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panelTransactionWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelTransactionSidebar.SuspendLayout();
            panelTransactionHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTransactionHistory).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            // panelTransactionWelcome
            // 
            panelTransactionWelcome.BackColor = Color.SeaGreen;
            panelTransactionWelcome.Controls.Add(btnBackAdminDashboard);
            panelTransactionWelcome.Controls.Add(pictureBox1);
            panelTransactionWelcome.Controls.Add(pictureBox6);
            panelTransactionWelcome.Controls.Add(panel9);
            panelTransactionWelcome.Location = new Point(0, 4);
            panelTransactionWelcome.Margin = new Padding(3, 4, 3, 4);
            panelTransactionWelcome.Name = "panelTransactionWelcome";
            panelTransactionWelcome.Size = new Size(1341, 83);
            panelTransactionWelcome.TabIndex = 17;
            // 
            // btnBackAdminDashboard
            // 
            btnBackAdminDashboard.Location = new Point(1343, 22);
            btnBackAdminDashboard.Name = "btnBackAdminDashboard";
            btnBackAdminDashboard.Size = new Size(94, 29);
            btnBackAdminDashboard.TabIndex = 24;
            btnBackAdminDashboard.Text = "Back";
            btnBackAdminDashboard.UseVisualStyleBackColor = true;
            btnBackAdminDashboard.Click += btnBackAdminDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notification_bell;
            pictureBox1.Location = new Point(1246, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.profile_picture;
            pictureBox6.Location = new Point(1285, 14);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // btnTransactionHistoryLogout
            // 
            btnTransactionHistoryLogout.BackColor = Color.White;
            btnTransactionHistoryLogout.Location = new Point(18, 232);
            btnTransactionHistoryLogout.Name = "btnTransactionHistoryLogout";
            btnTransactionHistoryLogout.Size = new Size(179, 41);
            btnTransactionHistoryLogout.TabIndex = 11;
            btnTransactionHistoryLogout.Text = "Logout\r\n";
            btnTransactionHistoryLogout.UseVisualStyleBackColor = false;
            btnTransactionHistoryLogout.Click += btnTransactionHistoryLogout_Click;
            // 
            // btnTransactionHistoryDashboard
            // 
            btnTransactionHistoryDashboard.BackColor = Color.White;
            btnTransactionHistoryDashboard.Location = new Point(18, 39);
            btnTransactionHistoryDashboard.Name = "btnTransactionHistoryDashboard";
            btnTransactionHistoryDashboard.Size = new Size(179, 41);
            btnTransactionHistoryDashboard.TabIndex = 10;
            btnTransactionHistoryDashboard.Text = "Dashboard";
            btnTransactionHistoryDashboard.UseVisualStyleBackColor = false;
            btnTransactionHistoryDashboard.Click += btnTransactionHistoryDashboard_Click;
            // 
            // btnTransactionHistoryTransactionHistory
            // 
            btnTransactionHistoryTransactionHistory.BackColor = Color.White;
            btnTransactionHistoryTransactionHistory.Location = new Point(18, 107);
            btnTransactionHistoryTransactionHistory.Name = "btnTransactionHistoryTransactionHistory";
            btnTransactionHistoryTransactionHistory.Size = new Size(179, 41);
            btnTransactionHistoryTransactionHistory.TabIndex = 9;
            btnTransactionHistoryTransactionHistory.Text = "Transaction History\r\n";
            btnTransactionHistoryTransactionHistory.UseVisualStyleBackColor = false;
            btnTransactionHistoryTransactionHistory.Click += btnTransactionHistoryTransactionHistory_Click;
            // 
            // panelTransactionSidebar
            // 
            panelTransactionSidebar.BackColor = Color.SeaGreen;
            panelTransactionSidebar.Controls.Add(btnTransactionHistoryBack);
            panelTransactionSidebar.Controls.Add(btnTransactionHistoryResidentInformation);
            panelTransactionSidebar.Controls.Add(btnTransactionHistoryLogout);
            panelTransactionSidebar.Controls.Add(btnTransactionHistoryDashboard);
            panelTransactionSidebar.Controls.Add(btnTransactionHistoryTransactionHistory);
            panelTransactionSidebar.Location = new Point(0, 84);
            panelTransactionSidebar.Name = "panelTransactionSidebar";
            panelTransactionSidebar.Size = new Size(219, 923);
            panelTransactionSidebar.TabIndex = 16;
            // 
            // btnTransactionHistoryBack
            // 
            btnTransactionHistoryBack.Location = new Point(18, 295);
            btnTransactionHistoryBack.Name = "btnTransactionHistoryBack";
            btnTransactionHistoryBack.Size = new Size(179, 42);
            btnTransactionHistoryBack.TabIndex = 33;
            btnTransactionHistoryBack.Text = "Back";
            btnTransactionHistoryBack.UseVisualStyleBackColor = true;
            btnTransactionHistoryBack.Click += btnTransactionHistoryBack_Click;
            // 
            // btnTransactionHistoryResidentInformation
            // 
            btnTransactionHistoryResidentInformation.BackColor = Color.White;
            btnTransactionHistoryResidentInformation.Location = new Point(18, 170);
            btnTransactionHistoryResidentInformation.Name = "btnTransactionHistoryResidentInformation";
            btnTransactionHistoryResidentInformation.Size = new Size(179, 41);
            btnTransactionHistoryResidentInformation.TabIndex = 17;
            btnTransactionHistoryResidentInformation.Text = "Resident Information";
            btnTransactionHistoryResidentInformation.UseVisualStyleBackColor = false;
            btnTransactionHistoryResidentInformation.Click += btnTransactionHistoryResidentInformation_Click;
            // 
            // panelTransactionHistory
            // 
            panelTransactionHistory.BackColor = Color.SeaGreen;
            panelTransactionHistory.Controls.Add(label4);
            panelTransactionHistory.Controls.Add(btnHistoryRefresh);
            panelTransactionHistory.Controls.Add(dataGridTransactionHistory);
            panelTransactionHistory.Location = new Point(225, 257);
            panelTransactionHistory.Name = "panelTransactionHistory";
            panelTransactionHistory.Size = new Size(1101, 702);
            panelTransactionHistory.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 27);
            label4.Name = "label4";
            label4.Size = new Size(274, 28);
            label4.TabIndex = 23;
            label4.Text = "Recent Transaction Request";
            // 
            // btnHistoryRefresh
            // 
            btnHistoryRefresh.Location = new Point(971, 18);
            btnHistoryRefresh.Name = "btnHistoryRefresh";
            btnHistoryRefresh.Size = new Size(116, 37);
            btnHistoryRefresh.TabIndex = 22;
            btnHistoryRefresh.Text = "Refresh";
            btnHistoryRefresh.UseVisualStyleBackColor = true;
            btnHistoryRefresh.Click += btnHistoryRefresh_Click;
            // 
            // dataGridTransactionHistory
            // 
            dataGridTransactionHistory.BackgroundColor = Color.White;
            dataGridTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTransactionHistory.Columns.AddRange(new DataGridViewColumn[] { RequestID, ResidentName, DocumentType, DateRequested, Status, RequestPurpose });
            dataGridTransactionHistory.Location = new Point(7, 66);
            dataGridTransactionHistory.Name = "dataGridTransactionHistory";
            dataGridTransactionHistory.RowHeadersWidth = 51;
            dataGridTransactionHistory.Size = new Size(1087, 624);
            dataGridTransactionHistory.TabIndex = 3;
            dataGridTransactionHistory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RequestID
            // 
            RequestID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestID.HeaderText = "Request ID";
            RequestID.MinimumWidth = 6;
            RequestID.Name = "RequestID";
            // 
            // ResidentName
            // 
            ResidentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ResidentName.HeaderText = "Resident Name";
            ResidentName.MinimumWidth = 6;
            ResidentName.Name = "ResidentName";
            // 
            // DocumentType
            // 
            DocumentType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DocumentType.HeaderText = "Document Type";
            DocumentType.MinimumWidth = 6;
            DocumentType.Name = "DocumentType";
            // 
            // DateRequested
            // 
            DateRequested.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateRequested.HeaderText = "Date";
            DateRequested.MinimumWidth = 6;
            DateRequested.Name = "DateRequested";
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // RequestPurpose
            // 
            RequestPurpose.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RequestPurpose.HeaderText = "Purpose of Request";
            RequestPurpose.MinimumWidth = 6;
            RequestPurpose.Name = "RequestPurpose";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 53);
            label2.Name = "label2";
            label2.Size = new Size(319, 20);
            label2.TabIndex = 4;
            label2.Text = "Overview of barangay transactions and records";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(289, 41);
            label1.TabIndex = 3;
            label1.Text = "Transaction History";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(225, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 87);
            panel3.TabIndex = 14;
            // 
            // FormTransactionHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 971);
            Controls.Add(panelTransactionWelcome);
            Controls.Add(panelTransactionSidebar);
            Controls.Add(panelTransactionHistory);
            Controls.Add(panel3);
            Name = "FormTransactionHistory";
            Text = "FormTransactionHistory";
            panelTransactionWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelTransactionSidebar.ResumeLayout(false);
            panelTransactionHistory.ResumeLayout(false);
            panelTransactionHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTransactionHistory).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel9;
        private Panel panelTransactionWelcome;
        private Button btnTransactionHistoryLogout;
        private Button btnTransactionHistoryDashboard;
        private Button btnTransactionHistoryTransactionHistory;
        private Button btnHistoryRefresh;
        private Panel panelTransactionSidebar;
        private Panel panelTransactionHistory;
        private Label label3;
        private DataGridView dataGridTransactionHistory;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Button btnBackAdminDashboard;
        private Button button1;
        private Label label4;
        private DataGridViewTextBoxColumn RequestID;
        private DataGridViewTextBoxColumn ResidentName;
        private DataGridViewTextBoxColumn DocumentType;
        private DataGridViewTextBoxColumn DateRequested;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn RequestPurpose;
        private Button btnTransactionHistoryResidentInformation;
        private Button btnTransactionHistoryBack;
    }
}