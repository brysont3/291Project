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

namespace _291Project.Customer
{
    public partial class InfoEdit : Form
    {
        public InfoEdit()
        {
            InitializeComponent();
        }

        private void InfoEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.dataSet1.Payment);
            // TODO: This line of code loads data into the 'dataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.FillCustomer(this.dataSet1.Customer);

        }

      
        private void Update_info_Click_1(object sender, EventArgs e)
        {
            this.customerTableAdapter.Update(this.dataSet1.Customer);
        }
    }
}
