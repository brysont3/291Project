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

            Int32 atOnce = -1;
            Int32 outCnt = -1;
            System.Data.SqlClient.SqlConnection oCnn = new System.Data.SqlClient.SqlConnection(connectionString: Properties.Settings.Default.DefaultConnection);
            oCnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.Customer.CID, dbo.AccountInfo.AtOnce, subOrder.OutCnt " +
                "FROM   dbo.Customer INNER JOIN dbo.AccountInfo ON dbo.Customer.AccountType = dbo.AccountInfo.AccountType LEFT OUTER JOIN " +
                 " (SELECT CID, COUNT(*) AS OutCnt FROM    dbo.[Order] WHERE(ReturnDate IS NULL) GROUP BY CID) AS subOrder " +
                 " ON dbo.Customer.CID = subOrder.CID WHERE(dbo.Customer.CID = " + Program.CustomerID.ToString() + ")", oCnn);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                atOnce = dr.GetInt32(1);
                    if (dr["OutCnt"] == DBNull.Value)
                        outCnt = 0;
                else
                    outCnt = dr.GetInt32(2);
            }
            oCnn.Close();
            //MessageBox.Show("atONCE" + atOnce.ToString() + " " + "OUTCNT" + outCnt.ToString());

            if(outCnt >= atOnce)
            {
                MessageBox.Show("Too Many Orders, please return movies before making another order");
                this.Close();
            }



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

    }
}
