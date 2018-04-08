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
    public partial class MailingList : Form
    {
        public MailingList()
        {
            InitializeComponent();
        }

        private void MailingList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.AccountInfo' table. You can move, or remove it, as needed.
            this.accountInfoTableAdapter.Fill(this.dataSet1.AccountInfo);
            // TODO: This line of code loads data into the 'dataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet1.Customer);

        }
    }
}
