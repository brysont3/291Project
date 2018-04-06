using System;
using System.Collections;
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

namespace _291Project.Customer
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.dataSet1.Payment);
            setMonths();
            setCost();
            setCreditCardNumber();
        }

        private void setMonths()
        {
            //Clears so it can be rebound on submit
            MonthComboBox.Items.Clear();
            MonthComboBox.ResetText();
            int currentMonth = DateTime.Now.Month;
            ArrayList months = new ArrayList();
            ArrayList monthsToAdd = new ArrayList();

            //Adds all the months before the current month
            for(int i = 1; i < 13; i++)
            {
                if (i < currentMonth)
                    months.Insert(i - 1, i);
            }

            //copies the months into a new array
            int monthsToAddIndex = 0;
            foreach (int i in months)
            {
                monthsToAdd.Insert(monthsToAddIndex, i);
                monthsToAddIndex++;
            }

            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            //Gets the months the user has already paid
            SqlCommand cmd = new SqlCommand("SELECT MONTH(P.Date) FROM Payment AS P WHERE P.Date IS NOT NULL AND CID = @CurrentUser AND " +
                "MONTH(Date) <= @Month" , con);
            cmd.Parameters.AddWithValue("@CurrentUser", Program.CustomerID.ToString());
            cmd.Parameters.AddWithValue("@Month", DateTime.Now.Month);

            //Removes the months the user has already paid for
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Console.WriteLine(dr.GetInt32(0));
                    foreach (int month in months)
                    {
                        if (month.Equals(dr.GetInt32(0)))
                        {
                            monthsToAdd.Remove(dr.GetInt32(0));
                        }
                    }
                }
            }

            //Adds the months to the combobox

            foreach (int month in monthsToAdd)
            {
                MonthComboBox.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month));
            }
            con.Close();
        
        }

        private void setCost()
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            //Gets the months the user has already paid
            SqlCommand cmd = new SqlCommand("SELECT Cost FROM AccountInfo AS A, Customer AS C WHERE C.AccountType = A.AccountType " +
                "AND C.CID = @User", con);
            cmd.Parameters.AddWithValue("@User", Program.CustomerID.ToString());

            //Removes the months the user has already paid for
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    AmountTextBox.Text = dr.GetDouble(0).ToString();
                }
            }
            con.Close();
        }

        private void setCreditCardNumber()
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            //Gets the months the user has already paid
            SqlCommand cmd = new SqlCommand("SELECT CreditCard FROM Customer AS C " +
                "WHERE C.CID = @User", con);
            cmd.Parameters.AddWithValue("@User", Program.CustomerID.ToString());

            //Removes the months the user has already paid for
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    CreditCardNumberTextbox.Text = dr.GetString(0);
                }
            }
            con.Close();
        }

        private int getAccountType(string user)
        {

            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            //Gets the months the user has already paid
            SqlCommand cmd = new SqlCommand("SELECT AccountType from Customer WHERE CID = @User", con);
            cmd.Parameters.AddWithValue("@User", Program.CustomerID.ToString());

            //Removes the months the user has already paid for
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            con.Close();
            return 0;
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            //Gets the months the user has already paid
            SqlCommand cmd = new SqlCommand("INSERT Into Payment VALUES(@User, @AccountType, @Date, 1)", con);
            cmd.Parameters.AddWithValue("@User", Program.CustomerID.ToString());
            cmd.Parameters.AddWithValue("@AccountType", getAccountType(Program.CustomerID.ToString()));
            cmd.Parameters.AddWithValue("@Date", new DateTime(DateTime.Now.Year, DateTime.ParseExact(MonthComboBox.Text, "MMMM", CultureInfo.CurrentCulture).Month, DateTime.Now.Day));

            cmd.ExecuteNonQuery();
            con.Close();
            ConfirmationLabel.Text = "Successfully Paid: " + MonthComboBox.Text;
            ConfirmationLabel.Visible = true;
            setMonths();
        }
    }
}
