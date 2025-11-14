namespace barangayTPS
{
    partial class FormResidentInfo
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
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Location = new Point(1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1510, 108);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(345, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 87);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 53);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 4;
            label2.Text = "Manage Resident Records";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 12);
            label1.Name = "label1";
            label1.Size = new Size(515, 41);
            label1.TabIndex = 3;
            label1.Text = "Resident Information Management";
            // 
            // FormResidentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 753);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormResidentInfo";
            Text = "FormResidentInfo";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
    }
}