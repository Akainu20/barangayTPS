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
            panel4 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            panel8 = new Panel();
            panel9 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            pictureBox6 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
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
            // panel4
            // 
            panel4.BackColor = Color.SeaGreen;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(422, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(885, 430);
            panel4.TabIndex = 4;
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
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-5, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 923);
            panel1.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(18, 171);
            button5.Name = "button5";
            button5.Size = new Size(179, 41);
            button5.TabIndex = 11;
            button5.Text = "Logout\r\n";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(18, 39);
            button4.Name = "button4";
            button4.Size = new Size(179, 41);
            button4.TabIndex = 10;
            button4.Text = "Dashboard";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(18, 107);
            button1.Name = "button1";
            button1.Size = new Size(179, 41);
            button1.TabIndex = 9;
            button1.Text = "Transaction History\r\n";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SeaGreen;
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(button9);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(-1, 1);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(1489, 83);
            panel8.TabIndex = 8;
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
            // button2
            // 
            button2.Location = new Point(672, 731);
            button2.Name = "button2";
            button2.Size = new Size(166, 62);
            button2.TabIndex = 9;
            button2.Text = "Pending Requests";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(441, 731);
            button3.Name = "button3";
            button3.Size = new Size(166, 62);
            button3.TabIndex = 10;
            button3.Text = "Total Requests";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(892, 731);
            button6.Name = "button6";
            button6.Size = new Size(166, 62);
            button6.TabIndex = 11;
            button6.Text = "Completed Requests";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(1094, 731);
            button7.Name = "button7";
            button7.Size = new Size(166, 62);
            button7.TabIndex = 12;
            button7.Text = "Rejected Requests";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(422, 234);
            button8.Name = "button8";
            button8.Size = new Size(163, 40);
            button8.TabIndex = 13;
            button8.Text = "Refresh";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(1318, 22);
            button9.Name = "button9";
            button9.Size = new Size(125, 31);
            button9.TabIndex = 3;
            button9.Text = "Notifications";
            button9.UseVisualStyleBackColor = true;
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
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 900);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "FormAdminDashboard";
            Text = "FormAdminDashboard";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
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
        private Panel panel4;
        private Label label3;
        private Panel panel1;
        private Panel panel8;
        private Panel panel9;
        private Button button5;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private PictureBox pictureBox6;
    }
}