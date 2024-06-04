namespace BldDonation
{
    partial class BloodStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LblBloodStock = new System.Windows.Forms.Label();
            this.BloodStockDGV = new Guna.UI2.WinForms.Guna2DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.BloodStockDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(533, 137);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(121, 111);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 58;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // LblBloodStock
            // 
            this.LblBloodStock.AutoSize = true;
            this.LblBloodStock.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBloodStock.ForeColor = System.Drawing.Color.Red;
            this.LblBloodStock.Location = new System.Drawing.Point(660, 149);
            this.LblBloodStock.Name = "LblBloodStock";
            this.LblBloodStock.Size = new System.Drawing.Size(175, 34);
            this.LblBloodStock.TabIndex = 57;
            this.LblBloodStock.Text = "Blood Stock";
            // 
            // BloodStockDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BloodStockDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BloodStockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BloodStockDGV.ColumnHeadersHeight = 29;
            this.BloodStockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BloodStockDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.BloodStockDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BloodStockDGV.Location = new System.Drawing.Point(309, 304);
            this.BloodStockDGV.Name = "BloodStockDGV";
            this.BloodStockDGV.RowHeadersVisible = false;
            this.BloodStockDGV.RowHeadersWidth = 51;
            this.BloodStockDGV.RowTemplate.Height = 25;
            this.BloodStockDGV.Size = new System.Drawing.Size(728, 307);
            this.BloodStockDGV.TabIndex = 111;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BloodStockDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BloodStockDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BloodStockDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BloodStockDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BloodStockDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodStockDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BloodStockDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BloodStockDGV.ThemeStyle.HeaderStyle.Height = 29;
            this.BloodStockDGV.ThemeStyle.ReadOnly = false;
            this.BloodStockDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BloodStockDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BloodStockDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodStockDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.BloodStockDGV.ThemeStyle.RowsStyle.Height = 25;
            this.BloodStockDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.HotPink;
            this.BloodStockDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 100);
            this.panel1.TabIndex = 112;
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
            // BloodStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BloodStockDGV);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.LblBloodStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloodStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodStock";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodStockDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label LblBloodStock;
        private Guna.UI2.WinForms.Guna2DataGridView BloodStockDGV;
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