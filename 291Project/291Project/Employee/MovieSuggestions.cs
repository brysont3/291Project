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

namespace _291Project.Employee
{
    public partial class MovieSuggestions : Form
    {
        public MovieSuggestions()
        {
            InitializeComponent();
        }

        private void MovieSuggestions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet1.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT M.MovieName, G.Genre FROM Movie AS M, Genre AS G WHERE M.GID = G.GID AND G.GID IN " +
                "(SELECT GenreCount.GID FROM(SELECT G.GID, COUNT(G.Genre) AS NumGenre FROM[ORDER] AS O, Movie AS M, " +
                "Genre AS G WHERE O.MovieID = M.MovieID AND M.GID = G.GID AND O.CID = @CID GROUP BY G.GID) AS GenreCount GROUP BY GenreCount.GID, GenreCount.NumGenre " +
                "HAVING GenreCount.NumGenre = MAX(GenreCount.NumGenre)) AND M.MovieID NOT IN(SELECT O.MovieID FROM[Order] AS O WHERE O.CID = @CID) " +
                "AND M.MovieID IN(SELECT M.MovieID FROM Movie AS M EXCEPT SELECT R.MovieID FROM Rate AS R " +
                "GROUP BY R.MovieID HAVING AVG(R.Rating) < 3)", con);
            cmd.Parameters.AddWithValue("@CID", CustomerTextBox.Text);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            MovieSuggestionGridView.DataSource = dt;
            con.Close();
        }

        //Right now just opens create order page, does not fill with selected movie
        private void MovieSuggestionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                CreateOrder createOrder = new CreateOrder();
                createOrder.Show();
            }
        }
    }
}
