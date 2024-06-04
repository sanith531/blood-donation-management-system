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
using System.IO;
using System.Reflection;

namespace BldDonation
{
    public partial class Login : Form
    {
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
            String directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + directory + @"\BloodBankDb.mdf;Integrated Security=True;Connect Timeout=30");
        }
        
        


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from EmployeeTbl where EmpId='" + TxtUN.Text + "' and EmpPassword='" + TxtPW.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                HomePage hPage = new HomePage();
                hPage.Show();
                this.Hide();
                con.Close();
            }

            else
            {
                MessageBox.Show("Wrong Username or password");
            }

            con.Close();
        }

        private void btnCB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
