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

namespace _291Project.Customer
{
    public partial class InfoEdit : Form
    {
        public InfoEdit()
        {
            InitializeComponent();
        }


        private void load_info()
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName, City, State, ZipCode, Telephone, Email, Password, " +
                "CreditCard, AccountType FROM dbo.Customer WHERE(CID = @user)", con);
            cmd.Parameters.AddWithValue("@user", Program.CustomerID.ToString());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();

         
        }

        private void InfoEdit_Load(object sender, EventArgs e)
        {
            load_info();
            string str = Properties.Settings.Default.DefaultConnection;


            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select AccountType from dbo.AccountInfo", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "type");
            comboBox1.DisplayMember = "AccountType";
            comboBox1.ValueMember = "AccountType";
            comboBox1.DataSource = ds.Tables["type"];
            comboBox1.SelectedIndex = -1;
            con.Close();

        }

      
        private void Update_info_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please select an account type");
                return;
            }
                string str = Properties.Settings.Default.DefaultConnection;
            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();

            SqlCommand cmd = new SqlCommand("Update dbo.Customer Set FirstName = @first, LastName = @last, City = @city, State = @state, " +
                "ZipCode = @zip, Telephone = @phone, Email = @email, Password = @password, CreditCard = @credit WHERE(CID = @user)", con);
            cmd.Parameters.AddWithValue("@user", Program.CustomerID.ToString());
            cmd.Parameters.AddWithValue("@first", dataGridView1.Rows[0].Cells[0].Value);
            cmd.Parameters.AddWithValue("@last", dataGridView1.Rows[0].Cells[1].Value);
            cmd.Parameters.AddWithValue("@city", dataGridView1.Rows[0].Cells[2].Value);
            cmd.Parameters.AddWithValue("@state", dataGridView1.Rows[0].Cells[3].Value);
            cmd.Parameters.AddWithValue("@zip", dataGridView1.Rows[0].Cells[4].Value);
            cmd.Parameters.AddWithValue("@phone", dataGridView1.Rows[0].Cells[5].Value);
            cmd.Parameters.AddWithValue("@email", dataGridView1.Rows[0].Cells[6].Value);
            cmd.Parameters.AddWithValue("@password", dataGridView1.Rows[0].Cells[7].Value);
            cmd.Parameters.AddWithValue("@credit", dataGridView1.Rows[0].Cells[8].Value);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            load_info();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                string str = Properties.Settings.Default.DefaultConnection;
                SqlConnection con = new SqlConnection
                {
                    ConnectionString = str
                };
                con.Open();

                SqlCommand cmd = new SqlCommand("Update dbo.Customer Set AccountType = @account where CID = @user", con);
                cmd.Parameters.AddWithValue("@user", Program.CustomerID.ToString());
                cmd.Parameters.AddWithValue("@account", selected);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                con.Close();
            }
            
        }
    }
}
