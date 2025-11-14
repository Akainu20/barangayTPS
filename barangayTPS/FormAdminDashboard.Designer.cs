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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            RequestID = new DataGridViewTextBoxColumn();
            ResidentName = new DataGridViewTextBoxColumn();
            DocumentType = new DataGridViewTextBoxColumn();
            DateRequested = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel4 = new Panel();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(1, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 885);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Location = new Point(-14, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1510, 108);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(422, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 87);
            panel3.TabIndex = 2;
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
            dataGridView1.Location = new Point(-1, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(884, 560);
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
            // panel4
            // 
            panel4.BackColor = Color.SeaGreen;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(424, 258);
            panel4.Name = "panel4";
            panel4.Size = new Size(882, 629);
            panel4.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.Location = new Point(6, 71);
            button6.Name = "button6";
            button6.Size = new Size(189, 34);
            button6.TabIndex = 5;
            button6.Text = "Dashboard";
            button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(6, 113);
            button1.Name = "button1";
            button1.Size = new Size(189, 34);
            button1.TabIndex = 6;
            button1.Text = "Resident Management";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(6, 153);
            button2.Name = "button2";
            button2.Size = new Size(189, 34);
            button2.TabIndex = 7;
            button2.Text = "Transaction History";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(6, 193);
            button3.Name = "button3";
            button3.Size = new Size(189, 34);
            button3.TabIndex = 8;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 24);
            label3.Name = "label3";
            label3.Size = new Size(161, 22);
            label3.TabIndex = 5;
            label3.Text = "Recent Transactions";
            // 
            // FormAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 994);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAdminDashboard";
            Text = "FormAdminDashboard";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
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
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Label label3;
    }
}