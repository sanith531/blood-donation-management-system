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
using Guna.UI2.WinForms.Enums;

namespace BldDonation
{
    public partial class Donors : Form
    {
        public Donors()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            TxtDName.Text = "";
            TxtDAge.Text = "";
            CmbDGender.SelectedIndex = -1;
            TxtDPhone.Text = "";
            TxtDAddress.Text = "";
            CmbDBGroup.SelectedIndex = -1;
        }
        private void BtnDonorSave_Click(object sender, EventArgs e)
        {
            if(TxtDName.Text=="" || TxtDAge.Text=="" || CmbDGender.SelectedIndex==-1 ||  TxtDPhone.Text==""  || TxtDAddress.Text=="" || CmbDBGroup.SelectedIndex==-1)
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try 
                {
                    String query = "insert into DonorTbl values('"+TxtDName.Text+"','"+TxtDAge.Text+"','"+CmbDGender.SelectedItem.ToString()+"','"+TxtDPhone.Text+"','"+TxtDAddress.Text+"','"+CmbDBGroup.SelectedItem.ToString()+"')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor successfully saved");
                    con.Close();
                    Reset();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnDonate_Click(object sender, EventArgs e)
        {
            DonateBlood obj = new DonateBlood();
            obj.Show();
            this.Close();
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
