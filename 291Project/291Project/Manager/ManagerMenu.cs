using _291Project.Manager;
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
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
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

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeEditPage employeeEditPage = new EmployeeEditPage();
            employeeEditPage.Show();
        }

        private void SalesReportButton_Click(object sender, EventArgs e)
        {
            SalesReport salesReport = new SalesReport();
            salesReport.Show();
        }

        private void MovieRentalButton_Click(object sender, EventArgs e)
        {
            MovieRentals movieRentals = new MovieRentals();
            movieRentals.Show();
        }

        private void MostActiveCustomersButton_Click(object sender, EventArgs e)
        {
            MostActiveCustomers mostActiveCustomers = new MostActiveCustomers();
            mostActiveCustomers.Show();
        }

        private void MostActiveEmployeesButton_Click(object sender, EventArgs e)
        {
            MostActiveEmployees mostActiveEmployees = new MostActiveEmployees();
            mostActiveEmployees.Show();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void MovieButton_Click(object sender, EventArgs e)
        {
            MovieList movieList = new MovieList();
            movieList.Show();
        }

        private void EditMovieButton_Click(object sender, EventArgs e)
        {
            MovieEditPage movieEditPage = new MovieEditPage();
            movieEditPage.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                switch (selected)
                {
                    case "Movies":
                        MessageBox.Show("Movies shows a list of all movies currently in the system and gives actor information about them.");
                        break;

                    case "Employees":
                        MessageBox.Show("Employee gives managers all information about all emploees.");
                        break;

                    case "Sales Report":
                        MessageBox.Show("Sales Report gives information about a sales report for a given month and year.");
                        break;

                    case "Movie Rentals":
                        MessageBox.Show("Movie Rentals shows information about all movie rentals that can be sorted by specified years.");
                        break;

                    case "Edit Movies":
                        MessageBox.Show("Edit Movies allows managers to delete or edit information about any moviein the system.");
                        break;

                    case "Most Active Customers":
                        MessageBox.Show("Most Active Customers show a list of customers that have rented the most movies.");
                        break;

                    case "Most Active Employees":
                        MessageBox.Show("Most Active Employees shows a list of employyes who have rented ou the most movies.");
                        break;

                    case "New Customer":
                        MessageBox.Show("New Customer allows a manager to easily add a new customer to the system.");
                        break;

                    case "New Employee":
                        MessageBox.Show("New Customer allows a manager to easily add a new employee to the system.");
                        break;


                }
            }
        }
    }
}
