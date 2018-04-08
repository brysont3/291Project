using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project.Employee
{
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            createOrder.Show();
        }

        private void MovieSuggestionButton_Click(object sender, EventArgs e)
        {
            Customer.CustomerMovieSuggestions customerMovieSuggestions = new Customer.CustomerMovieSuggestions();
            customerMovieSuggestions.Show();
        }

        private void ReturnOrder_Click(object sender, EventArgs e)
        {
            Customer.ReturnMovie returnMovie = new Customer.ReturnMovie();
            returnMovie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer.CurrentOrders currentOrders = new Customer.CurrentOrders();
            currentOrders.Show();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            Customer.Payment payment = new Customer.Payment();
            payment.Show();
        }

        private void OrderHistoryButton_Click(object sender, EventArgs e)
        {
            Customer.OrderHistory orderHistory = new Customer.OrderHistory();
            orderHistory.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer.RateMovie rateMovie = new Customer.RateMovie();
            rateMovie.Show();
        }
    }
}
