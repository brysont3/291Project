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
    public partial class OrderHistory : Form
    {
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string strSQL = "SELECT o.OrderID, m.MovieName, o.OrderDate, o.ReturnDate FROM dbo.[Order] as o LEFT JOIN Movie as m ON o.MovieID = m.MovieID " +
"WHERE EID IS NOT NULL AND CID = " + Program.CustomerID.ToString();

            SqlDataAdapter oDA = new SqlDataAdapter(strSQL, Properties.Settings.Default.DefaultConnection);
            oDA.Fill(dt);
            OrderDataGridView.DataSource = dt;
        }
    }
}
