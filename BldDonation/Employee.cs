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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void LblLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Reset()
        {
            TxtEName.Text = "";
            TxtPassword.Text = "";
            key = 0;
        }

        private void populate()
        {
            con.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void BtnESave_Click(object sender, EventArgs e)
        {
            if (TxtEName.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    string query = "insert into EmployeeTbl values('" + TxtEName.Text + "','" + TxtPassword.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Saved");
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


        int key = 0;
        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtEName.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            TxtPassword.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();

            if (TxtEName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmpDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void BtnEDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Employee to Delete");

            }
            else
            {
                try
                {
                    string query = "Delete from EmployeeTbl where EmpNum=" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Deleted");
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

        private void BtnEEdit_Click(object sender, EventArgs e)
        {
            if (TxtEName.Text == "" || TxtPassword.Text== "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "update EmployeeTbl set EmpId='" + TxtEName.Text + " ',EmpPassword='" + TxtPassword.Text + " ' where EmpNum=" + key + ";";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Updated");
                    con.Close();
                    Reset();
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
