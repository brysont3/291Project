using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project
{
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.Show();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.Show();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            Employee.ConfirmOrder order = new Employee.ConfirmOrder();
            order.Show();
        }

        private void MovieSuggestionButton_Click(object sender, EventArgs e)
        {
            Employee.MovieSuggestions movieSuggestions = new Employee.MovieSuggestions();
            movieSuggestions.Show();

        }

        private void mail_list_Click(object sender, EventArgs e)
        {
            MailingList list = new MailingList();
            list.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                switch (selected)
                {
                    case "New Customer":
                        MessageBox.Show("New Customer allows an employee to easily add a new customer to the system.");
                        break;

                    case "New Orders":
                        MessageBox.Show("New Orders allows an employee to confirm a customer request for a movie.");
                        break;

                    case "Movie Suggestions":
                        MessageBox.Show("Movie Sugesstions allows an employee to genrate a personalized movie list based on a specific customers recomendations.");
                        break;

                    case "Customer Mailing List":
                        MessageBox.Show("Customer Mailing List provides employees with a list of all relevant mailing information for all customers.");
                        break;

                }
            }
        }
    }
}
