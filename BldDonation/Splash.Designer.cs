namespace BldDonation
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.ProgressSplash = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LblBloodBMS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressSplash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressSplash
            // 
            this.ProgressSplash.Controls.Add(this.guna2CirclePictureBox1);
            this.ProgressSplash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ProgressSplash.FillThickness = 15;
            this.ProgressSplash.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressSplash.ForeColor = System.Drawing.Color.White;
            this.ProgressSplash.Location = new System.Drawing.Point(554, 197);
            this.ProgressSplash.Minimum = 0;
            this.ProgressSplash.Name = "ProgressSplash";
            this.ProgressSplash.ProgressColor = System.Drawing.Color.Red;
            this.ProgressSplash.ProgressColor2 = System.Drawing.Color.Red;
            this.ProgressSplash.ProgressThickness = 15;
            this.ProgressSplash.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressSplash.Size = new System.Drawing.Size(203, 203);
            this.ProgressSplash.TabIndex = 0;
            this.ProgressSplash.Text = "guna2CircleProgressBar1";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(59, 55);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(87, 87);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // LblBloodBMS
            // 
            this.LblBloodBMS.AutoSize = true;
            this.LblBloodBMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBloodBMS.ForeColor = System.Drawing.Color.Red;
            this.LblBloodBMS.Location = new System.Drawing.Point(242, 45);
            this.LblBloodBMS.Name = "LblBloodBMS";
            this.LblBloodBMS.Size = new System.Drawing.Size(838, 51);
            this.LblBloodBMS.TabIndex = 1;
            this.LblBloodBMS.Text = "BLOOD BANK MANAGEMENT SYSTEM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 670);
            this.Controls.Add(this.LblBloodBMS);
            this.Controls.Add(this.ProgressSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ProgressSplash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressSplash;
        private System.Windows.Forms.Label LblBloodBMS;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}