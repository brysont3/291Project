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
    public partial class EmployeeEditPage : Form
    {
        public EmployeeEditPage()
        {
            InitializeComponent();
        }

        private void EmployeeEditPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Update(this.dataSet1.Employee); 
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            this.employeeTableAdapter.Update(this.dataSet1.Employee);
        }
    }
}
