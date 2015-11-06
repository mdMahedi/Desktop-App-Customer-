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
    public partial class InsertIntoCustomers : Form
    {
        public InsertIntoCustomers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nam = textBox1.Text;
            string adr = textBox2.Text;
            string mal = textBox3.Text;
            string phn = textBox4.Text;

            DataAccess dac = new DataAccess();
            if (dac.InsertIntoCustomers(nam, adr, mal, phn))
                label5.Text = "Customer Registration Succesfully Completed.";
            else
                label5.Text = "Registration Failed !!!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectCustomers f1 = new SelectCustomers();
            f1.Show();
            this.Hide();
        }
    }
}
