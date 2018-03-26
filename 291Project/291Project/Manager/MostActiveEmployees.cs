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
    public partial class MostActiveEmployees : Form
    {
        public MostActiveEmployees()
        {
            InitializeComponent();

            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            /*Gets the number of movies each Employee has rented out and sorts from most to least rented, Joining
             With all the employees to see if any employees have rented out 0 movies*/
            SqlCommand cmd = new SqlCommand("SELECT NAME, OP.NumMovies FROM ( " +
                "(SELECT(E.FirstName + ' ' + E.LastName) AS Name, E.EID FROM dbo.Employee AS E) AS EMP " +
                "LEFT JOIN " +
                "(SELECT COUNT(O.EID) AS NumMovies, O.EID FROM dbo.[Order] AS O GROUP BY O.EID) AS OP " +
                "ON OP.Eid = EMP.EID) " +
                "ORDER BY OP.NumMovies DESC", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable OrderTable = new DataTable();
            da.Fill(OrderTable);
            EmployeeGridView.DataSource = OrderTable;
            con.Close();
        }
    }
}
