namespace barangayTPS
{
    partial class FormDocumentStatus
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
            btnDocumentStatusLogout = new Button();
            btnDocumentStatusDashboard = new Button();
            btnDocumentStatusTransactionHistory = new Button();
            panelDocumentStatusWelcome = new Panel();
            btnBackToAdminDashboard = new Button();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            paneDocumentsStatusSidebar = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            txtRequestID = new TextBox();
            txtResidentName = new TextBox();
            txtDate = new TextBox();
            txtDocType = new TextBox();
            txtStatus = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAccept = new Button();
            btnMarkAsReady = new Button();
            btnReject = new Button();
            btnMarkAsComplete = new Button();
            panelDocumentStatusWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            paneDocumentsStatusSidebar.SuspendLayout();
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
            // btnDocumentStatusLogout
            // 
            btnDocumentStatusLogout.BackColor = Color.White;
            btnDocumentStatusLogout.Location = new Point(18, 171);
            btnDocumentStatusLogout.Name = "btnDocumentStatusLogout";
            btnDocumentStatusLogout.Size = new Size(179, 41);
            btnDocumentStatusLogout.TabIndex = 11;
            btnDocumentStatusLogout.Text = "Logout\r\n";
            btnDocumentStatusLogout.UseVisualStyleBackColor = false;
            btnDocumentStatusLogout.Click += btnDocumentStatusLogout_Click;
            // 
            // btnDocumentStatusDashboard
            // 
            btnDocumentStatusDashboard.BackColor = Color.White;
            btnDocumentStatusDashboard.Location = new Point(18, 39);
            btnDocumentStatusDashboard.Name = "btnDocumentStatusDashboard";
            btnDocumentStatusDashboard.Size = new Size(179, 41);
            btnDocumentStatusDashboard.TabIndex = 10;
            btnDocumentStatusDashboard.Text = "Dashboard";
            btnDocumentStatusDashboard.UseVisualStyleBackColor = false;
            btnDocumentStatusDashboard.Click += btnDocumentStatusDashboard_Click;
            // 
            // btnDocumentStatusTransactionHistory
            // 
            btnDocumentStatusTransactionHistory.BackColor = Color.White;
            btnDocumentStatusTransactionHistory.Location = new Point(18, 107);
            btnDocumentStatusTransactionHistory.Name = "btnDocumentStatusTransactionHistory";
            btnDocumentStatusTransactionHistory.Size = new Size(179, 41);
            btnDocumentStatusTransactionHistory.TabIndex = 9;
            btnDocumentStatusTransactionHistory.Text = "Transaction History\r\n";
            btnDocumentStatusTransactionHistory.UseVisualStyleBackColor = false;
            btnDocumentStatusTransactionHistory.Click += btnDocumentStatusTransactionHistory_Click;
            // 
            // panelDocumentStatusWelcome
            // 
            panelDocumentStatusWelcome.BackColor = Color.SeaGreen;
            panelDocumentStatusWelcome.Controls.Add(btnBackToAdminDashboard);
            panelDocumentStatusWelcome.Controls.Add(pictureBox1);
            panelDocumentStatusWelcome.Controls.Add(pictureBox6);
            panelDocumentStatusWelcome.Controls.Add(panel9);
            panelDocumentStatusWelcome.Location = new Point(-6, -1);
            panelDocumentStatusWelcome.Margin = new Padding(3, 4, 3, 4);
            panelDocumentStatusWelcome.Name = "panelDocumentStatusWelcome";
            panelDocumentStatusWelcome.Size = new Size(1489, 83);
            panelDocumentStatusWelcome.TabIndex = 16;
            // 
            // btnBackToAdminDashboard
            // 
            btnBackToAdminDashboard.Location = new Point(1359, 22);
            btnBackToAdminDashboard.Name = "btnBackToAdminDashboard";
            btnBackToAdminDashboard.Size = new Size(94, 29);
            btnBackToAdminDashboard.TabIndex = 32;
            btnBackToAdminDashboard.Text = "Back";
            btnBackToAdminDashboard.UseVisualStyleBackColor = true;
            btnBackToAdminDashboard.Click += btnBackToAdminDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notification_bell;
            pictureBox1.Location = new Point(1320, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.profile_picture;
            pictureBox6.Location = new Point(18, 21);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // paneDocumentsStatusSidebar
            // 
            paneDocumentsStatusSidebar.BackColor = Color.SeaGreen;
            paneDocumentsStatusSidebar.Controls.Add(btnDocumentStatusLogout);
            paneDocumentsStatusSidebar.Controls.Add(btnDocumentStatusDashboard);
            paneDocumentsStatusSidebar.Controls.Add(btnDocumentStatusTransactionHistory);
            paneDocumentsStatusSidebar.Location = new Point(-10, 77);
            paneDocumentsStatusSidebar.Name = "paneDocumentsStatusSidebar";
            paneDocumentsStatusSidebar.Size = new Size(219, 923);
            paneDocumentsStatusSidebar.TabIndex = 15;
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
            label1.Size = new Size(261, 41);
            label1.TabIndex = 3;
            label1.Text = "Document Status";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(417, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 87);
            panel3.TabIndex = 13;
            // 
            // txtRequestID
            // 
            txtRequestID.Location = new Point(417, 276);
            txtRequestID.Multiline = true;
            txtRequestID.Name = "txtRequestID";
            txtRequestID.Size = new Size(132, 37);
            txtRequestID.TabIndex = 17;
            // 
            // txtResidentName
            // 
            txtResidentName.Location = new Point(659, 276);
            txtResidentName.Multiline = true;
            txtResidentName.Name = "txtResidentName";
            txtResidentName.Size = new Size(278, 37);
            txtResidentName.TabIndex = 18;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(417, 374);
            txtDate.Multiline = true;
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(132, 34);
            txtDate.TabIndex = 19;
            // 
            // txtDocType
            // 
            txtDocType.Location = new Point(991, 276);
            txtDocType.Multiline = true;
            txtDocType.Name = "txtDocType";
            txtDocType.Size = new Size(311, 37);
            txtDocType.TabIndex = 20;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(659, 374);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(145, 34);
            txtStatus.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 248);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 22;
            label3.Text = "Request ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(659, 248);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 23;
            label4.Text = "Resident Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(991, 258);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 24;
            label5.Text = "Document Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 351);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 25;
            label6.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(659, 351);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 26;
            label7.Text = "Status";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.SeaGreen;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(417, 484);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(150, 52);
            btnAccept.TabIndex = 27;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            // 
            // btnMarkAsReady
            // 
            btnMarkAsReady.BackColor = Color.SeaGreen;
            btnMarkAsReady.ForeColor = Color.White;
            btnMarkAsReady.Location = new Point(630, 484);
            btnMarkAsReady.Name = "btnMarkAsReady";
            btnMarkAsReady.Size = new Size(150, 52);
            btnMarkAsReady.TabIndex = 28;
            btnMarkAsReady.Text = "Mark as Ready";
            btnMarkAsReady.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.SeaGreen;
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(831, 484);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(150, 52);
            btnReject.TabIndex = 29;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            // 
            // btnMarkAsComplete
            // 
            btnMarkAsComplete.BackColor = Color.SeaGreen;
            btnMarkAsComplete.ForeColor = Color.White;
            btnMarkAsComplete.Location = new Point(1032, 484);
            btnMarkAsComplete.Name = "btnMarkAsComplete";
            btnMarkAsComplete.Size = new Size(150, 52);
            btnMarkAsComplete.TabIndex = 30;
            btnMarkAsComplete.Text = "Mark as Complete";
            btnMarkAsComplete.UseVisualStyleBackColor = false;
            // 
            // FormDocumentStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 998);
            Controls.Add(btnMarkAsComplete);
            Controls.Add(btnReject);
            Controls.Add(btnMarkAsReady);
            Controls.Add(btnAccept);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtStatus);
            Controls.Add(txtDocType);
            Controls.Add(txtDate);
            Controls.Add(txtResidentName);
            Controls.Add(txtRequestID);
            Controls.Add(panelDocumentStatusWelcome);
            Controls.Add(paneDocumentsStatusSidebar);
            Controls.Add(panel3);
            Name = "FormDocumentStatus";
            Text = "FormDocumentStatus";
            panelDocumentStatusWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            paneDocumentsStatusSidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel9;
        private Button btnDocumentStatusLogout;
        private Button btnDocumentStatusDashboard;
        private Button btnDocumentStatusTransactionHistory;
        private Panel panelDocumentStatusWelcome;
        private Panel paneDocumentsStatusSidebar;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private TextBox txtRequestID;
        private TextBox txtResidentName;
        private TextBox txtDate;
        private TextBox txtDocType;
        private TextBox txtStatus;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAccept;
        private Button btnMarkAsReady;
        private Button btnReject;
        private Button btnMarkAsComplete;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Button btnBackToAdminDashboard;
    }
}