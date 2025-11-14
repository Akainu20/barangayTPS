namespace barangayTPS
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-5, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1375, 803);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(376, 528);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 10;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(376, 461);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 9;
            label6.Text = "Username/Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(376, 390);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 8;
            label5.Text = "Enter your full name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(376, 493);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(576, 32);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(376, 426);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(576, 32);
            textBox2.TabIndex = 6;
            textBox2.Text = "Enter admin username/email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(599, 282);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 5;
            label4.Text = "Please select role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(554, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Resident/Admin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(376, 355);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(576, 32);
            textBox1.TabIndex = 3;
            textBox1.Text = "Enter your full name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(535, 100);
            label1.Name = "label1";
            label1.Size = new Size(265, 38);
            label1.TabIndex = 0;
            label1.Text = "Barangay San Juan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(610, 171);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 2;
            label3.Text = "Taytay, Rizal";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(535, 147);
            label2.Name = "label2";
            label2.Size = new Size(265, 23);
            label2.TabIndex = 1;
            label2.Text = "Transaction Management System";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1370, 770);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
