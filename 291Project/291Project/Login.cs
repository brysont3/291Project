using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CustomerLoginButton_Click(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CID, Email, Password from Customer where Email = @Email and Password = @Password", con);
            cmd.Parameters.AddWithValue("@Email", CustomerEmailTextbox.Text);
            cmd.Parameters.AddWithValue("@Password", CustomerPasswordTextbox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                dr.Read();
                Program.CustomerID = dr.GetInt32(0);
                this.Close();
            }
            else
            {
                CustomerLoginFailedLabel.Text = "Login Failed";
            }
            con.Close();
            CustomerLoginFailedLabel.Visible = true;
        }


        private void EmployeeLoginButton_Click(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            SqlCommand cmd = new SqlCommand("Select EID, Email, Password, Type from Employee where Email = @Email and Password = @Password", con);
            cmd.Parameters.AddWithValue("@Email", EmployeeEmailTextbox.Text);
            cmd.Parameters.AddWithValue("@Password", EmployeePasswordTextbox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                Program.EmployeeID = dr.GetInt32(0);
                Program.EmployeeType = dr["Type"].ToString();
                this.Close();
            }

            else
            {
                EmployeeLoginFailedLabel.Text = "Login Failed";
            }
            con.Close();
            EmployeeLoginFailedLabel.Visible = true;
        }
    }
}
