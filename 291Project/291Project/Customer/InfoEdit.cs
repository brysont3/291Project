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

        private void InfoEdit_Load(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT CID, FirstName, LastName, City, State, ZipCode, Telephone, Email, Password, " + 
                "AccountCreationDate, CreditCard, Rating, AccountType FROM dbo.Customer WHERE(CID = @user)", con);
            cmd.Parameters.AddWithValue("@user", Program.CustomerID.ToString());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

        }

      
        private void Update_info_Click_1(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();

            SqlCommand cmd = new SqlCommand("Update dbo.Customer Set FirstName = @first, LastName = @last, City = @city, State = @state, " +
                "ZipCode = @zip, Telephone = @phone, Email = @email, Password = @password, CreditCard = @credit, AccountType = @account WHERE(CID = @user)", con);
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
            cmd.Parameters.AddWithValue("@account", dataGridView1.Rows[0].Cells[9].Value);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
        }
    }
}
