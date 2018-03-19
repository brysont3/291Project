using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project.Manager
{
    public partial class MovieEditPage : Form
    {
        public MovieEditPage()
        {
            InitializeComponent();
        }

        private void MovieEditPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.dataSet11.Movie);

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.Update(this.dataSet11.Movie);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            this.movieTableAdapter.Update(this.dataSet11.Movie);
        }
    }
}
