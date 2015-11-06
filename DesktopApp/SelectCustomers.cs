using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class SelectCustomers : Form
    {
        public SelectCustomers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess dac = new DataAccess();
            DataTable dt = dac.SelectFromCustomers();
            dataGridView1.DataSource = dt;
            dataGridView1.Select();
        }

        private void SelectCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deskTopAppDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.deskTopAppDBDataSet.Customers);

        }

        private void AddCustomer(object sender, EventArgs e)
        {
            InsertIntoCustomers f2 = new InsertIntoCustomers();
            f2.Show();
            this.Hide();
        }

        private void searchCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertIntoCustomers f2 = new InsertIntoCustomers();
            f2.Show();
            this.Hide();
        }
    }
}
