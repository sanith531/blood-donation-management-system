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
using System.Web.UI.WebControls;

namespace BldDonation
{
    public partial class ViewDonors : Form
    {
        public ViewDonors()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            string query = "select * FROM DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewDonorDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        int key = 0;
        private void ViewDonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtVDName.Text = ViewDonorDGV.SelectedRows[0].Cells[1].Value.ToString();
            TxtVDAge.Text = ViewDonorDGV.SelectedRows[0].Cells[2].Value.ToString();
            CmbVDGender.SelectedItem = ViewDonorDGV.SelectedRows[0].Cells[3].Value.ToString();
            TxtVDPhone.Text = ViewDonorDGV.SelectedRows[0].Cells[4].Value.ToString();
            TxtVDAddress.Text = ViewDonorDGV.SelectedRows[0].Cells[5].Value.ToString();
            CmbVDBGroup.SelectedItem = ViewDonorDGV.SelectedRows[0].Cells[6].Value.ToString();

            if(TxtVDName.Text=="")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(ViewDonorDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        private void Reset()
        {
            TxtVDName.Text = "";
            TxtVDAge.Text = "";
            CmbVDGender.SelectedIndex = -1;
            TxtVDPhone.Text = "";
            TxtVDAddress.Text = "";
            CmbVDBGroup.SelectedIndex = -1;
            key = 0;
        }
        private void BtnVDDelete_Click(object sender, EventArgs e)
        {
            if(key==0)
            {
                MessageBox.Show("Select the donor to delete");
            }

            else
            {
                try
                {
                    String query = "Delete from DonorTbl where DNum="+key+";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor successfully deleted");
                    con.Close();
                    Reset();
                    populate();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnVDEdit_Click(object sender, EventArgs e)
        {
            if(TxtVDName.Text=="" || TxtVDAge.Text=="" || CmbVDGender.SelectedIndex==-1 || TxtVDPhone.Text=="" || TxtVDAddress.Text=="" || CmbVDBGroup.SelectedIndex==-1)
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    String query = "update  DonorTbl set DName='"+TxtVDName.Text+"',DAge='"+TxtVDAge.Text+"',DGender='"+CmbVDGender.SelectedItem.ToString()+"',DPhone='"+TxtVDPhone.Text+"',DAddress='"+TxtVDAddress.Text+"',DBGroup='"+CmbVDBGroup.SelectedItem.ToString()+"' where DNum=" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor successfully updated");
                    con.Close();
                    Reset();
                    populate();
                }

                catch (Exception ex)
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

        private void BtnDonate_Click(object sender, EventArgs e)
        {
            DonateBlood obj = new DonateBlood();
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
