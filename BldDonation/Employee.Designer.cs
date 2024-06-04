namespace BldDonation
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.EmpDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnEEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LblPassword = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TxtEName = new System.Windows.Forms.TextBox();
            this.LblEName = new System.Windows.Forms.Label();
            this.LblEmployee = new System.Windows.Forms.Label();
            this.BtnESave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnEDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LblLogout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(908, 518);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(218, 34);
            this.TxtPassword.TabIndex = 119;
            // 
            // EmpDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmpDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpDGV.ColumnHeadersHeight = 29;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmpDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpDGV.Location = new System.Drawing.Point(106, 164);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersVisible = false;
            this.EmpDGV.RowHeadersWidth = 51;
            this.EmpDGV.RowTemplate.Height = 25;
            this.EmpDGV.Size = new System.Drawing.Size(1017, 311);
            this.EmpDGV.TabIndex = 117;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EmpDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpDGV.ThemeStyle.HeaderStyle.Height = 29;
            this.EmpDGV.ThemeStyle.ReadOnly = false;
            this.EmpDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EmpDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.RowsStyle.Height = 25;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.HotPink;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // BtnEEdit
            // 
            this.BtnEEdit.ActiveBorderThickness = 1;
            this.BtnEEdit.ActiveCornerRadius = 20;
            this.BtnEEdit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnEEdit.ActiveForecolor = System.Drawing.Color.Transparent;
            this.BtnEEdit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnEEdit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEEdit.BackgroundImage")));
            this.BtnEEdit.ButtonText = "Edit";
            this.BtnEEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnEEdit.IdleBorderThickness = 1;
            this.BtnEEdit.IdleCornerRadius = 20;
            this.BtnEEdit.IdleFillColor = System.Drawing.Color.Lime;
            this.BtnEEdit.IdleForecolor = System.Drawing.Color.Black;
            this.BtnEEdit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnEEdit.Location = new System.Drawing.Point(533, 607);
            this.BtnEEdit.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEEdit.Name = "BtnEEdit";
            this.BtnEEdit.Size = new System.Drawing.Size(191, 48);
            this.BtnEEdit.TabIndex = 116;
            this.BtnEEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEEdit.Click += new System.EventHandler(this.BtnEEdit_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.Red;
            this.LblPassword.Location = new System.Drawing.Point(717, 523);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(128, 29);
            this.LblPassword.TabIndex = 115;
            this.LblPassword.Text = "Password";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(473, 26);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(121, 111);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 114;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // TxtEName
            // 
            this.TxtEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEName.Location = new System.Drawing.Point(230, 518);
            this.TxtEName.Name = "TxtEName";
            this.TxtEName.Size = new System.Drawing.Size(218, 34);
            this.TxtEName.TabIndex = 113;
            // 
            // LblEName
            // 
            this.LblEName.AutoSize = true;
            this.LblEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEName.ForeColor = System.Drawing.Color.Red;
            this.LblEName.Location = new System.Drawing.Point(104, 523);
            this.LblEName.Name = "LblEName";
            this.LblEName.Size = new System.Drawing.Size(82, 29);
            this.LblEName.TabIndex = 112;
            this.LblEName.Text = "Name";
            // 
            // LblEmployee
            // 
            this.LblEmployee.AutoSize = true;
            this.LblEmployee.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployee.ForeColor = System.Drawing.Color.Red;
            this.LblEmployee.Location = new System.Drawing.Point(617, 61);
            this.LblEmployee.Name = "LblEmployee";
            this.LblEmployee.Size = new System.Drawing.Size(151, 34);
            this.LblEmployee.TabIndex = 111;
            this.LblEmployee.Text = "Employee";
            // 
            // BtnESave
            // 
            this.BtnESave.ActiveBorderThickness = 1;
            this.BtnESave.ActiveCornerRadius = 20;
            this.BtnESave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnESave.ActiveForecolor = System.Drawing.Color.Transparent;
            this.BtnESave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnESave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnESave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnESave.BackgroundImage")));
            this.BtnESave.ButtonText = "Save";
            this.BtnESave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnESave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnESave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnESave.IdleBorderThickness = 1;
            this.BtnESave.IdleCornerRadius = 20;
            this.BtnESave.IdleFillColor = System.Drawing.Color.Aqua;
            this.BtnESave.IdleForecolor = System.Drawing.Color.Black;
            this.BtnESave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnESave.Location = new System.Drawing.Point(275, 607);
            this.BtnESave.Margin = new System.Windows.Forms.Padding(5);
            this.BtnESave.Name = "BtnESave";
            this.BtnESave.Size = new System.Drawing.Size(191, 48);
            this.BtnESave.TabIndex = 120;
            this.BtnESave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnESave.Click += new System.EventHandler(this.BtnESave_Click);
            // 
            // BtnEDelete
            // 
            this.BtnEDelete.ActiveBorderThickness = 1;
            this.BtnEDelete.ActiveCornerRadius = 20;
            this.BtnEDelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnEDelete.ActiveForecolor = System.Drawing.Color.Transparent;
            this.BtnEDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnEDelete.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEDelete.BackgroundImage")));
            this.BtnEDelete.ButtonText = "Delete";
            this.BtnEDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnEDelete.IdleBorderThickness = 1;
            this.BtnEDelete.IdleCornerRadius = 20;
            this.BtnEDelete.IdleFillColor = System.Drawing.Color.Tomato;
            this.BtnEDelete.IdleForecolor = System.Drawing.Color.Black;
            this.BtnEDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnEDelete.Location = new System.Drawing.Point(791, 607);
            this.BtnEDelete.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEDelete.Name = "BtnEDelete";
            this.BtnEDelete.Size = new System.Drawing.Size(191, 48);
            this.BtnEDelete.TabIndex = 121;
            this.BtnEDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEDelete.Click += new System.EventHandler(this.BtnEDelete_Click);
            // 
            // LblLogout
            // 
            this.LblLogout.AutoSize = true;
            this.LblLogout.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogout.ForeColor = System.Drawing.Color.Red;
            this.LblLogout.Location = new System.Drawing.Point(1188, 664);
            this.LblLogout.Name = "LblLogout";
            this.LblLogout.Size = new System.Drawing.Size(106, 34);
            this.LblLogout.TabIndex = 122;
            this.LblLogout.Text = "Logout";
            this.LblLogout.Click += new System.EventHandler(this.LblLogout_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 717);
            this.Controls.Add(this.LblLogout);
            this.Controls.Add(this.BtnEDelete);
            this.Controls.Add(this.BtnESave);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.EmpDGV);
            this.Controls.Add(this.BtnEEdit);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.TxtEName);
            this.Controls.Add(this.LblEName);
            this.Controls.Add(this.LblEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPassword;
        private Guna.UI2.WinForms.Guna2DataGridView EmpDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEEdit;
        private System.Windows.Forms.Label LblPassword;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.TextBox TxtEName;
        private System.Windows.Forms.Label LblEName;
        private System.Windows.Forms.Label LblEmployee;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnESave;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEDelete;
        private System.Windows.Forms.Label LblLogout;
    }
}