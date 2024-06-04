namespace BldDonation
{
    partial class ViewPatients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatients));
            this.ViewPatientsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TxtVPAge = new System.Windows.Forms.TextBox();
            this.BtnVPEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVPDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TxtVPAddress = new System.Windows.Forms.TextBox();
            this.LblVPAddress = new System.Windows.Forms.Label();
            this.CmbVPBGroup = new System.Windows.Forms.ComboBox();
            this.LblVPBGroup = new System.Windows.Forms.Label();
            this.CmbVPGender = new System.Windows.Forms.ComboBox();
            this.LblVPGender = new System.Windows.Forms.Label();
            this.TxtVPPhone = new System.Windows.Forms.TextBox();
            this.LblVPPhone = new System.Windows.Forms.Label();
            this.LblVPAge = new System.Windows.Forms.Label();
            this.TxtVPName = new System.Windows.Forms.TextBox();
            this.LblVPName = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.ViewPatientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPatientsDGV
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.ViewPatientsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewPatientsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.ViewPatientsDGV.ColumnHeadersHeight = 29;
            this.ViewPatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewPatientsDGV.DefaultCellStyle = dataGridViewCellStyle21;
            this.ViewPatientsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ViewPatientsDGV.Location = new System.Drawing.Point(24, 439);
            this.ViewPatientsDGV.Name = "ViewPatientsDGV";
            this.ViewPatientsDGV.RowHeadersVisible = false;
            this.ViewPatientsDGV.RowHeadersWidth = 51;
            this.ViewPatientsDGV.RowTemplate.Height = 25;
            this.ViewPatientsDGV.Size = new System.Drawing.Size(1270, 228);
            this.ViewPatientsDGV.TabIndex = 85;
            this.ViewPatientsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ViewPatientsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ViewPatientsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ViewPatientsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ViewPatientsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ViewPatientsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ViewPatientsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ViewPatientsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ViewPatientsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ViewPatientsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatientsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ViewPatientsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ViewPatientsDGV.ThemeStyle.HeaderStyle.Height = 29;
            this.ViewPatientsDGV.ThemeStyle.ReadOnly = false;
            this.ViewPatientsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ViewPatientsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ViewPatientsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatientsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.ViewPatientsDGV.ThemeStyle.RowsStyle.Height = 25;
            this.ViewPatientsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.HotPink;
            this.ViewPatientsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ViewPatientsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewPatientsDGV_CellContentClick);
            // 
            // TxtVPAge
            // 
            this.TxtVPAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVPAge.Location = new System.Drawing.Point(311, 284);
            this.TxtVPAge.Name = "TxtVPAge";
            this.TxtVPAge.Size = new System.Drawing.Size(178, 34);
            this.TxtVPAge.TabIndex = 84;
            // 
            // BtnVPEdit
            // 
            this.BtnVPEdit.ActiveBorderThickness = 1;
            this.BtnVPEdit.ActiveCornerRadius = 20;
            this.BtnVPEdit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnVPEdit.ActiveForecolor = System.Drawing.Color.Transparent;
            this.BtnVPEdit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnVPEdit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVPEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVPEdit.BackgroundImage")));
            this.BtnVPEdit.ButtonText = "Edit";
            this.BtnVPEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVPEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVPEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnVPEdit.IdleBorderThickness = 1;
            this.BtnVPEdit.IdleCornerRadius = 20;
            this.BtnVPEdit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnVPEdit.IdleForecolor = System.Drawing.Color.Black;
            this.BtnVPEdit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnVPEdit.Location = new System.Drawing.Point(1110, 281);
            this.BtnVPEdit.Margin = new System.Windows.Forms.Padding(5);
            this.BtnVPEdit.Name = "BtnVPEdit";
            this.BtnVPEdit.Size = new System.Drawing.Size(156, 48);
            this.BtnVPEdit.TabIndex = 83;
            this.BtnVPEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVPEdit.Click += new System.EventHandler(this.BtnVPEdit_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(477, 127);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(121, 111);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 82;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(604, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 81;
            this.label1.Text = "Patients List";
            // 
            // BtnVPDelete
            // 
            this.BtnVPDelete.ActiveBorderThickness = 1;
            this.BtnVPDelete.ActiveCornerRadius = 20;
            this.BtnVPDelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnVPDelete.ActiveForecolor = System.Drawing.Color.Transparent;
            this.BtnVPDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnVPDelete.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVPDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVPDelete.BackgroundImage")));
            this.BtnVPDelete.ButtonText = "Delete";
            this.BtnVPDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVPDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVPDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnVPDelete.IdleBorderThickness = 1;
            this.BtnVPDelete.IdleCornerRadius = 20;
            this.BtnVPDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnVPDelete.IdleForecolor = System.Drawing.Color.Black;
            this.BtnVPDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnVPDelete.Location = new System.Drawing.Point(1110, 358);
            this.BtnVPDelete.Margin = new System.Windows.Forms.Padding(5);
            this.BtnVPDelete.Name = "BtnVPDelete";
            this.BtnVPDelete.Size = new System.Drawing.Size(156, 48);
            this.BtnVPDelete.TabIndex = 80;
            this.BtnVPDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVPDelete.Click += new System.EventHandler(this.BtnVPDelete_Click);
            // 
            // TxtVPAddress
            // 
            this.TxtVPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVPAddress.Location = new System.Drawing.Point(311, 369);
            this.TxtVPAddress.Name = "TxtVPAddress";
            this.TxtVPAddress.Size = new System.Drawing.Size(676, 34);
            this.TxtVPAddress.TabIndex = 79;
            // 
            // LblVPAddress
            // 
            this.LblVPAddress.AutoSize = true;
            this.LblVPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVPAddress.ForeColor = System.Drawing.Color.Red;
            this.LblVPAddress.Location = new System.Drawing.Point(306, 337);
            this.LblVPAddress.Name = "LblVPAddress";
            this.LblVPAddress.Size = new System.Drawing.Size(109, 29);
            this.LblVPAddress.TabIndex = 78;
            this.LblVPAddress.Text = "Address";
            // 
            // CmbVPBGroup
            // 
            this.CmbVPBGroup.BackColor = System.Drawing.Color.White;
            this.CmbVPBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbVPBGroup.FormattingEnabled = true;
            this.CmbVPBGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.CmbVPBGroup.Location = new System.Drawing.Point(67, 369);
            this.CmbVPBGroup.Name = "CmbVPBGroup";
            this.CmbVPBGroup.Size = new System.Drawing.Size(218, 37);
            this.CmbVPBGroup.TabIndex = 77;
            // 
            // LblVPBGroup
            // 
            this.LblVPBGroup.AutoSize = true;
            this.LblVPBGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVPBGroup.ForeColor = System.Drawing.Color.Red;
            this.LblVPBGroup.Location = new System.Drawing.Point(62, 337);
            this.LblVPBGroup.Name = "LblVPBGroup";
            this.LblVPBGroup.Size = new System.Drawing.Size(161, 29);
            this.LblVPBGroup.TabIndex = 76;
            this.LblVPBGroup.Text = "Blood Group";
            // 
            // CmbVPGender
            // 
            this.CmbVPGender.BackColor = System.Drawing.Color.White;
            this.CmbVPGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbVPGender.FormattingEnabled = true;
            this.CmbVPGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.CmbVPGender.Location = new System.Drawing.Point(823, 281);
            this.CmbVPGender.Name = "CmbVPGender";
            this.CmbVPGender.Size = new System.Drawing.Size(218, 37);
            this.CmbVPGender.TabIndex = 75;
            // 
            // LblVPGender
            // 
            this.LblVPGender.AutoSize = true;
            this.LblVPGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVPGender.ForeColor = System.Drawing.Color.Red;
            this.LblVPGender.Location = new System.Drawing.Point(818, 249);
            this.LblVPGender.Name = "LblVPGender";
            this.LblVPGender.Size = new System.Drawing.Size(100, 29);
            this.LblVPGender.TabIndex = 74;
            this.LblVPGender.Text = "Gender";
            // 
            // TxtVPPhone
            // 
            this.TxtVPPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVPPhone.Location = new System.Drawing.Point(554, 281);
            this.TxtVPPhone.Name = "TxtVPPhone";
            this.TxtVPPhone.Size = new System.Drawing.Size(218, 34);
            this.TxtVPPhone.TabIndex = 73;
            // 
            // LblVPPhone
            // 
            this.LblVPPhone.AutoSize = true;
            this.LblVPPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVPPhone.ForeColor = System.Drawing.Color.Red;
            this.LblVPPhone.Location = new System.Drawing.Point(549, 249);
            this.LblVPPhone.Name = "LblVPPhone";
            this.LblVPPhone.Size = new System.Drawing.Size(240, 29);
            this.LblVPPhone.TabIndex = 72;
            this.LblVPPhone.Text = "Telephone Number";
            // 
            // LblVPAge
            // 
            this.LblVPAge.AutoSize = true;
            this.LblVPAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVPAge.ForeColor = System.Drawing.Color.Red;
            this.LblVPAge.Location = new System.Drawing.Point(306, 249);
            this.LblVPAge.Name = "LblVPAge";
            this.LblVPAge.Size = new System.Drawing.Size(59, 29);
            this.LblVPAge.TabIndex = 71;
            this.LblVPAge.Text = "Age";
            // 
            // TxtVPName
            // 
            this.TxtVPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVPName.Location = new System.Drawing.Point(67, 282);
            this.TxtVPName.Name = "TxtVPName";
            this.TxtVPName.Size = new System.Drawing.Size(218, 34);
            this.TxtVPName.TabIndex = 70;
            // 
            // LblVPName
            // 
            this.LblVPName.AutoSize = true;
            this.LblVPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVPName.ForeColor = System.Drawing.Color.Red;
            this.LblVPName.Location = new System.Drawing.Point(62, 250);
            this.LblVPName.Name = "LblVPName";
            this.LblVPName.Size = new System.Drawing.Size(82, 29);
            this.LblVPName.TabIndex = 69;
            this.LblVPName.Text = "Name";
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
            this.BtnDonor.Click += new System.EventHandler(this.BtnDonor_Click);
            // 
            // ViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewPatientsDGV);
            this.Controls.Add(this.TxtVPAge);
            this.Controls.Add(this.BtnVPEdit);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVPDelete);
            this.Controls.Add(this.TxtVPAddress);
            this.Controls.Add(this.LblVPAddress);
            this.Controls.Add(this.CmbVPBGroup);
            this.Controls.Add(this.LblVPBGroup);
            this.Controls.Add(this.CmbVPGender);
            this.Controls.Add(this.LblVPGender);
            this.Controls.Add(this.TxtVPPhone);
            this.Controls.Add(this.LblVPPhone);
            this.Controls.Add(this.LblVPAge);
            this.Controls.Add(this.TxtVPName);
            this.Controls.Add(this.LblVPName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPatients";
            ((System.ComponentModel.ISupportInitialize)(this.ViewPatientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView ViewPatientsDGV;
        private System.Windows.Forms.TextBox TxtVPAge;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnVPEdit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnVPDelete;
        private System.Windows.Forms.TextBox TxtVPAddress;
        private System.Windows.Forms.Label LblVPAddress;
        private System.Windows.Forms.ComboBox CmbVPBGroup;
        private System.Windows.Forms.Label LblVPBGroup;
        private System.Windows.Forms.ComboBox CmbVPGender;
        private System.Windows.Forms.Label LblVPGender;
        private System.Windows.Forms.TextBox TxtVPPhone;
        private System.Windows.Forms.Label LblVPPhone;
        private System.Windows.Forms.Label LblVPAge;
        private System.Windows.Forms.TextBox TxtVPName;
        private System.Windows.Forms.Label LblVPName;
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