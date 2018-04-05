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
    public partial class CurrentOrders : Form
    {
        public CurrentOrders()
        {
            InitializeComponent();
        }

        private void CurrentOrders_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string strSQL = "SELECT m.MovieName, o.OrderID, o.OrderDate FROM dbo.[Order] as o LEFT JOIN Movie as m ON o.MovieID = m.MovieID " +
"WHERE ReturnDate IS NULL AND EID IS NOT NULL AND CID = " + Program.CustomerID.ToString();

            SqlDataAdapter oDA = new SqlDataAdapter(strSQL, Properties.Settings.Default.DefaultConnection);
            oDA.Fill(dt);
            OrderDataGridView.DataSource = dt;
        }
    }
}
