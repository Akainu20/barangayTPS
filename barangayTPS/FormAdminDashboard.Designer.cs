namespace barangayTPS
{
    partial class FormAdminDashboard
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
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            RequestID = new DataGridViewTextBoxColumn();
            ResidentName = new DataGridViewTextBoxColumn();
            DocumentType = new DataGridViewTextBoxColumn();
            DateRequested = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panelRecentRequest = new Panel();
            label3 = new Label();
            panelAdminSidebar = new Panel();
            btnAdminLogout = new Button();
            btnAdminDashboard = new Button();
            btnTransactionHistory = new Button();
            panelAdminWelcome = new Panel();
            lblAdminWelcome = new Label();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel9 = new Panel();
            btnPendingRequest = new Button();
            btnTotalRequest = new Button();
            btnCompletedRequest = new Button();
            btnRejectedRequest = new Button();
            btnRefresh = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelRecentRequest.SuspendLayout();
            panelAdminSidebar.SuspendLayout();
            panelAdminWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(422, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 87);
            panel3.TabIndex = 2;
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
            label1.Size = new Size(171, 41);
            label1.TabIndex = 3;
            label1.Text = "Dashboard";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RequestID, ResidentName, DocumentType, DateRequested, Status });
            dataGridView1.Location = new Point(3, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(878, 354);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RequestID
            // 
            RequestID.HeaderText = "Request ID";
            RequestID.MinimumWidth = 6;
            RequestID.Name = "RequestID";
            RequestID.Width = 125;
            // 
            // ResidentName
            // 
            ResidentName.HeaderText = "Resident Name";
            ResidentName.MinimumWidth = 6;
            ResidentName.Name = "ResidentName";
            ResidentName.Width = 125;
            // 
            // DocumentType
            // 
            DocumentType.HeaderText = "Document Type";
            DocumentType.MinimumWidth = 6;
            DocumentType.Name = "DocumentType";
            DocumentType.Width = 125;
            // 
            // DateRequested
            // 
            DateRequested.HeaderText = "Date";
            DateRequested.MinimumWidth = 6;
            DateRequested.Name = "DateRequested";
            DateRequested.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // panelRecentRequest
            // 
            panelRecentRequest.BackColor = Color.SeaGreen;
            panelRecentRequest.Controls.Add(label3);
            panelRecentRequest.Controls.Add(dataGridView1);
            panelRecentRequest.Location = new Point(422, 280);
            panelRecentRequest.Name = "panelRecentRequest";
            panelRecentRequest.Size = new Size(885, 430);
            panelRecentRequest.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 24);
            label3.Name = "label3";
            label3.Size = new Size(134, 22);
            label3.TabIndex = 5;
            label3.Text = "Recent Requests";
            // 
            // panelAdminSidebar
            // 
            panelAdminSidebar.BackColor = Color.SeaGreen;
            panelAdminSidebar.Controls.Add(btnAdminLogout);
            panelAdminSidebar.Controls.Add(btnAdminDashboard);
            panelAdminSidebar.Controls.Add(btnTransactionHistory);
            panelAdminSidebar.Location = new Point(-5, 79);
            panelAdminSidebar.Name = "panelAdminSidebar";
            panelAdminSidebar.Size = new Size(219, 923);
            panelAdminSidebar.TabIndex = 7;
            // 
            // btnAdminLogout
            // 
            btnAdminLogout.BackColor = Color.White;
            btnAdminLogout.Location = new Point(18, 171);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(179, 41);
            btnAdminLogout.TabIndex = 11;
            btnAdminLogout.Text = "Logout\r\n";
            btnAdminLogout.UseVisualStyleBackColor = false;
            btnAdminLogout.Click += btnAdminLogout_Click;
            // 
            // btnAdminDashboard
            // 
            btnAdminDashboard.BackColor = Color.White;
            btnAdminDashboard.Location = new Point(18, 39);
            btnAdminDashboard.Name = "btnAdminDashboard";
            btnAdminDashboard.Size = new Size(179, 41);
            btnAdminDashboard.TabIndex = 10;
            btnAdminDashboard.Text = "Dashboard";
            btnAdminDashboard.UseVisualStyleBackColor = false;
            btnAdminDashboard.Click += btnAdminDashboard_Click;
            // 
            // btnTransactionHistory
            // 
            btnTransactionHistory.BackColor = Color.White;
            btnTransactionHistory.Location = new Point(18, 107);
            btnTransactionHistory.Name = "btnTransactionHistory";
            btnTransactionHistory.Size = new Size(179, 41);
            btnTransactionHistory.TabIndex = 9;
            btnTransactionHistory.Text = "Transaction History\r\n";
            btnTransactionHistory.UseVisualStyleBackColor = false;
            btnTransactionHistory.Click += btnTransactionHistory_Click;
            // 
            // panelAdminWelcome
            // 
            panelAdminWelcome.BackColor = Color.SeaGreen;
            panelAdminWelcome.Controls.Add(lblAdminWelcome);
            panelAdminWelcome.Controls.Add(pictureBox1);
            panelAdminWelcome.Controls.Add(pictureBox6);
            panelAdminWelcome.Controls.Add(panel9);
            panelAdminWelcome.Location = new Point(-1, 1);
            panelAdminWelcome.Margin = new Padding(3, 4, 3, 4);
            panelAdminWelcome.Name = "panelAdminWelcome";
            panelAdminWelcome.Size = new Size(1489, 83);
            panelAdminWelcome.TabIndex = 8;
            // 
            // lblAdminWelcome
            // 
            lblAdminWelcome.AutoSize = true;
            lblAdminWelcome.BackColor = Color.SeaGreen;
            lblAdminWelcome.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminWelcome.ForeColor = Color.White;
            lblAdminWelcome.Location = new Point(160, 8);
            lblAdminWelcome.Name = "lblAdminWelcome";
            lblAdminWelcome.Size = new Size(616, 60);
            lblAdminWelcome.TabIndex = 12;
            lblAdminWelcome.Text = "Welcome to Your Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notification_bell;
            pictureBox1.Location = new Point(1282, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.profile_picture;
            pictureBox6.Location = new Point(16, 22);
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
            // btnPendingRequest
            // 
            btnPendingRequest.Location = new Point(672, 731);
            btnPendingRequest.Name = "btnPendingRequest";
            btnPendingRequest.Size = new Size(166, 62);
            btnPendingRequest.TabIndex = 9;
            btnPendingRequest.Text = "Pending Requests";
            btnPendingRequest.UseVisualStyleBackColor = true;
            // 
            // btnTotalRequest
            // 
            btnTotalRequest.Location = new Point(441, 731);
            btnTotalRequest.Name = "btnTotalRequest";
            btnTotalRequest.Size = new Size(166, 62);
            btnTotalRequest.TabIndex = 10;
            btnTotalRequest.Text = "Total Requests";
            btnTotalRequest.UseVisualStyleBackColor = true;
            // 
            // btnCompletedRequest
            // 
            btnCompletedRequest.Location = new Point(892, 731);
            btnCompletedRequest.Name = "btnCompletedRequest";
            btnCompletedRequest.Size = new Size(166, 62);
            btnCompletedRequest.TabIndex = 11;
            btnCompletedRequest.Text = "Completed Requests";
            btnCompletedRequest.UseVisualStyleBackColor = true;
            // 
            // btnRejectedRequest
            // 
            btnRejectedRequest.Location = new Point(1094, 731);
            btnRejectedRequest.Name = "btnRejectedRequest";
            btnRejectedRequest.Size = new Size(166, 62);
            btnRejectedRequest.TabIndex = 12;
            btnRejectedRequest.Text = "Rejected Requests";
            btnRejectedRequest.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(422, 234);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(163, 40);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 900);
            Controls.Add(btnRefresh);
            Controls.Add(btnRejectedRequest);
            Controls.Add(btnCompletedRequest);
            Controls.Add(btnTotalRequest);
            Controls.Add(btnPendingRequest);
            Controls.Add(panelAdminWelcome);
            Controls.Add(panelAdminSidebar);
            Controls.Add(panelRecentRequest);
            Controls.Add(panel3);
            Name = "FormAdminDashboard";
            Text = "FormAdminDashboard";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelRecentRequest.ResumeLayout(false);
            panelRecentRequest.PerformLayout();
            panelAdminSidebar.ResumeLayout(false);
            panelAdminWelcome.ResumeLayout(false);
            panelAdminWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RequestID;
        private DataGridViewTextBoxColumn ResidentName;
        private DataGridViewTextBoxColumn DocumentType;
        private DataGridViewTextBoxColumn DateRequested;
        private DataGridViewTextBoxColumn Status;
        private Label label2;
        private Panel panelRecentRequest;
        private Label label3;
        private Panel panelAdminSidebar;
        private Panel panelAdminWelcome;
        private Panel panel9;
        private Button btnAdminLogout;
        private Button btnAdminDashboard;
        private Button btnTransactionHistory;
        private Button btnPendingRequest;
        private Button btnTotalRequest;
        private Button btnCompletedRequest;
        private Button btnRejectedRequest;
        private Button btnRefresh;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Label lblAdminWelcome;
    }
}