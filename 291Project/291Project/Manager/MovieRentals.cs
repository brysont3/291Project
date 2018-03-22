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
    public partial class MovieRentals : Form
    {
        public MovieRentals()
        {
            InitializeComponent();
        }

        private void MovieRentals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.dataSet1.Genre);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            /*Gets the movie name, genre, order/return dates and the employee that completed the transaction
            Sorts by the chosen ComboBox selection*/
            SqlCommand cmd = new SqlCommand("SELECT M.MovieName, G.Genre, (C.FirstName + ' ' + C.LastName) AS CustomerName, O.OrderDate, O.ReturnDate, (E.FirstName + ' ' + E.LastName) AS EmployeeName " +
                "FROM [Order] AS O, Movie AS M, Customer AS C, Employee AS E, " +
                "Genre AS G WHERE O.MovieID = M.MovieID AND O.CID = C.CID AND M.GID = G.GID " +
                "AND O.EID = E.EID Order BY CASE @ORDER " +
                "WHEN 'Customer Name' THEN C.FirstName " +
                "WHEN 'Customer Name' THEN C.LastName " +
                "WHEN 'Movie Type' THEN G.Genre " +
                "WHEN 'Movie Name' THEN M.MovieName " +
                "END", con);
            cmd.Parameters.AddWithValue("@Order", OrderComboBox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable OrderTable = new DataTable();
            da.Fill(OrderTable);
            MovieGridView.DataSource = OrderTable;
        }
    }
}
