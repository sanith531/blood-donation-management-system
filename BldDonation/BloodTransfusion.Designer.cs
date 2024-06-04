namespace BldDonation
{
    partial class BloodTransfusion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodTransfusion));
            this.BtnTransfer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LblAvailableOrNot = new System.Windows.Forms.Label();
            this.TxtBGroup = new System.Windows.Forms.TextBox();
            this.LblBGroup = new System.Windows.Forms.Label();
            this.TxtPtName = new System.Windows.Forms.TextBox();
            this.LblPtName = new System.Windows.Forms.Label();
            this.CmbPtId = new System.Windows.Forms.ComboBox();
            this.LblPtId = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LblBloodTransfusion = new System.Windows.Forms.Label();
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
            // BtnTransfer
            // 
            this.BtnTransfer.ActiveBorderThickness = 1;
            this.BtnTransfer.ActiveCornerRadius = 20;
            this.BtnTransfer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnTransfer.ActiveForecolor = System.Drawing.Color.Transparent;
            this.BtnTransfer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnTransfer.BackColor = System.Drawing.SystemColors.Control;
            this.BtnTransfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTransfer.BackgroundImage")));
            this.BtnTransfer.ButtonText = "Transfer";
            this.BtnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTransfer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransfer.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnTransfer.IdleBorderThickness = 1;
            this.BtnTransfer.IdleCornerRadius = 20;
            this.BtnTransfer.IdleFillColor = System.Drawing.Color.Red;
            this.BtnTransfer.IdleForecolor = System.Drawing.Color.Black;
            this.BtnTransfer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnTransfer.Location = new System.Drawing.Point(515, 595);
            this.BtnTransfer.Margin = new System.Windows.Forms.Padding(5);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(409, 48);
            this.BtnTransfer.TabIndex = 49;
            this.BtnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnTransfer.Visible = false;
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // LblAvailableOrNot
            // 
            this.LblAvailableOrNot.AutoSize = true;
            this.LblAvailableOrNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvailableOrNot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAvailableOrNot.Location = new System.Drawing.Point(584, 513);
            this.LblAvailableOrNot.Name = "LblAvailableOrNot";
            this.LblAvailableOrNot.Size = new System.Drawing.Size(221, 32);
            this.LblAvailableOrNot.TabIndex = 48;
            this.LblAvailableOrNot.Text = "AvailableOrNot";
            this.LblAvailableOrNot.Visible = false;
            // 
            // TxtBGroup
            // 
            this.TxtBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBGroup.Location = new System.Drawing.Point(930, 394);
            this.TxtBGroup.Name = "TxtBGroup";
            this.TxtBGroup.Size = new System.Drawing.Size(218, 34);
            this.TxtBGroup.TabIndex = 47;
            // 
            // LblBGroup
            // 
            this.LblBGroup.AutoSize = true;
            this.LblBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBGroup.ForeColor = System.Drawing.Color.Red;
            this.LblBGroup.Location = new System.Drawing.Point(925, 362);
            this.LblBGroup.Name = "LblBGroup";
            this.LblBGroup.Size = new System.Drawing.Size(161, 29);
            this.LblBGroup.TabIndex = 46;
            this.LblBGroup.Text = "Blood Group";
            // 
            // TxtPtName
            // 
            this.TxtPtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPtName.Location = new System.Drawing.Point(534, 394);
            this.TxtPtName.Name = "TxtPtName";
            this.TxtPtName.Size = new System.Drawing.Size(218, 34);
            this.TxtPtName.TabIndex = 45;
            // 
            // LblPtName
            // 
            this.LblPtName.AutoSize = true;
            this.LblPtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPtName.ForeColor = System.Drawing.Color.Red;
            this.LblPtName.Location = new System.Drawing.Point(529, 362);
            this.LblPtName.Name = "LblPtName";
            this.LblPtName.Size = new System.Drawing.Size(170, 29);
            this.LblPtName.TabIndex = 44;
            this.LblPtName.Text = "Patient Name";
            // 
            // CmbPtId
            // 
            this.CmbPtId.BackColor = System.Drawing.Color.White;
            this.CmbPtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPtId.FormattingEnabled = true;
            this.CmbPtId.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.CmbPtId.Location = new System.Drawing.Point(145, 394);
            this.CmbPtId.Name = "CmbPtId";
            this.CmbPtId.Size = new System.Drawing.Size(218, 37);
            this.CmbPtId.TabIndex = 43;
            this.CmbPtId.SelectedIndexChanged += new System.EventHandler(this.CmbPtId_SelectedIndexChanged);
            this.CmbPtId.SelectionChangeCommitted += new System.EventHandler(this.CmbPtId_SelectionChangeCommitted);
            // 
            // LblPtId
            // 
            this.LblPtId.AutoSize = true;
            this.LblPtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPtId.ForeColor = System.Drawing.Color.Red;
            this.LblPtId.Location = new System.Drawing.Point(140, 362);
            this.LblPtId.Name = "LblPtId";
            this.LblPtId.Size = new System.Drawing.Size(126, 29);
            this.LblPtId.TabIndex = 42;
            this.LblPtId.Text = "Patient ID";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(391, 183);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(121, 111);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 41;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // LblBloodTransfusion
            // 
            this.LblBloodTransfusion.AutoSize = true;
            this.LblBloodTransfusion.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBloodTransfusion.ForeColor = System.Drawing.Color.Red;
            this.LblBloodTransfusion.Location = new System.Drawing.Point(518, 195);
            this.LblBloodTransfusion.Name = "LblBloodTransfusion";
            this.LblBloodTransfusion.Size = new System.Drawing.Size(247, 34);
            this.LblBloodTransfusion.TabIndex = 40;
            this.LblBloodTransfusion.Text = "Blood Transfusion";
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
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
            this.BtnDonor.Click += new System.EventHandler(this.BtnDonor_Click);
            // 
            // BloodTransfusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnTransfer);
            this.Controls.Add(this.LblAvailableOrNot);
            this.Controls.Add(this.TxtBGroup);
            this.Controls.Add(this.LblBGroup);
            this.Controls.Add(this.TxtPtName);
            this.Controls.Add(this.LblPtName);
            this.Controls.Add(this.CmbPtId);
            this.Controls.Add(this.LblPtId);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.LblBloodTransfusion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloodTransfusion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodTransfusion";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 BtnTransfer;
        private System.Windows.Forms.Label LblAvailableOrNot;
        private System.Windows.Forms.TextBox TxtBGroup;
        private System.Windows.Forms.Label LblBGroup;
        private System.Windows.Forms.TextBox TxtPtName;
        private System.Windows.Forms.Label LblPtName;
        private System.Windows.Forms.ComboBox CmbPtId;
        private System.Windows.Forms.Label LblPtId;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label LblBloodTransfusion;
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