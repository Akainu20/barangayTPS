namespace barangayTPS
{
    partial class FormResidentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResidentDashboard));
            panelResidentSidebar = new Panel();
            btnResidentLogout = new Button();
            btnResidentDashboard = new Button();
            panel2 = new Panel();
            panelAvailableDocuments = new Panel();
            pictureBox1 = new PictureBox();
            btnViewNow = new Button();
            label12 = new Label();
            panelBarangayClearance = new Panel();
            pictureBox3 = new PictureBox();
            btnRequestNow = new Button();
            label3 = new Label();
            panelResidentWelcome = new Panel();
            pictureBox6 = new PictureBox();
            panel9 = new Panel();
            lblResidentWelcome = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelResidentSidebar.SuspendLayout();
            panel2.SuspendLayout();
            panelAvailableDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBarangayClearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelResidentWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelResidentSidebar
            // 
            panelResidentSidebar.BackColor = Color.SeaGreen;
            panelResidentSidebar.Controls.Add(btnResidentLogout);
            panelResidentSidebar.Controls.Add(btnResidentDashboard);
            panelResidentSidebar.Location = new Point(-1, 75);
            panelResidentSidebar.Name = "panelResidentSidebar";
            panelResidentSidebar.Size = new Size(210, 909);
            panelResidentSidebar.TabIndex = 0;
            // 
            // btnResidentLogout
            // 
            btnResidentLogout.BackColor = Color.White;
            btnResidentLogout.Location = new Point(16, 96);
            btnResidentLogout.Name = "btnResidentLogout";
            btnResidentLogout.Size = new Size(179, 41);
            btnResidentLogout.TabIndex = 12;
            btnResidentLogout.Text = "Logout\r\n";
            btnResidentLogout.UseVisualStyleBackColor = false;
            btnResidentLogout.Click += btnResidentLogout_Click;
            // 
            // btnResidentDashboard
            // 
            btnResidentDashboard.BackColor = Color.White;
            btnResidentDashboard.Location = new Point(15, 39);
            btnResidentDashboard.Name = "btnResidentDashboard";
            btnResidentDashboard.Size = new Size(179, 41);
            btnResidentDashboard.TabIndex = 0;
            btnResidentDashboard.Text = "Dashboard";
            btnResidentDashboard.UseVisualStyleBackColor = false;
            btnResidentDashboard.Click += btnResidentDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panelAvailableDocuments);
            panel2.Controls.Add(panelBarangayClearance);
            panel2.Location = new Point(260, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 215);
            panel2.TabIndex = 2;
            // 
            // panelAvailableDocuments
            // 
            panelAvailableDocuments.BackColor = Color.SeaGreen;
            panelAvailableDocuments.Controls.Add(pictureBox1);
            panelAvailableDocuments.Controls.Add(btnViewNow);
            panelAvailableDocuments.Controls.Add(label12);
            panelAvailableDocuments.Location = new Point(539, 31);
            panelAvailableDocuments.Name = "panelAvailableDocuments";
            panelAvailableDocuments.Size = new Size(436, 165);
            panelAvailableDocuments.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.document;
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 43);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnViewNow
            // 
            btnViewNow.BackColor = Color.White;
            btnViewNow.Location = new Point(61, 93);
            btnViewNow.Name = "btnViewNow";
            btnViewNow.Size = new Size(323, 51);
            btnViewNow.TabIndex = 9;
            btnViewNow.Text = "View Now";
            btnViewNow.UseVisualStyleBackColor = false;
            btnViewNow.Click += btnViewNow_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.ImageAlign = ContentAlignment.MiddleLeft;
            label12.Location = new Point(61, 19);
            label12.Name = "label12";
            label12.Size = new Size(261, 35);
            label12.TabIndex = 11;
            label12.Text = "Available Documents";
            // 
            // panelBarangayClearance
            // 
            panelBarangayClearance.BackColor = Color.SeaGreen;
            panelBarangayClearance.Controls.Add(pictureBox3);
            panelBarangayClearance.Controls.Add(btnRequestNow);
            panelBarangayClearance.Controls.Add(label3);
            panelBarangayClearance.Location = new Point(54, 31);
            panelBarangayClearance.Name = "panelBarangayClearance";
            panelBarangayClearance.Size = new Size(414, 165);
            panelBarangayClearance.TabIndex = 24;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.document;
            pictureBox3.Location = new Point(3, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 43);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // btnRequestNow
            // 
            btnRequestNow.BackColor = Color.White;
            btnRequestNow.Location = new Point(65, 93);
            btnRequestNow.Name = "btnRequestNow";
            btnRequestNow.Size = new Size(277, 51);
            btnRequestNow.TabIndex = 9;
            btnRequestNow.Text = "Request Now";
            btnRequestNow.UseVisualStyleBackColor = false;
            btnRequestNow.Click += btnRequestNow_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(46, 19);
            label3.Name = "label3";
            label3.Size = new Size(368, 35);
            label3.TabIndex = 11;
            label3.Text = "Request Barangay Documents ";
            // 
            // panelResidentWelcome
            // 
            panelResidentWelcome.BackColor = Color.SeaGreen;
            panelResidentWelcome.Controls.Add(pictureBox6);
            panelResidentWelcome.Controls.Add(panel9);
            panelResidentWelcome.Controls.Add(lblResidentWelcome);
            panelResidentWelcome.Location = new Point(0, 0);
            panelResidentWelcome.Margin = new Padding(3, 4, 3, 4);
            panelResidentWelcome.Name = "panelResidentWelcome";
            panelResidentWelcome.Size = new Size(1574, 83);
            panelResidentWelcome.TabIndex = 3;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.profile_picture;
            pictureBox6.Location = new Point(1285, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 3;
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
            // lblResidentWelcome
            // 
            lblResidentWelcome.AutoSize = true;
            lblResidentWelcome.BackColor = Color.SeaGreen;
            lblResidentWelcome.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResidentWelcome.ForeColor = Color.White;
            lblResidentWelcome.Location = new Point(14, 9);
            lblResidentWelcome.Name = "lblResidentWelcome";
            lblResidentWelcome.Size = new Size(616, 60);
            lblResidentWelcome.TabIndex = 1;
            lblResidentWelcome.Text = "Welcome to Your Dashboard";
            lblResidentWelcome.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(250, 470);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1051, 351);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(215, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(1119, 87);
            panel3.TabIndex = 14;
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
            // FormResidentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1338, 971);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(panelResidentWelcome);
            Controls.Add(panel2);
            Controls.Add(panelResidentSidebar);
            Name = "FormResidentDashboard";
            Text = "FormResidentDashboard";
            Load += FormResidentDashboard_Load;
            panelResidentSidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelAvailableDocuments.ResumeLayout(false);
            panelAvailableDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBarangayClearance.ResumeLayout(false);
            panelBarangayClearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelResidentWelcome.ResumeLayout(false);
            panelResidentWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelResidentSidebar;
        private Panel panel2;
        private Button btnResidentDashboard;
        private Panel panelBarangayClearance;
        private PictureBox pictureBox3;
        private Button btnRequestNow;
        private Panel panelResidentWelcome;
        private Label lblResidentWelcome;
        private Panel panel9;
        private PictureBox pictureBox6;
        private Label label3;
        private Button btnResidentLogout;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panelAvailableDocuments;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private Button btnViewNow;
        private Label label12;
        private PictureBox pictureBox2;
        private Panel panel3;
    }
}