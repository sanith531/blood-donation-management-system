namespace BldDonation
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.BtnPatients = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnBloodT = new System.Windows.Forms.Button();
            this.BtnBloodS = new System.Windows.Forms.Button();
            this.BtnViewD = new System.Windows.Forms.Button();
            this.BtnDonate = new System.Windows.Forms.Button();
            this.BtnDonor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnViewPatients = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPatients
            // 
            this.BtnPatients.BackColor = System.Drawing.Color.Red;
            this.BtnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatients.Location = new System.Drawing.Point(421, 0);
            this.BtnPatients.Name = "BtnPatients";
            this.BtnPatients.Size = new System.Drawing.Size(151, 100);
            this.BtnPatients.TabIndex = 3;
            this.BtnPatients.Text = "Patient";
            this.BtnPatients.UseVisualStyleBackColor = false;
            this.BtnPatients.Click += new System.EventHandler(this.BtnPatients_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.BtnViewPatients);
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.BtnBloodT);
            this.panel1.Controls.Add(this.BtnBloodS);
            this.panel1.Controls.Add(this.BtnPatients);
            this.panel1.Controls.Add(this.BtnViewD);
            this.panel1.Controls.Add(this.BtnDonate);
            this.panel1.Controls.Add(this.BtnDonor);
            this.panel1.Location = new System.Drawing.Point(-16, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 100);
            this.panel1.TabIndex = 4;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Red;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(1220, 0);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(113, 100);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.Red;
            this.BtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.Location = new System.Drawing.Point(1045, 0);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(178, 100);
            this.BtnDashboard.TabIndex = 8;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnBloodT
            // 
            this.BtnBloodT.BackColor = System.Drawing.Color.Red;
            this.BtnBloodT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBloodT.Location = new System.Drawing.Point(841, 0);
            this.BtnBloodT.Name = "BtnBloodT";
            this.BtnBloodT.Size = new System.Drawing.Size(207, 100);
            this.BtnBloodT.TabIndex = 6;
            this.BtnBloodT.Text = "Blood Transfusion";
            this.BtnBloodT.UseVisualStyleBackColor = false;
            this.BtnBloodT.Click += new System.EventHandler(this.BtnBloodT_Click);
            // 
            // BtnBloodS
            // 
            this.BtnBloodS.BackColor = System.Drawing.Color.Red;
            this.BtnBloodS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBloodS.Location = new System.Drawing.Point(715, 0);
            this.BtnBloodS.Name = "BtnBloodS";
            this.BtnBloodS.Size = new System.Drawing.Size(129, 100);
            this.BtnBloodS.TabIndex = 5;
            this.BtnBloodS.Text = "Blood Stock";
            this.BtnBloodS.UseVisualStyleBackColor = false;
            this.BtnBloodS.Click += new System.EventHandler(this.BtnBloodS_Click);
            // 
            // BtnViewD
            // 
            this.BtnViewD.BackColor = System.Drawing.Color.Red;
            this.BtnViewD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewD.Location = new System.Drawing.Point(271, 0);
            this.BtnViewD.Name = "BtnViewD";
            this.BtnViewD.Size = new System.Drawing.Size(151, 100);
            this.BtnViewD.TabIndex = 2;
            this.BtnViewD.Text = "View Donors";
            this.BtnViewD.UseVisualStyleBackColor = false;
            this.BtnViewD.Click += new System.EventHandler(this.BtnViewD_Click);
            // 
            // BtnDonate
            // 
            this.BtnDonate.BackColor = System.Drawing.Color.Red;
            this.BtnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDonate.Location = new System.Drawing.Point(145, 0);
            this.BtnDonate.Name = "BtnDonate";
            this.BtnDonate.Size = new System.Drawing.Size(129, 100);
            this.BtnDonate.TabIndex = 1;
            this.BtnDonate.Text = "Donate";
            this.BtnDonate.UseVisualStyleBackColor = false;
            this.BtnDonate.Click += new System.EventHandler(this.BtnDonate_Click);
            // 
            // BtnDonor
            // 
            this.BtnDonor.BackColor = System.Drawing.Color.Red;
            this.BtnDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDonor.Location = new System.Drawing.Point(16, 0);
            this.BtnDonor.Name = "BtnDonor";
            this.BtnDonor.Size = new System.Drawing.Size(132, 100);
            this.BtnDonor.TabIndex = 0;
            this.BtnDonor.Text = "Donor";
            this.BtnDonor.UseVisualStyleBackColor = false;
            this.BtnDonor.Click += new System.EventHandler(this.BtnDonor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1284, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BtnViewPatients
            // 
            this.BtnViewPatients.BackColor = System.Drawing.Color.Red;
            this.BtnViewPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewPatients.Location = new System.Drawing.Point(569, 0);
            this.BtnViewPatients.Name = "BtnViewPatients";
            this.BtnViewPatients.Size = new System.Drawing.Size(149, 100);
            this.BtnViewPatients.TabIndex = 10;
            this.BtnViewPatients.Text = "View Patients";
            this.BtnViewPatients.UseVisualStyleBackColor = false;
            this.BtnViewPatients.Click += new System.EventHandler(this.BtnViewPatients_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPatients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnBloodT;
        private System.Windows.Forms.Button BtnBloodS;
        private System.Windows.Forms.Button BtnViewD;
        private System.Windows.Forms.Button BtnDonate;
        private System.Windows.Forms.Button BtnDonor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnViewPatients;
    }
}