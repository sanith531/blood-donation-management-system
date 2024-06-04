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
    public partial class DonateBlood : Form
    {
        public DonateBlood()
        {
            InitializeComponent();
            populate();
            bloodStock();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            string query = "select * from DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewDonateDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void bloodStock()
        {
            con.Open();
            string query = "select * from BldTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BloodStockDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        int oldStock;
        private void GetStock(String Bgroup)
        {
            // Helps to get the actual stock of blood based on particular blood group

            con.Open();
            string query = "select * from BldTbl where BGroup='" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                oldStock = Convert.ToInt32(dr["BStock"].ToString());
            }
            con.Close();
        }
        private void ViewDonateDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDName.Text = ViewDonateDGV.SelectedRows[0].Cells[1].Value.ToString();
            TxtBGroup.Text = ViewDonateDGV.SelectedRows[0].Cells[6].Value.ToString();
            GetStock(TxtBGroup.Text);
        }

        private void reset()
        {
            TxtDName.Text = "";
            TxtBGroup.Text = "";

            
        }

        private void BtnDonate_Click(object sender, EventArgs e)
        {
            if(TxtDName.Text=="" )
            {
                MessageBox.Show("Select a donor");
            }

            else
            {
                try
                {
                    int stock = oldStock+1;

                    string query ="update BldTbl set BStock="+stock+" where BGroup='"+TxtBGroup.Text+"';";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation is successful");
                    con.Close();
                    reset();
                    bloodStock();
                    
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnDonor_Click(object sender, EventArgs e)
        {
            Donors obj = new Donors();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
