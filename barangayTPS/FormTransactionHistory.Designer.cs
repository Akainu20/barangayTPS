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
            button9 = new Button();
            panel9 = new Panel();
            panel8 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            button8 = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            RequestID = new DataGridViewTextBoxColumn();
            ResidentName = new DataGridViewTextBoxColumn();
            DocumentType = new DataGridViewTextBoxColumn();
            DateRequested = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
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
            // panel9
            // 
            panel9.BackColor = Color.Gold;
            panel9.Location = new Point(0, 75);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(1575, 16);
            panel9.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SeaGreen;
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(button9);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(4, 6);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(1489, 83);
            panel8.TabIndex = 17;
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
            // button8
            // 
            button8.Location = new Point(427, 239);
            button8.Name = "button8";
            button8.Size = new Size(163, 40);
            button8.TabIndex = 22;
            button8.Text = "Refresh";
            button8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 923);
            panel1.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaGreen;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(427, 285);
            panel4.Name = "panel4";
            panel4.Size = new Size(885, 695);
            panel4.TabIndex = 15;
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RequestID, ResidentName, DocumentType, DateRequested, Status });
            dataGridView1.Location = new Point(3, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(878, 623);
            dataGridView1.TabIndex = 3;
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
            panel3.Location = new Point(427, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 87);
            panel3.TabIndex = 14;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.profile_picture;
            pictureBox6.Location = new Point(14, 22);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // FormTransactionHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 992);
            Controls.Add(panel8);
            Controls.Add(button8);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "FormTransactionHistory";
            Text = "FormTransactionHistory";
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button9;
        private Panel panel9;
        private Panel panel8;
        private Button button5;
        private Button button4;
        private Button button1;
        private Button button8;
        private Panel panel1;
        private Panel panel4;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RequestID;
        private DataGridViewTextBoxColumn ResidentName;
        private DataGridViewTextBoxColumn DocumentType;
        private DataGridViewTextBoxColumn DateRequested;
        private DataGridViewTextBoxColumn Status;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox6;
    }
}