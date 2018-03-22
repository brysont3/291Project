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
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void MovieButton_Click(object sender, EventArgs e)
        {
            MovieEditPage movieEditPage = new MovieEditPage();
            movieEditPage.Show();
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
    }
}
