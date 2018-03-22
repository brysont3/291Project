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

namespace _291Project.Manager
{
    public partial class MostActiveCustomers : Form
    {
        public MostActiveCustomers()
        {
            InitializeComponent();

            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            /*Gets the number of movies each person has rented and sorts from most to least rented*/
            SqlCommand cmd = new SqlCommand("SELECT(C.FirstName + ' ' + C.LastName) AS Name, COUNT(O.CID) " +
                "AS NumMoviesRented FROM[ORDER] AS O, dbo.Customer AS C WHERE O.CID = C.CID " +
                "GROUP BY (C.FirstName +' ' + C.LastName) ORDER BY NumMoviesRented DESC", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable OrderTable = new DataTable();
            da.Fill(OrderTable);
            CustomerGridView.DataSource = OrderTable;
            con.Close();


        }
    }
}
