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
            SqlCommand cmd = new SqlCommand("Select Email, Password from Customer where Email = @Email and Password = @Password", con);
            cmd.Parameters.AddWithValue("@Email", CustomerEmailTextbox.Text);
            cmd.Parameters.AddWithValue("@Password", CustomerPasswordTextbox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                CustomerLoginFailedLabel.Text = "Login Successful!";
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
            SqlCommand cmd = new SqlCommand("Select Email, Password, Type from Employee where Email = @Email and Password = @Password", con);
            cmd.Parameters.AddWithValue("@Email", EmployeeEmailTextbox.Text);
            cmd.Parameters.AddWithValue("@Password", EmployeePasswordTextbox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                //Checks if the employee is a manager
                if (dr.Read() && dr["Type"].ToString() == "Manager")
                {
                    ManagerMenu managerMenu = new ManagerMenu();
                    managerMenu.Show();
                    this.Hide();
                }
                //If not a manager, loads the regular employee menu
                else
                {

                    EmployeeMenu employeeMenu = new EmployeeMenu();
                    employeeMenu.Show();
                    this.Hide();
                }
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
