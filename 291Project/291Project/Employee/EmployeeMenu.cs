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
    }
}
