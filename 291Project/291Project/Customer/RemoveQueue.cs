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
    public partial class RemoveQueue : Form
    {
        public RemoveQueue()
        {
            InitializeComponent();
        }


        private void load_data()
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT M.MovieID, M.MovieName, RQ.QueueNumber FROM dbo.Movie as M, dbo.RentQueue as RQ WHERE RQ.CID = @user and M.MovieID = RQ.MovieID", con);
            cmd.Parameters.AddWithValue("@user", Program.CustomerID.ToString());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void RemoveQueue_Load(object sender, EventArgs e)
        {
            load_data();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                SqlCommand cmd = new SqlCommand("Delete from dbo.RentQueue where CID = @user and MovieID = @movie", con);
                cmd.Parameters.AddWithValue("@user", Program.CustomerID.ToString());
                cmd.Parameters.AddWithValue("@movie", dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                load_data();
            }
        }
    }
}
