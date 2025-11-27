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
            dataGridRecentRequest = new DataGridView();
            panelRecentRequest = new Panel();
            label4 = new Label();
            btnRejectedRequest = new Button();
            btnRecentRequestRefresh = new Button();
            btnCompletedRequest = new Button();
            btnPendingRequest = new Button();
            btnTotalRequest = new Button();
            panelAdminSidebar = new Panel();
            btnResidentInfo = new Button();
            btnAdminLogout = new Button();
            btnAdminDashboard = new Button();
            btnTransactionHistory = new Button();
            panelAdminWelcome = new Panel();
            lblAdminWelcome = new Label();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel9 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRecentRequest).BeginInit();
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
            panel3.Location = new Point(220, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(1106, 87);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 53);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
            label1.TabIndex = 3;
            label1.Text = "Dashboard";
            // 
            // dataGridRecentRequest
            // 
            dataGridRecentRequest.BackgroundColor = Color.White;
            dataGridRecentRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRecentRequest.Location = new Point(10, 79);
            dataGridRecentRequest.Name = "dataGridRecentRequest";
            dataGridRecentRequest.RowHeadersWidth = 51;
            dataGridRecentRequest.Size = new Size(1085, 362);
            dataGridRecentRequest.TabIndex = 3;
            dataGridRecentRequest.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelRecentRequest
            // 
            panelRecentRequest.BackColor = Color.SeaGreen;
            panelRecentRequest.Controls.Add(label4);
            panelRecentRequest.Controls.Add(btnRejectedRequest);
            panelRecentRequest.Controls.Add(btnRecentRequestRefresh);
            panelRecentRequest.Controls.Add(btnCompletedRequest);
            panelRecentRequest.Controls.Add(btnPendingRequest);
            panelRecentRequest.Controls.Add(btnTotalRequest);
            panelRecentRequest.Controls.Add(dataGridRecentRequest);
            panelRecentRequest.Location = new Point(220, 250);
            panelRecentRequest.Name = "panelRecentRequest";
            panelRecentRequest.Size = new Size(1106, 550);
            panelRecentRequest.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 26);
            label4.Name = "label4";
            label4.Size = new Size(208, 35);
            label4.TabIndex = 9;
            label4.Text = "Recent Requests";
            // 
            // btnRejectedRequest
            // 
            btnRejectedRequest.Location = new Point(826, 462);
            btnRejectedRequest.Name = "btnRejectedRequest";
            btnRejectedRequest.Size = new Size(158, 42);
            btnRejectedRequest.TabIndex = 12;
            btnRejectedRequest.Text = "Rejected Requests";
            btnRejectedRequest.UseVisualStyleBackColor = true;
            btnRejectedRequest.Click += btnRejectedRequest_Click;
            // 
            // btnRecentRequestRefresh
            // 
            btnRecentRequestRefresh.Location = new Point(975, 22);
            btnRecentRequestRefresh.Name = "btnRecentRequestRefresh";
            btnRecentRequestRefresh.Size = new Size(120, 37);
            btnRecentRequestRefresh.TabIndex = 13;
            btnRecentRequestRefresh.Text = "Refresh";
            btnRecentRequestRefresh.UseVisualStyleBackColor = true;
            btnRecentRequestRefresh.Click += btnRecentRequestRefresh_Click;
            // 
            // btnCompletedRequest
            // 
            btnCompletedRequest.Location = new Point(591, 462);
            btnCompletedRequest.Name = "btnCompletedRequest";
            btnCompletedRequest.Size = new Size(158, 42);
            btnCompletedRequest.TabIndex = 11;
            btnCompletedRequest.Text = "Completed Requests";
            btnCompletedRequest.UseVisualStyleBackColor = true;
            btnCompletedRequest.Click += btnCompletedRequest_Click;
            // 
            // btnPendingRequest
            // 
            btnPendingRequest.Location = new Point(356, 462);
            btnPendingRequest.Name = "btnPendingRequest";
            btnPendingRequest.Size = new Size(158, 42);
            btnPendingRequest.TabIndex = 9;
            btnPendingRequest.Text = "Pending Requests";
            btnPendingRequest.UseVisualStyleBackColor = true;
            btnPendingRequest.Click += btnPendingRequest_Click;
            // 
            // btnTotalRequest
            // 
            btnTotalRequest.Location = new Point(128, 462);
            btnTotalRequest.Name = "btnTotalRequest";
            btnTotalRequest.Size = new Size(158, 42);
            btnTotalRequest.TabIndex = 10;
            btnTotalRequest.Text = "Total Requests";
            btnTotalRequest.UseVisualStyleBackColor = true;
            btnTotalRequest.Click += btnTotalRequest_Click;
            // 
            // panelAdminSidebar
            // 
            panelAdminSidebar.BackColor = Color.SeaGreen;
            panelAdminSidebar.Controls.Add(btnResidentInfo);
            panelAdminSidebar.Controls.Add(btnAdminLogout);
            panelAdminSidebar.Controls.Add(btnAdminDashboard);
            panelAdminSidebar.Controls.Add(btnTransactionHistory);
            panelAdminSidebar.Location = new Point(-5, 79);
            panelAdminSidebar.Name = "panelAdminSidebar";
            panelAdminSidebar.Size = new Size(219, 923);
            panelAdminSidebar.TabIndex = 7;
            // 
            // btnResidentInfo
            // 
            btnResidentInfo.BackColor = Color.White;
            btnResidentInfo.Location = new Point(18, 159);
            btnResidentInfo.Name = "btnResidentInfo";
            btnResidentInfo.Size = new Size(179, 41);
            btnResidentInfo.TabIndex = 12;
            btnResidentInfo.Text = "Resident Information";
            btnResidentInfo.UseVisualStyleBackColor = false;
            btnResidentInfo.Click += btnResidentInfo_Click;
            // 
            // btnAdminLogout
            // 
            btnAdminLogout.BackColor = Color.White;
            btnAdminLogout.Location = new Point(18, 220);
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
            btnTransactionHistory.Location = new Point(18, 99);
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
            panelAdminWelcome.Size = new Size(1339, 83);
            panelAdminWelcome.TabIndex = 8;
            // 
            // lblAdminWelcome
            // 
            lblAdminWelcome.AutoSize = true;
            lblAdminWelcome.BackColor = Color.SeaGreen;
            lblAdminWelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminWelcome.ForeColor = Color.White;
            lblAdminWelcome.Location = new Point(462, 17);
            lblAdminWelcome.Name = "lblAdminWelcome";
            lblAdminWelcome.Size = new Size(475, 46);
            lblAdminWelcome.TabIndex = 12;
            lblAdminWelcome.Text = "Welcome to Your Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notification_bell;
            pictureBox1.Location = new Point(1247, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.profile_picture;
            pictureBox6.Location = new Point(1286, 17);
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
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 971);
            Controls.Add(panelAdminWelcome);
            Controls.Add(panelAdminSidebar);
            Controls.Add(panelRecentRequest);
            Controls.Add(panel3);
            Name = "FormAdminDashboard";
            Text = "FormAdminDashboard";
            Load += FormAdminDashboard_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRecentRequest).EndInit();
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
        private DataGridView dataGridRecentRequest;
        private Label label2;
        private Panel panelRecentRequest;
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
        private Button btnRecentRequestRefresh;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Label lblAdminWelcome;
        private Label label4;
        private Button btnResidentInfo;
    }
}