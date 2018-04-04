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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (!String.Equals(PasswordTextbox.Text, ConfirmTextbox.Text))
            {
                label13.Text = "Passwords Must Match";
                label13.Visible = true;
            }
            else
            {
                string str = Properties.Settings.Default.DefaultConnection;

                SqlConnection con = new SqlConnection
                {
                    ConnectionString = str
                };
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Employee(SSN, FirstName, LastName, City, State, " +
                    "ZipCode, Email, Password, Telephone, StartDate, HourlyRate, Type) " +
                    "Values(@SSN, @FirstName, @LastName, @City, @State, @ZipCode, @Email, @Password, @Telephone, @AccountCreationDate, " +
                    "@HourlyRate, @AccountType)", con);
                cmd.Parameters.AddWithValue("@SSN", SSNTextbox.Text);
                cmd.Parameters.AddWithValue("@FirstName", FirstNameTextbox.Text);
                cmd.Parameters.AddWithValue("@LastName", LastNameTextbox.Text);
                cmd.Parameters.AddWithValue("@City", CityTextbox.Text);
                cmd.Parameters.AddWithValue("@State", StateTextbox.Text);
                cmd.Parameters.AddWithValue("@ZipCode", ZipTextbox.Text);
                cmd.Parameters.AddWithValue("@Email", EmailTextbox.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTextbox.Text);
                cmd.Parameters.AddWithValue("@Telephone", TelephoneTextbox.Text);
                cmd.Parameters.AddWithValue("@AccountCreationDate", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@HourlyRate", HourlyWageTextBox.Text);
                cmd.Parameters.AddWithValue("@AccountType", comboBox1.Text);

                cmd.ExecuteNonQuery();
                label13.Text = "Successfully Added " + FirstNameTextbox.Text + " " + LastNameTextbox.Text;
                label13.Visible = true;

                //Clear the textboxes
                SSNTextbox.Clear();
                FirstNameTextbox.Clear();
                FirstNameTextbox.Clear();
                LastNameTextbox.Clear();
                CityTextbox.Clear();
                StateTextbox.Clear();
                ZipTextbox.Clear();
                EmailTextbox.Clear();
                PasswordTextbox.Clear();
                ConfirmTextbox.Clear();
                TelephoneTextbox.Clear();
                HourlyWageTextBox.Clear();
                comboBox1.SelectedIndex = -1;
            }
        }
    }
}
