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
    public partial class ConfirmOrder : Form
    {
        public ConfirmOrder()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ConfirmOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.dataSet1.Order);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eIDTextBox.Text = Program.EmployeeID.ToString();
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }
    }
}
