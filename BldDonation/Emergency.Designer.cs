namespace BldDonation
{
    partial class Emergency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emergency));
            this.CmbBType = new System.Windows.Forms.ComboBox();
            this.LblBType = new System.Windows.Forms.Label();
            this.PatientDetailsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LblEmergency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDetailsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBType
            // 
            this.CmbBType.BackColor = System.Drawing.Color.White;
            this.CmbBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBType.FormattingEnabled = true;
            this.CmbBType.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.CmbBType.Location = new System.Drawing.Point(633, 189);
            this.CmbBType.Name = "CmbBType";
            this.CmbBType.Size = new System.Drawing.Size(218, 37);
            this.CmbBType.TabIndex = 66;
            // 
            // LblBType
            // 
            this.LblBType.AutoSize = true;
            this.LblBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBType.ForeColor = System.Drawing.Color.Red;
            this.LblBType.Location = new System.Drawing.Point(442, 189);
            this.LblBType.Name = "LblBType";
            this.LblBType.Size = new System.Drawing.Size(148, 29);
            this.LblBType.TabIndex = 65;
            this.LblBType.Text = "Blood Type";
            // 
            // PatientDetailsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatientDetailsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientDetailsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientDetailsDGV.ColumnHeadersHeight = 4;
            this.PatientDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientDetailsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientDetailsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDetailsDGV.Location = new System.Drawing.Point(25, 264);
            this.PatientDetailsDGV.Name = "PatientDetailsDGV";
            this.PatientDetailsDGV.RowHeadersVisible = false;
            this.PatientDetailsDGV.RowHeadersWidth = 51;
            this.PatientDetailsDGV.RowTemplate.Height = 24;
            this.PatientDetailsDGV.Size = new System.Drawing.Size(1269, 425);
            this.PatientDetailsDGV.TabIndex = 64;
            this.PatientDetailsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDetailsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientDetailsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientDetailsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientDetailsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientDetailsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatientDetailsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDetailsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PatientDetailsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientDetailsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDetailsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientDetailsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientDetailsDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.PatientDetailsDGV.ThemeStyle.ReadOnly = false;
            this.PatientDetailsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDetailsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientDetailsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDetailsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientDetailsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.PatientDetailsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDetailsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(529, 27);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(121, 111);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 63;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // LblEmergency
            // 
            this.LblEmergency.AutoSize = true;
            this.LblEmergency.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmergency.ForeColor = System.Drawing.Color.Red;
            this.LblEmergency.Location = new System.Drawing.Point(656, 39);
            this.LblEmergency.Name = "LblEmergency";
            this.LblEmergency.Size = new System.Drawing.Size(170, 34);
            this.LblEmergency.TabIndex = 62;
            this.LblEmergency.Text = "Emergency";
            // 
            // Emergency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 717);
            this.Controls.Add(this.CmbBType);
            this.Controls.Add(this.LblBType);
            this.Controls.Add(this.PatientDetailsDGV);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.LblEmergency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emergency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency";
            ((System.ComponentModel.ISupportInitialize)(this.PatientDetailsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbBType;
        private System.Windows.Forms.Label LblBType;
        private Guna.UI2.WinForms.Guna2DataGridView PatientDetailsDGV;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label LblEmergency;
    }
}