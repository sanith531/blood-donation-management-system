using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BldDonation
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            getData();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void getData()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from DonorTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblDBDonor.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from TransferTbl", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            LblDBTransfer.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("Select count (*) from EmployeeTbl", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            LblDBUsers.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("Select Sum(BStock) from BldTbl", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            int BStock = Convert.ToInt32(dt3.Rows[0][0].ToString());
            LblTot.Text = "" + BStock;

            SqlDataAdapter sda4 = new SqlDataAdapter("Select BStock  from BldTbl where BGroup='" + "A+" + "'", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            LblAPNum.Text = dt4.Rows[0][0].ToString();
            double APlusPercentage = (Convert.ToDouble(dt4.Rows[0][0].ToString()) / BStock) * 100;
            ProgressAPositive.Value =Convert.ToInt32( APlusPercentage);

            SqlDataAdapter sda5 = new SqlDataAdapter("Select BStock  from BldTbl where BGroup='" + "A-" + "'", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            LblANNum.Text = dt5.Rows[0][0].ToString();
            double AMinusPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / BStock) * 100;
            ProgressANegative.Value = Convert.ToInt32(AMinusPercentage);

            SqlDataAdapter sda6 = new SqlDataAdapter("Select BStock  from BldTbl where BGroup='" + "AB+" + "'", con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            LblABPNum.Text = dt6.Rows[0][0].ToString();
            double ABPlusPercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / BStock) * 100;
            ProgressABPositive.Value = Convert.ToInt32(ABPlusPercentage);

            SqlDataAdapter sda7 = new SqlDataAdapter("Select BStock  from BldTbl where BGroup='" + "AB-" + "'", con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            LblABNNum.Text = dt7.Rows[0][0].ToString();
            double ABMinusPercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / BStock) * 100;
            ProgressABNegative.Value = Convert.ToInt32(ABMinusPercentage);

            SqlDataAdapter sda8 = new SqlDataAdapter("Select BStock  from BldTbl where BGroup='" + "B+" + "'", con);
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);
            LblBPNum.Text = dt8.Rows[0][0].ToString();
            double BPlusPercentage = (Convert.ToDouble(dt8.Rows[0][0].ToString()) / BStock) * 100;
            ProgressBPositive.Value = Convert.ToInt32(BPlusPercentage);

            SqlDataAdapter sda9 = new SqlDataAdapter("Select BStock  from BldTbl where BGroup='" + "B-" + "'", con);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
            LblBNNum.Text = dt9.Rows[0][0].ToString();
            double BMinusPercentage = (Convert.ToDouble(dt9.Rows[0][0].ToString()) / BStock) * 100;
            ProgressBNegative.Value = Convert.ToInt32(BMinusPercentage);

            SqlDataAdapter sda10 = new SqlDataAdapter("Select BStock  from BldTbl where BGroup='" + "O+" + "'", con);
            DataTable dt10 = new DataTable();
            sda10.Fill(dt10);
            LblOPNum.Text = dt10.Rows[0][0].ToString();
            double OPlusPercentage = (Convert.ToDouble(dt10.Rows[0][0].ToString()) / BStock) * 100;
            ProgressOPositive.Value = Convert.ToInt32(OPlusPercentage);

            SqlDataAdapter sda11 = new SqlDataAdapter("Select BStock from BldTbl where BGroup='" + "O-" + "'", con);
            DataTable dt11 = new DataTable();
            sda11.Fill(dt11);
            LblONNum.Text = dt11.Rows[0][0].ToString();
            double OMinusPercentage = (Convert.ToDouble(dt11.Rows[0][0].ToString()) / BStock) * 100;
            ProgressONegative.Value = Convert.ToInt32(OMinusPercentage);



            con.Close();


        }
        private void LblBloodStock_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleProgressBar6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void BtnDonor_Click(object sender, EventArgs e)
        {
            Donors obj = new Donors();
            obj.Show();
            this.Hide();
        }

        private void BtnDonate_Click(object sender, EventArgs e)
        {
            DonateBlood obj = new DonateBlood();
            obj.Show();
            this.Hide();
        }

        private void BtnViewD_Click(object sender, EventArgs e)
        {
            ViewDonors obj = new ViewDonors();
            obj.Show();
            this.Hide();
        }

        private void BtnPatients_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void BtnViewPatients_Click(object sender, EventArgs e)
        {
            ViewPatients obj = new ViewPatients();
            obj.Show();
            this.Hide();
        }

        private void BtnBloodS_Click(object sender, EventArgs e)
        {
            BloodStock obj = new BloodStock();
            obj.Show();
            this.Hide();
        }

        private void BtnBloodT_Click(object sender, EventArgs e)
        {
            BloodTransfusion obj = new BloodTransfusion();
            obj.Show();
            this.Hide();
        }
    }
}
