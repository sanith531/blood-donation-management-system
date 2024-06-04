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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            TxtPName.Text = "";
            TxtPAge.Text = "";
            CmbPGender.SelectedIndex = -1;
            TxtPPhone.Text = "";
            TxtPAddress.Text = "";
            CmbPBGroup.SelectedIndex = -1;
        }
        private void BtnPatientSave_Click(object sender, EventArgs e)
        {
            if(TxtPName.Text=="" || TxtPAge.Text=="" || CmbPGender.SelectedIndex==-1 || TxtPPhone.Text=="" || TxtPAddress.Text=="" || CmbPBGroup.SelectedIndex==-1)
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try 
                {
                    String query = "insert into PatientsTbl values('" + TxtPName.Text + "','" + TxtPAge.Text + "','" + CmbPGender.SelectedItem.ToString() + "','" + TxtPPhone.Text + "','" + TxtPAddress.Text + "','" + CmbPBGroup.SelectedItem.ToString() + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient successfully saved");
                    con.Close();
                    Reset();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /*private void LblViewPatients_Click(object sender, EventArgs e)
        {
            ViewPatients VP = new ViewPatients();
            VP.Show();
            this.Hide();
        }*/

       /* private void LblBTransfusion_Click(object sender, EventArgs e)
        {
            BloodTransfusion bt = new BloodTransfusion();
            bt.Show();
            this.Hide();
        }*/

        private void BtnViewPatients_Click(object sender, EventArgs e)
        {
            ViewPatients obj = new ViewPatients();
            obj.Show();
            this.Hide();
        }

        private void BtnBloodT_Click(object sender, EventArgs e)
        {
            BloodTransfusion obj = new BloodTransfusion();
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

        private void BtnBloodS_Click(object sender, EventArgs e)
        {
            BloodStock obj = new BloodStock();
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
