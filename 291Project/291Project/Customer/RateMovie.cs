using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project.Customer
{
    public partial class RateMovie : Form
    {
        public RateMovie()
        {
            InitializeComponent();
        }

        private void RateMovie_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM [Movie]";

            System.Data.SqlClient.SqlDataAdapter oDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, Properties.Settings.Default.DefaultConnection);

            DataTable oDT = new DataTable();

            oDA.Fill(oDT);

            MessageBox.Show(oDT.Rows.Count.ToString());

            this.MovieComboBox.DataSource = oDT;
            this.MovieComboBox.DisplayMember = "MovieName";
            this.MovieComboBox.ValueMember = "MovieID";

            for (int i = 1; i <= 5; i++)
            {
                RateComboBox.Items.Add(i);
            }
        }

        private void RateMovieButton_Click(object sender, EventArgs e)
        {
            string strSQL = "INSERT INTO [Rate] VALUES (1, " + this.MovieComboBox.SelectedValue.ToString() + ", 5)";
            System.Data.SqlClient.SqlConnection oDA = new System.Data.SqlClient.SqlConnection(connectionString: Properties.Settings.Default.DefaultConnection);
            oDA.Open();
            try
            {
                System.Data.SqlClient.SqlCommand oCmd = new System.Data.SqlClient.SqlCommand(strSQL, oDA);

                Int32 cnt = oCmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Movie already rated");
                else
                    MessageBox.Show("SQL Error: " + ex.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            oDA.Close();

            this.Close();
        }
    }
}
