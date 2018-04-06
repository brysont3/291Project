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
    public partial class CustomerEditPage : Form
    {
        public CustomerEditPage()
        {
            InitializeComponent();
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Update(this.dataSet1.Customer);
        }

        private void CustomerEditPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet1.Customer);

        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            this.customerTableAdapter.Update(this.dataSet1.Customer);

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Update(this.dataSet1.Customer);
        }
    }
}
