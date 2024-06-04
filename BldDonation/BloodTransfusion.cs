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
    public partial class BloodTransfusion : Form
    {
        public BloodTransfusion()
        {
            InitializeComponent();
            fillPatientCb();
         
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void fillPatientCb()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select PNum from PatientsTbl ", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PNum", typeof(int));
            dt.Load(rdr);
            CmbPtId.ValueMember = "PNum";
            CmbPtId.DataSource = dt;
            con.Close();


        }


        private void getData()
        {
            //Helps to get theblood group and name of the patient

            con.Open();
            string query = "select * from PatientsTbl where PNum=" + CmbPtId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TxtPtName.Text = dr["PName"].ToString();
                TxtBGroup.Text = dr["PBGroup"].ToString();
            }
            con.Close();
        }

        int stock=0;

        private void getStock(string Bgroup)
        {
            //Helps to get the actual stock of the blood based on particular blood group

            con.Open();
            string query = "select * from BldTbl where BGroup = '" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }
            con.Close();
        }

        private void CmbPtId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getData();
            getStock(TxtBGroup.Text);

            if(stock>0)
            {
                BtnTransfer.Visible = true;
                LblAvailableOrNot.Text = "Available Stock";
                LblAvailableOrNot.Visible = true;
            }

            else
            {
                LblAvailableOrNot.Text = "Stock not available";
                LblAvailableOrNot.Visible = true;
            }
        }

        /*private void LblPatients_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();
            this.Hide();
        }*/

        private void Reset()
        {
            TxtPtName.Text = "";
            TxtBGroup.Text = "";
            LblAvailableOrNot.Visible = false;
            BtnTransfer.Visible = false;
        }

        private void updateStock()
        {
            int newStock = stock - 1;

            try
            {
                string query = "update BldTbl set BStock=" + newStock + " where BGroup='" + TxtBGroup.Text + "';";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            if(TxtPtName.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into TransferTbl values('" + TxtPtName.Text + "','" + TxtBGroup.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfull Transfer");
                    con.Close();
                    getStock(TxtBGroup.Text);
                    updateStock();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       /* private void LblBStock_Click(object sender, EventArgs e)
        {
            BloodStock bs = new BloodStock();
            bs.Show();
            this.Hide();
        }
       */
        private void CmbPtId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnPatients_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void BtnBloodS_Click(object sender, EventArgs e)
        {
            BloodStock obj = new BloodStock();
            obj.Show();
            this.Hide();
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

        private void BtnViewPatients_Click(object sender, EventArgs e)
        {
            ViewPatients obj = new ViewPatients();
            obj.Show();
            this.Hide();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            DashBoard obj = new DashBoard();
            obj.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
