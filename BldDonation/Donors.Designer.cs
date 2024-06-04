namespace BldDonation
{
    partial class Donors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donors));
            this.TxtDAge = new System.Windows.Forms.TextBox();
            this.BtnDonorSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TxtDAddress = new System.Windows.Forms.TextBox();
            this.LblDAddress = new System.Windows.Forms.Label();
            this.CmbDBGroup = new System.Windows.Forms.ComboBox();
            this.LblDBGroup = new System.Windows.Forms.Label();
            this.CmbDGender = new System.Windows.Forms.ComboBox();
            this.LblDGender = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TxtDPhone = new System.Windows.Forms.TextBox();
            this.LblDPhone = new System.Windows.Forms.Label();
            this.LblDAge = new System.Windows.Forms.Label();
            this.TxtDName = new System.Windows.Forms.TextBox();
            this.LblDName = new System.Windows.Forms.Label();
            this.LblDonors = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnViewPatients = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnBloodT = new System.Windows.Forms.Button();
            this.BtnBloodS = new System.Windows.Forms.Button();
            this.BtnPatients = new System.Windows.Forms.Button();
            this.BtnViewD = new System.Windows.Forms.Button();
            this.BtnDonate = new System.Windows.Forms.Button();
            this.BtnDonor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDAge
            // 
            this.TxtDAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDAge.Location = new System.Drawing.Point(498, 380);
            this.TxtDAge.Name = "TxtDAge";
            this.TxtDAge.Size = new System.Drawing.Size(218, 34);
            this.TxtDAge.TabIndex = 49;
            // 
            // BtnDonorSave
            // 
            this.BtnDonorSave.ActiveBorderThickness = 1;
            this.BtnDonorSave.ActiveCornerRadius = 20;
            this.BtnDonorSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnDonorSave.ActiveForecolor = System.Drawing.Color.Transparent;
            this.BtnDonorSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnDonorSave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDonorSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDonorSave.BackgroundImage")));
            this.BtnDonorSave.ButtonText = "Save";
            this.BtnDonorSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDonorSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDonorSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDonorSave.IdleBorderThickness = 1;
            this.BtnDonorSave.IdleCornerRadius = 20;
            this.BtnDonorSave.IdleFillColor = System.Drawing.Color.Red;
            this.BtnDonorSave.IdleForecolor = System.Drawing.Color.Black;
            this.BtnDonorSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnDonorSave.Location = new System.Drawing.Point(1016, 576);
            this.BtnDonorSave.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDonorSave.Name = "BtnDonorSave";
            this.BtnDonorSave.Size = new System.Drawing.Size(191, 48);
            this.BtnDonorSave.TabIndex = 48;
            this.BtnDonorSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDonorSave.Click += new System.EventHandler(this.BtnDonorSave_Click);
            // 
            // TxtDAddress
            // 
            this.TxtDAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDAddress.Location = new System.Drawing.Point(935, 380);
            this.TxtDAddress.Multiline = true;
            this.TxtDAddress.Name = "TxtDAddress";
            this.TxtDAddress.Size = new System.Drawing.Size(313, 157);
            this.TxtDAddress.TabIndex = 47;
            // 
            // LblDAddress
            // 
            this.LblDAddress.AutoSize = true;
            this.LblDAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDAddress.ForeColor = System.Drawing.Color.Red;
            this.LblDAddress.Location = new System.Drawing.Point(930, 348);
            this.LblDAddress.Name = "LblDAddress";
            this.LblDAddress.Size = new System.Drawing.Size(109, 29);
            this.LblDAddress.TabIndex = 46;
            this.LblDAddress.Text = "Address";
            // 
            // CmbDBGroup
            // 
            this.CmbDBGroup.BackColor = System.Drawing.Color.White;
            this.CmbDBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDBGroup.FormattingEnabled = true;
            this.CmbDBGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.CmbDBGroup.Location = new System.Drawing.Point(62, 627);
            this.CmbDBGroup.Name = "CmbDBGroup";
            this.CmbDBGroup.Size = new System.Drawing.Size(218, 37);
            this.CmbDBGroup.TabIndex = 45;
            // 
            // LblDBGroup
            // 
            this.LblDBGroup.AutoSize = true;
            this.LblDBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDBGroup.ForeColor = System.Drawing.Color.Red;
            this.LblDBGroup.Location = new System.Drawing.Point(57, 595);
            this.LblDBGroup.Name = "LblDBGroup";
            this.LblDBGroup.Size = new System.Drawing.Size(161, 29);
            this.LblDBGroup.TabIndex = 44;
            this.LblDBGroup.Text = "Blood Group";
            // 
            // CmbDGender
            // 
            this.CmbDGender.BackColor = System.Drawing.Color.White;
            this.CmbDGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDGender.FormattingEnabled = true;
            this.CmbDGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.CmbDGender.Location = new System.Drawing.Point(498, 500);
            this.CmbDGender.Name = "CmbDGender";
            this.CmbDGender.Size = new System.Drawing.Size(218, 37);
            this.CmbDGender.TabIndex = 43;
            // 
            // LblDGender
            // 
            this.LblDGender.AutoSize = true;
            this.LblDGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDGender.ForeColor = System.Drawing.Color.Red;
            this.LblDGender.Location = new System.Drawing.Point(493, 468);
            this.LblDGender.Name = "LblDGender";
            this.LblDGender.Size = new System.Drawing.Size(100, 29);
            this.LblDGender.TabIndex = 42;
            this.LblDGender.Text = "Gender";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(454, 167);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(121, 111);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 41;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // TxtDPhone
            // 
            this.TxtDPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDPhone.Location = new System.Drawing.Point(62, 500);
            this.TxtDPhone.Name = "TxtDPhone";
            this.TxtDPhone.Size = new System.Drawing.Size(218, 34);
            this.TxtDPhone.TabIndex = 40;
            // 
            // LblDPhone
            // 
            this.LblDPhone.AutoSize = true;
            this.LblDPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDPhone.ForeColor = System.Drawing.Color.Red;
            this.LblDPhone.Location = new System.Drawing.Point(57, 468);
            this.LblDPhone.Name = "LblDPhone";
            this.LblDPhone.Size = new System.Drawing.Size(240, 29);
            this.LblDPhone.TabIndex = 39;
            this.LblDPhone.Text = "Telephone Number";
            // 
            // LblDAge
            // 
            this.LblDAge.AutoSize = true;
            this.LblDAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDAge.ForeColor = System.Drawing.Color.Red;
            this.LblDAge.Location = new System.Drawing.Point(493, 348);
            this.LblDAge.Name = "LblDAge";
            this.LblDAge.Size = new System.Drawing.Size(59, 29);
            this.LblDAge.TabIndex = 38;
            this.LblDAge.Text = "Age";
            // 
            // TxtDName
            // 
            this.TxtDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDName.Location = new System.Drawing.Point(62, 380);
            this.TxtDName.Name = "TxtDName";
            this.TxtDName.Size = new System.Drawing.Size(218, 34);
            this.TxtDName.TabIndex = 37;
            // 
            // LblDName
            // 
            this.LblDName.AutoSize = true;
            this.LblDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDName.ForeColor = System.Drawing.Color.Red;
            this.LblDName.Location = new System.Drawing.Point(57, 348);
            this.LblDName.Name = "LblDName";
            this.LblDName.Size = new System.Drawing.Size(82, 29);
            this.LblDName.TabIndex = 36;
            this.LblDName.Text = "Name";
            // 
            // LblDonors
            // 
            this.LblDonors.AutoSize = true;
            this.LblDonors.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDonors.ForeColor = System.Drawing.Color.Red;
            this.LblDonors.Location = new System.Drawing.Point(598, 202);
            this.LblDonors.Name = "LblDonors";
            this.LblDonors.Size = new System.Drawing.Size(109, 34);
            this.LblDonors.TabIndex = 35;
            this.LblDonors.Text = "Donors";
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
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 100);
            this.panel1.TabIndex = 87;
            // 
            // BtnViewPatients
            // 
            this.BtnViewPatients.BackColor = System.Drawing.Color.Red;
            this.BtnViewPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewPatients.Location = new System.Drawing.Point(533, 0);
            this.BtnViewPatients.Name = "BtnViewPatients";
            this.BtnViewPatients.Size = new System.Drawing.Size(149, 100);
            this.BtnViewPatients.TabIndex = 10;
            this.BtnViewPatients.Text = "View Patients";
            this.BtnViewPatients.UseVisualStyleBackColor = false;
            this.BtnViewPatients.Click += new System.EventHandler(this.BtnViewPatients_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Red;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(1181, 0);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(137, 100);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.Red;
            this.BtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.Location = new System.Drawing.Point(1009, 0);
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
            this.BtnBloodT.Location = new System.Drawing.Point(805, 0);
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
            this.BtnBloodS.Location = new System.Drawing.Point(679, 0);
            this.BtnBloodS.Name = "BtnBloodS";
            this.BtnBloodS.Size = new System.Drawing.Size(129, 100);
            this.BtnBloodS.TabIndex = 5;
            this.BtnBloodS.Text = "Blood Stock";
            this.BtnBloodS.UseVisualStyleBackColor = false;
            this.BtnBloodS.Click += new System.EventHandler(this.BtnBloodS_Click);
            // 
            // BtnPatients
            // 
            this.BtnPatients.BackColor = System.Drawing.Color.Red;
            this.BtnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatients.Location = new System.Drawing.Point(401, 0);
            this.BtnPatients.Name = "BtnPatients";
            this.BtnPatients.Size = new System.Drawing.Size(135, 100);
            this.BtnPatients.TabIndex = 3;
            this.BtnPatients.Text = "Patient";
            this.BtnPatients.UseVisualStyleBackColor = false;
            this.BtnPatients.Click += new System.EventHandler(this.BtnPatients_Click);
            // 
            // BtnViewD
            // 
            this.BtnViewD.BackColor = System.Drawing.Color.Red;
            this.BtnViewD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewD.Location = new System.Drawing.Point(253, 0);
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
            this.BtnDonate.Location = new System.Drawing.Point(127, 0);
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
            this.BtnDonor.Location = new System.Drawing.Point(0, 0);
            this.BtnDonor.Name = "BtnDonor";
            this.BtnDonor.Size = new System.Drawing.Size(132, 100);
            this.BtnDonor.TabIndex = 0;
            this.BtnDonor.Text = "Donor";
            this.BtnDonor.UseVisualStyleBackColor = false;
            // 
            // Donors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtDAge);
            this.Controls.Add(this.BtnDonorSave);
            this.Controls.Add(this.TxtDAddress);
            this.Controls.Add(this.LblDAddress);
            this.Controls.Add(this.CmbDBGroup);
            this.Controls.Add(this.LblDBGroup);
            this.Controls.Add(this.CmbDGender);
            this.Controls.Add(this.LblDGender);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.TxtDPhone);
            this.Controls.Add(this.LblDPhone);
            this.Controls.Add(this.LblDAge);
            this.Controls.Add(this.TxtDName);
            this.Controls.Add(this.LblDName);
            this.Controls.Add(this.LblDonors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Donors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donors";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDAge;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnDonorSave;
        private System.Windows.Forms.TextBox TxtDAddress;
        private System.Windows.Forms.Label LblDAddress;
        private System.Windows.Forms.ComboBox CmbDBGroup;
        private System.Windows.Forms.Label LblDBGroup;
        private System.Windows.Forms.ComboBox CmbDGender;
        private System.Windows.Forms.Label LblDGender;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.TextBox TxtDPhone;
        private System.Windows.Forms.Label LblDPhone;
        private System.Windows.Forms.Label LblDAge;
        private System.Windows.Forms.TextBox TxtDName;
        private System.Windows.Forms.Label LblDName;
        private System.Windows.Forms.Label LblDonors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnViewPatients;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnBloodT;
        private System.Windows.Forms.Button BtnBloodS;
        private System.Windows.Forms.Button BtnPatients;
        private System.Windows.Forms.Button BtnViewD;
        private System.Windows.Forms.Button BtnDonate;
        private System.Windows.Forms.Button BtnDonor;
    }
}