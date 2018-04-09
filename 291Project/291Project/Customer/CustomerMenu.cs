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
            comboBox1.SelectedIndex = 0;
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

        private void view_queue_Click(object sender, EventArgs e)
        {
            Customer.RemoveQueue queue = new Customer.RemoveQueue();
            queue.Show();
        }

        private void movies_Click(object sender, EventArgs e)
        {
            CustomerMovie movie = new CustomerMovie();
            movie.Show();
        }

        private void info_Click(object sender, EventArgs e)
        {
            Customer.InfoEdit info = new Customer.InfoEdit();
            info.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                switch (selected)
                {
                    case "Create an Order":
                        MessageBox.Show("Create an Order allows you to easily checkout a movie that you have been wanting to see.");
                        break;

                    case "Return an Order":
                        MessageBox.Show("Return an Order allows you to return one of your currently checked out movies.");
                        break;

                    case "Order History":
                        MessageBox.Show("Order History show you all your past orders.");
                        break;

                    case "Edit Info":
                        MessageBox.Show("Edit Info allows you to edit any of you personal information.");
                        break;

                    case "Movie Suggetions":
                        MessageBox.Show("Movie Suggestions shows you a list of movies you might like based on your preferences.");
                        break;

                    case "View Your Current Orders":
                        MessageBox.Show("View Your Current Orders shows you all orders that are currently active.");
                        break;

                    case "Make a Payment":
                        MessageBox.Show("Make a Payment allows you to easily make a payment for your account.");
                        break;

                    case "View Movies":
                        MessageBox.Show("View Movies shows a comprehensive list of all movies and allows you to add these movies you your queue.");
                        break;

                    case "View Queue":
                        MessageBox.Show("View Queue shows you all of the movies currently in your queue and allows you to delete unwanted movies.");
                        break;


                }
            }
        }
    }
}


