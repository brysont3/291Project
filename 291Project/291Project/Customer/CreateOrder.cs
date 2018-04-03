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

namespace _291Project.Employee
{
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.dataSet1.Movie);
            // Add New order record..
            this.orderBindingSource.AddNew();

            this.orderDateDateTimePicker.Value = DateTime.Today;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cIDTextBox.Text = Program.CustomerID.ToString();
            this.Validate();
            this.orderBindingSource.EndEdit();


            this.tableAdapterManager.UpdateAll(this.dataSet1);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void movieIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void movieIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void orderIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
