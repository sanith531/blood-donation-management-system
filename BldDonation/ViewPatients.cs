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
    public partial class ViewPatients : Form
    {
        public ViewPatients()
        {
            InitializeComponent();
            populate();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            string query = "select * from PatientsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewPatientsDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        int key = 0;
        private void ViewPatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtVPName.Text = ViewPatientsDGV.SelectedRows[0].Cells[1].Value.ToString();
            TxtVPAge.Text = ViewPatientsDGV.SelectedRows[0].Cells[2].Value.ToString();
            CmbVPGender.SelectedItem= ViewPatientsDGV.SelectedRows[0].Cells[3].Value.ToString();
            TxtVPPhone.Text= ViewPatientsDGV.SelectedRows[0].Cells[4].Value.ToString();
            TxtVPAddress.Text= ViewPatientsDGV.SelectedRows[0].Cells[5].Value.ToString();
            CmbVPBGroup.SelectedItem= ViewPatientsDGV.SelectedRows[0].Cells[6].Value.ToString();

            if(TxtVPName.Text== "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(ViewPatientsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Reset()
        {
            TxtVPName.Text = "";
            TxtVPAge.Text = "";
            CmbVPGender.SelectedIndex = -1;
            TxtVPPhone.Text = "";
            TxtVPAddress.Text = "";
            CmbVPBGroup.SelectedIndex = -1;
            key = 0;
        }

        private void BtnVPDelete_Click(object sender, EventArgs e)
        {
            if(key==0)
            {
                MessageBox.Show("Select the patient to delete");
            }

            else 
            {
                try
                {
                    String query = "Delete from PatientsTbl where PNum="+key+";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient successfully deleted");  
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

       /* private void LblPatients_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();
            this.Hide();
        }*/

        private void BtnVPEdit_Click(object sender, EventArgs e)
        {
            if (TxtVPName.Text == "" || TxtVPAge.Text == "" || CmbVPGender.SelectedIndex == -1 || TxtVPPhone.Text == "" || TxtVPAddress.Text == "" || CmbVPBGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    String query = "update PatientsTbl set PName='"+TxtVPName.Text+"',PAge='"+TxtVPAge.Text+"',PPhone='"+TxtVPPhone.Text+"',PGender='"+CmbVPGender.SelectedItem.ToString()+"',PAddress='"+TxtVPAddress.Text+"',PBGroup='"+CmbVPBGroup.SelectedItem.ToString()+"' where PNum="+key+";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient successfully updated");
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

        private void BtnPatients_Click(object sender, EventArgs e)
        {
            Patients pat = new Patients();
            pat.Show();
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
