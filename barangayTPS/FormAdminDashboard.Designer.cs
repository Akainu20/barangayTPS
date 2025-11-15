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
            panel8 = new Panel();
            panel9 = new Panel();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(369, 88);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(774, 65);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 40);
            label2.Name = "label2";
            label2.Size = new Size(254, 15);
            label2.TabIndex = 4;
            label2.Text = "Overview of barangay transactions and records";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 33);
            label1.TabIndex = 3;
            label1.Text = "Dashboard";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RequestID, ResidentName, DocumentType, DateRequested, Status });
            dataGridView1.Location = new Point(3, 52);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 417);
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
            panel4.Location = new Point(369, 169);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(774, 471);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 18);
            label3.Name = "label3";
            label3.Size = new Size(130, 18);
            label3.TabIndex = 5;
            label3.Text = "Recent Transactions";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-4, 59);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 692);
            panel1.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SeaGreen;
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(-1, 1);
            panel8.Name = "panel8";
            panel8.Size = new Size(1303, 62);
            panel8.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Gold;
            panel9.Location = new Point(0, 56);
            panel9.Name = "panel9";
            panel9.Size = new Size(1378, 12);
            panel9.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(16, 80);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(157, 31);
            button1.TabIndex = 9;
            button1.Text = "Transaction History\r\n";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(16, 29);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(157, 31);
            button4.TabIndex = 10;
            button4.Text = "Dashboard";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(16, 128);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(157, 31);
            button5.TabIndex = 11;
            button5.Text = "Logout\r\n";
            button5.UseVisualStyleBackColor = false;
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 746);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAdminDashboard";
            Text = "FormAdminDashboard";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
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
    }
}