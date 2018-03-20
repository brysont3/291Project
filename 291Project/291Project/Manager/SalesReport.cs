using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project.Manager
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            MonthComboBox.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'dataSet1.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.dataSet1.Payment);

            //Load all the years that are present in Payments into the YearComboBox
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT DISTINCT DATEPART(Year, Date) as Years FROM Payment WHERE DATEPART(Year, Date) IS NOT NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Year");
            YearComboBox.DisplayMember = "Years";
            YearComboBox.ValueMember = "Years";
            YearComboBox.DataSource = ds.Tables["Year"];
            

        }

        //Updates gridView1 when the submit button is clicked
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(NumAccounts.AccountCounts*A.Cost) as Income FROM dbo.AccountInfo AS A, " +
                "(SELECT P.AccountType, COUNT(P.AccountType) AS AccountCounts FROM dbo.Payment AS P WHERE DATEPART(MONTH, P.Date) = @Month " +
                " AND DATEPART(YEAR, P.Date) = @Year " +
                "GROUP BY P.AccountType) AS NumAccounts WHERE A.AccountType = NumAccounts.AccountType", con);
            cmd.Parameters.AddWithValue("@Month", DateTime.ParseExact(MonthComboBox.Text, "MMMM", CultureInfo.CurrentCulture).Month);
            cmd.Parameters.AddWithValue("@Year", Int32.Parse(YearComboBox.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable IncomeTable = new DataTable();
            da.Fill(IncomeTable);
            dataGridView1.DataSource = IncomeTable;
        }
    }
}
