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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void CustomerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string str = Properties.Settings.Default.DefaultConnection;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = str
            };
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Customer(FirstName, LastName, City, State, " +
                "ZipCode, Telephone, Email, Password, AccountCreationDate, CreditCard, AccountType) " +
                "Values(@FirstName, @LastName, @City, @State, @ZipCode, @Telephone, @Email, @Password, @AccountCreationDate, " +
                "@CreditCard, @AccountType)", con);
            cmd.Parameters.AddWithValue("@FirstName", FirstNameTextbox.Text);
            cmd.Parameters.AddWithValue("@LastName", LastNameTextbox.Text);
            cmd.Parameters.AddWithValue("@City", CityTextbox.Text);
            cmd.Parameters.AddWithValue("@State", StateTextbox.Text);
            cmd.Parameters.AddWithValue("@ZipCode", ZipTextbox.Text);
            cmd.Parameters.AddWithValue("@Telephone", TelephoneTextbox.Text);
            cmd.Parameters.AddWithValue("@Email", EmailTextbox.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordTextbox.Text);
            cmd.Parameters.AddWithValue("@AccountCreationDate", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@CreditCard", CreditCardTextbox.Text);
            cmd.Parameters.AddWithValue("@AccountType", comboBox1.SelectedValue);

            cmd.ExecuteNonQuery();
            label13.Text = "Successfully Added " + FirstNameTextbox.Text + LastNameTextbox.Text;
            label13.Visible = true;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            this.accountInfoTableAdapter.Fill(this.dataSet1.AccountInfo);
        }
    }
}
