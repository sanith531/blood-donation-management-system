using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BldDonation
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void BtnDonor_Click(object sender, EventArgs e)
        {
            Donors donor = new Donors();
            donor.Show();
            this.Hide();
        }

        private void BtnDonate_Click(object sender, EventArgs e)
        {
            DonateBlood dbld = new DonateBlood();
            dbld.Show();
            this.Hide();
        }

        private void BtnViewD_Click(object sender, EventArgs e)
        {
            ViewDonors vd = new ViewDonors();
            vd.Show();
            this.Hide();

        }

        private void BtnPatients_Click(object sender, EventArgs e)
        {
            Patients pa = new Patients();
            pa.Show();
            this.Hide();
        }

        private void BtnViewPatients_Click(object sender, EventArgs e)
        {
            ViewPatients vp = new ViewPatients();
            vp.Show();
            this.Hide();
        }

        private void BtnBloodS_Click(object sender, EventArgs e)
        {
            BloodStock bldStock = new BloodStock();
            bldStock.Show();
            this.Hide();

        }

        private void BtnBloodT_Click(object sender, EventArgs e)
        {
            BloodTransfusion bldTrans = new BloodTransfusion();
            bldTrans.Show();
            this.Hide();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            DashBoard dboard = new DashBoard();
            dboard.Show();
            this.Hide();
        }
    }
}
