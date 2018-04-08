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
    public partial class CustomerMovie : Form
    {
        public CustomerMovie()
        {
            InitializeComponent();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void CustomerMovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Actor' table. You can move, or remove it, as needed.
            this.actorTableAdapter.Fill(this.dataSet1.Actor);
            // TODO: This line of code loads data into the 'dataSet1.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.dataSet1.Genre);
            // TODO: This line of code loads data into the 'dataSet1.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.dataSet1.Genre);
            // TODO: This line of code loads data into the 'dataSet1.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
            this.select_genre.SelectedIndex = -1;
        }


        private void movieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string str = Properties.Settings.Default.DefaultConnection;

                SqlConnection con = new SqlConnection
                {
                    ConnectionString = str
                };
                con.Open();
                SqlCommand cmd = new SqlCommand("DECLARE @num int " +
                        "SET @num = (select max(QueueNumber) as max " +
                        "from RentQueue where CID = @user) + 1 " +
                        "insert RentQueue(CID, MovieID, QueueNumber) " +
                        "values(@user, @MovieID, @num)", con);
                cmd.Parameters.AddWithValue("@user", Program.CustomerID.ToString());
                cmd.Parameters.AddWithValue("@MovieID", movieDataGridView.Rows[e.RowIndex].Cells[0].Value);

                try
                {
                    added.Text = movieDataGridView.Rows[e.RowIndex].Cells[1].Value + " added to the queue.";
                    DataTable dt = new DataTable();
                    SqlCommand cmd2 = new SqlCommand("select MovieID, MovieName, NumCopies from dbo.Movie", con);
                    dt.Load(cmd.ExecuteReader());
                    dt.Load(cmd2.ExecuteReader());
                    movieDataGridView.DataSource = dt;
                    added.Visible = true;
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    added.Text = movieDataGridView.Rows[e.RowIndex].Cells[1].Value + " already in the queue!";
                    added.Visible = true;
                    con.Close();
                }
            }
        }


        private void filter_Click(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();

            SqlCommand cmd = new SqlCommand("select MovieID, MovieName, NumCopies " +
                "from Movie as M, Genre as G where M.GID = G.GID and Genre like @genre and " +
                "MovieName like @movie_contains and MovieID in (select A.ActorID from Actor as A, " +
                "MoviesIn as MI where MI.ActorID = A.ActorID and (A.FirstName like @actor_contains or A.LastName like @actor_contains))", con);
            if (!string.IsNullOrEmpty(select_genre.Text))
            {
                cmd.Parameters.AddWithValue("@genre", "%" + select_genre.Text + "%");
            }
            else
            {
                cmd.Parameters.AddWithValue("@genre", "%");
            }

            if (!string.IsNullOrEmpty(actor_contains.Text))
            {
                cmd.Parameters.AddWithValue("@actor_contains", "%" + actor_contains.Text + "%");
            }
            else
            {
                cmd.Parameters.AddWithValue("@actor_contains", "%");
            }

            if (!string.IsNullOrEmpty(movie_contains.Text)) {
                cmd.Parameters.AddWithValue("@movie_contains", "%" + movie_contains.Text + "%");
            }
            else
            {
                cmd.Parameters.AddWithValue("@movie_contains", "%");
            }
 
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            movieDataGridView.DataSource = table;
        }


    }
}
