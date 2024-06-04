namespace BldDonation
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.LblViewPatientDetails = new System.Windows.Forms.Label();
            this.BtnPatientSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TxtPAge = new System.Windows.Forms.TextBox();
            this.TxtPAddress = new System.Windows.Forms.TextBox();
            this.LblPAddress = new System.Windows.Forms.Label();
            this.CmbPBGroup = new System.Windows.Forms.ComboBox();
            this.LblPBGroup = new System.Windows.Forms.Label();
            this.CmbPGender = new System.Windows.Forms.ComboBox();
            this.LblPGender = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TxtPPhone = new System.Windows.Forms.TextBox();
            this.LblPPhone = new System.Windows.Forms.Label();
            this.LblPAge = new System.Windows.Forms.Label();
            this.TxtPName = new System.Windows.Forms.TextBox();
            this.LblPName = new System.Windows.Forms.Label();
            this.LblPatients = new System.Windows.Forms.Label();
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
            this.LblVPName = new System.Windows.Forms.Label();
            this.LblVPBGroup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblViewPatientDetails
            // 
            this.LblViewPatientDetails.Location = new System.Drawing.Point(12, 9);
            this.LblViewPatientDetails.Name = "LblViewPatientDetails";
            this.LblViewPatientDetails.Size = new System.Drawing.Size(100, 23);
            this.LblViewPatientDetails.TabIndex = 34;
            // 
            // BtnPatientSave
            // 
            this.BtnPatientSave.ActiveBorderThickness = 1;
            this.BtnPatientSave.ActiveCornerRadius = 20;
            this.BtnPatientSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnPatientSave.ActiveForecolor = System.Drawing.Color.Transparent;
            this.BtnPatientSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnPatientSave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPatientSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatientSave.BackgroundImage")));
            this.BtnPatientSave.ButtonText = "Save";
            this.BtnPatientSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPatientSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatientSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnPatientSave.IdleBorderThickness = 1;
            this.BtnPatientSave.IdleCornerRadius = 20;
            this.BtnPatientSave.IdleFillColor = System.Drawing.Color.Red;
            this.BtnPatientSave.IdleForecolor = System.Drawing.Color.Black;
            this.BtnPatientSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnPatientSave.Location = new System.Drawing.Point(991, 567);
            this.BtnPatientSave.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPatientSave.Name = "BtnPatientSave";
            this.BtnPatientSave.Size = new System.Drawing.Size(204, 48);
            this.BtnPatientSave.TabIndex = 49;
            this.BtnPatientSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPatientSave.Click += new System.EventHandler(this.BtnPatientSave_Click);
            // 
            // TxtPAge
            // 
            this.TxtPAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPAge.Location = new System.Drawing.Point(519, 348);
            this.TxtPAge.Name = "TxtPAge";
            this.TxtPAge.Size = new System.Drawing.Size(218, 34);
            this.TxtPAge.TabIndex = 48;
            // 
            // TxtPAddress
            // 
            this.TxtPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPAddress.Location = new System.Drawing.Point(956, 348);
            this.TxtPAddress.Multiline = true;
            this.TxtPAddress.Name = "TxtPAddress";
            this.TxtPAddress.Size = new System.Drawing.Size(313, 157);
            this.TxtPAddress.TabIndex = 47;
            // 
            // LblPAddress
            // 
            this.LblPAddress.AutoSize = true;
            this.LblPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPAddress.ForeColor = System.Drawing.Color.Red;
            this.LblPAddress.Location = new System.Drawing.Point(951, 316);
            this.LblPAddress.Name = "LblPAddress";
            this.LblPAddress.Size = new System.Drawing.Size(109, 29);
            this.LblPAddress.TabIndex = 46;
            this.LblPAddress.Text = "Address";
            // 
            // CmbPBGroup
            // 
            this.CmbPBGroup.BackColor = System.Drawing.Color.White;
            this.CmbPBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPBGroup.FormattingEnabled = true;
            this.CmbPBGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.CmbPBGroup.Location = new System.Drawing.Point(83, 586);
            this.CmbPBGroup.Name = "CmbPBGroup";
            this.CmbPBGroup.Size = new System.Drawing.Size(218, 37);
            this.CmbPBGroup.TabIndex = 45;
            // 
            // LblPBGroup
            // 
            this.LblPBGroup.AutoSize = true;
            this.LblPBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPBGroup.ForeColor = System.Drawing.Color.Red;
            this.LblPBGroup.Location = new System.Drawing.Point(79, 592);
            this.LblPBGroup.Name = "LblPBGroup";
            this.LblPBGroup.Size = new System.Drawing.Size(161, 29);
            this.LblPBGroup.TabIndex = 44;
            this.LblPBGroup.Text = "Blood Group";
            // 
            // CmbPGender
            // 
            this.CmbPGender.BackColor = System.Drawing.Color.White;
            this.CmbPGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPGender.FormattingEnabled = true;
            this.CmbPGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.CmbPGender.Location = new System.Drawing.Point(519, 468);
            this.CmbPGender.Name = "CmbPGender";
            this.CmbPGender.Size = new System.Drawing.Size(218, 37);
            this.CmbPGender.TabIndex = 43;
            // 
            // LblPGender
            // 
            this.LblPGender.AutoSize = true;
            this.LblPGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPGender.ForeColor = System.Drawing.Color.Red;
            this.LblPGender.Location = new System.Drawing.Point(514, 436);
            this.LblPGender.Name = "LblPGender";
            this.LblPGender.Size = new System.Drawing.Size(100, 29);
            this.LblPGender.TabIndex = 42;
            this.LblPGender.Text = "Gender";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(475, 135);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(121, 111);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 41;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // TxtPPhone
            // 
            this.TxtPPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPPhone.Location = new System.Drawing.Point(83, 468);
            this.TxtPPhone.Name = "TxtPPhone";
            this.TxtPPhone.Size = new System.Drawing.Size(218, 34);
            this.TxtPPhone.TabIndex = 40;
            // 
            // LblPPhone
            // 
            this.LblPPhone.AutoSize = true;
            this.LblPPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPPhone.ForeColor = System.Drawing.Color.Red;
            this.LblPPhone.Location = new System.Drawing.Point(78, 436);
            this.LblPPhone.Name = "LblPPhone";
            this.LblPPhone.Size = new System.Drawing.Size(240, 29);
            this.LblPPhone.TabIndex = 39;
            this.LblPPhone.Text = "Telephone Number";
            // 
            // LblPAge
            // 
            this.LblPAge.AutoSize = true;
            this.LblPAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPAge.ForeColor = System.Drawing.Color.Red;
            this.LblPAge.Location = new System.Drawing.Point(514, 316);
            this.LblPAge.Name = "LblPAge";
            this.LblPAge.Size = new System.Drawing.Size(59, 29);
            this.LblPAge.TabIndex = 38;
            this.LblPAge.Text = "Age";
            // 
            // TxtPName
            // 
            this.TxtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPName.Location = new System.Drawing.Point(83, 348);
            this.TxtPName.Name = "TxtPName";
            this.TxtPName.Size = new System.Drawing.Size(218, 34);
            this.TxtPName.TabIndex = 37;
            // 
            // LblPName
            // 
            this.LblPName.AutoSize = true;
            this.LblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPName.ForeColor = System.Drawing.Color.Red;
            this.LblPName.Location = new System.Drawing.Point(79, 354);
            this.LblPName.Name = "LblPName";
            this.LblPName.Size = new System.Drawing.Size(82, 29);
            this.LblPName.TabIndex = 36;
            this.LblPName.Text = "Name";
            // 
            // LblPatients
            // 
            this.LblPatients.AutoSize = true;
            this.LblPatients.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatients.ForeColor = System.Drawing.Color.Red;
            this.LblPatients.Location = new System.Drawing.Point(619, 170);
            this.LblPatients.Name = "LblPatients";
            this.LblPatients.Size = new System.Drawing.Size(119, 34);
            this.LblPatients.TabIndex = 35;
            this.LblPatients.Text = "Patients";
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
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 100);
            this.panel1.TabIndex = 88;
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
            this.BtnDonor.Click += new System.EventHandler(this.BtnDonor_Click);
            // 
            // LblVPName
            // 
            this.LblVPName.AutoSize = true;
            this.LblVPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVPName.ForeColor = System.Drawing.Color.Red;
            this.LblVPName.Location = new System.Drawing.Point(89, 316);
            this.LblVPName.Name = "LblVPName";
            this.LblVPName.Size = new System.Drawing.Size(82, 29);
            this.LblVPName.TabIndex = 89;
            this.LblVPName.Text = "Name";
            // 
            // LblVPBGroup
            // 
            this.LblVPBGroup.AutoSize = true;
            this.LblVPBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVPBGroup.ForeColor = System.Drawing.Color.Red;
            this.LblVPBGroup.Location = new System.Drawing.Point(79, 554);
            this.LblVPBGroup.Name = "LblVPBGroup";
            this.LblVPBGroup.Size = new System.Drawing.Size(161, 29);
            this.LblVPBGroup.TabIndex = 90;
            this.LblVPBGroup.Text = "Blood Group";
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 717);
            this.Controls.Add(this.LblVPBGroup);
            this.Controls.Add(this.LblVPName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblViewPatientDetails);
            this.Controls.Add(this.BtnPatientSave);
            this.Controls.Add(this.TxtPAge);
            this.Controls.Add(this.TxtPAddress);
            this.Controls.Add(this.LblPAddress);
            this.Controls.Add(this.CmbPBGroup);
            this.Controls.Add(this.LblPBGroup);
            this.Controls.Add(this.CmbPGender);
            this.Controls.Add(this.LblPGender);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.TxtPPhone);
            this.Controls.Add(this.LblPPhone);
            this.Controls.Add(this.LblPAge);
            this.Controls.Add(this.TxtPName);
            this.Controls.Add(this.LblPName);
            this.Controls.Add(this.LblPatients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblViewPatientDetails;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnPatientSave;
        private System.Windows.Forms.TextBox TxtPAge;
        private System.Windows.Forms.TextBox TxtPAddress;
        private System.Windows.Forms.Label LblPAddress;
        private System.Windows.Forms.ComboBox CmbPBGroup;
        private System.Windows.Forms.Label LblPBGroup;
        private System.Windows.Forms.ComboBox CmbPGender;
        private System.Windows.Forms.Label LblPGender;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.TextBox TxtPPhone;
        private System.Windows.Forms.Label LblPPhone;
        private System.Windows.Forms.Label LblPAge;
        private System.Windows.Forms.TextBox TxtPName;
        private System.Windows.Forms.Label LblPName;
        private System.Windows.Forms.Label LblPatients;
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
        private System.Windows.Forms.Label LblVPName;
        private System.Windows.Forms.Label LblVPBGroup;
    }
}