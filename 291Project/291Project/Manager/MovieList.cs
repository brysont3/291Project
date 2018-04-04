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
    public partial class MovieList : Form
    {
        public MovieList()
        {
            InitializeComponent();
        }

        private void MovieList_Load(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT M.MovieName, G.Genre, M.DistributionFee, M.NumCopies FROM " +
                "Movie AS M INNER JOIN Genre AS G ON M.GID = G.GID", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            MovieDateGridView.DataSource = dt;
            con.Close();
        }

        private void MovieDateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int row = MovieDateGridView.CurrentCell.RowIndex;
                string str = Properties.Settings.Default.DefaultConnection;

                SqlConnection con = new SqlConnection
                {
                    ConnectionString = str
                };
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT A.FirstName, A.LastName FROM dbo.MoviesIn AS MI, dbo.Movie AS M, dbo.Actor AS A " +
                    "WHERE M.MovieID = MI.MovieID AND MI.ActorID = A.ActorID AND M.MovieName = @MovieName", con);
                cmd.Parameters.AddWithValue("@MovieName", MovieDateGridView.Rows[e.RowIndex].Cells[1].Value);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                ActorGridView.DataSource = dt;
                con.Close();
            }
          
        }
    }
}
