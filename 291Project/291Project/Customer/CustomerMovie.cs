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
            // TODO: This line of code loads data into the 'dataSet1.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.dataSet1.Genre);
            // TODO: This line of code loads data into the 'dataSet1.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.dataSet1.Genre);
            // TODO: This line of code loads data into the 'dataSet1.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.dataSet1.Movie);

        }

        private void movieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            movieDataGridView.Columns[2].ReadOnly = false;      
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
                SqlCommand cmd = new SqlCommand("select * from Movie", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    int i;
                    for (i = 0; i <= e.RowIndex; i++)
                    {
                        dr.Read();
                    }
                    // Command to add movie to RentQueue table when button is pushed
                    SqlCommand cmd2 = new SqlCommand("DECLARE @num int " +
                        "SET @num = (select max(QueueNumber) as max " +
                        "from RentQueue where CID = 2) + 1 " +
                        "insert RentQueue(CID, MovieID, QueueNumber) " +
                        "values(@user, @MovieID, @num)", con);
                    cmd2.Parameters.AddWithValue("@user", Program.CustomerID.ToString());
                    cmd2.Parameters.AddWithValue("@MovieID", dr["MovieID"]);
                    added.Text = dr["MovieName"] + " added to the queue.";
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    added.Visible = true;
                }
            }
        }
    }
}
