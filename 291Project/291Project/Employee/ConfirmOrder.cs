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

        private void button2_Click(object sender, EventArgs e)
        {
            this.eIDTextBox.Text = Program.EmployeeID.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.orderTableAdapter.Update(this.dataSet1.Order);
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
                try
                {
                    string strung;
                    string strcung;
                    Boolean SomethingChanged = false;
                    listBox1.Items.Add("Try to check what changed");

                    foreach (DataRow myRow in this.dataSet1.Tables["Order"].Rows)
                        switch (myRow.RowState)
                        {
                            case DataRowState.Added:
                                listBox1.Items.Add("This record was ADDED");
                                listBox1.Items.Add("orderID=" + myRow["OrderID"] +
                                     " employeeID=" + myRow["EID"]);
                                SomethingChanged = true;
                                break;

                            case DataRowState.Deleted:
                                listBox1.Items.Add("This record was DELETED");
                                listBox1.Items.Add("orderID=" + myRow["OrderID", DataRowVersion.Original] +
                                     " employeeID=" + myRow["EID", DataRowVersion.Original]);
                                SomethingChanged = true;
                                break;

                            case DataRowState.Modified:
                                listBox1.Items.Add("This record was MODIFIED");
                                listBox1.Items.Add("orderID=" + myRow["OrderID", DataRowVersion.Original] + " ||" + " orderIDNEW=" + myRow["OrderID"]);
                                listBox1.Items.Add("employeeID=" + myRow["EID", DataRowVersion.Original] + " ||" + " employeeIDNEW=" + myRow["EID"]);
                                listBox1.Items.Add("movieID=" + myRow["MovieID", DataRowVersion.Original] + " ||" + " movieIDNEW=" + myRow["MovieID"]);
                                listBox1.Items.Add("rDate=" + myRow["ReturnDate", DataRowVersion.Original] + " ||" + " rDateNEW=" + myRow["ReturnDate"]);
                                listBox1.Items.Add("oDate=" + myRow["OrderDate", DataRowVersion.Original] + " ||" + " oDateIDNEW=" + myRow["OrderDate"]);
                                SomethingChanged = true;

                                for (Int32 col = 0;
                                    col < this.dataSet1.Tables["Order"].Columns.Count;
                                    col++)
                                {
                                    strung = myRow[col, DataRowVersion.Original] + "";
                                    strcung = myRow[col, DataRowVersion.Current] + "";
                                    if (strung != strcung)
                                        listBox1.Items.Add(this.dataSet1.Tables["Order"].Columns[col].ColumnName +
                                            "  From ->" + strung + "->" + strcung);
                                }
                                break;
                        }// end switch

                    if (!SomethingChanged)
                        listBox1.Items.Add("Nothing has changed");
                }//end foreach

                catch (Exception ex)
                {
                    listBox1.Items.Add("Error in what Has Changed method");
                    listBox1.Items.Add("Error:  " + ex.Message);
                }
        }
    }
}
