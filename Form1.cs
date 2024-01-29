using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudents2DataSet.tbCustomers' table. You can move, or remove it, as needed.
            this.tbCustomersTableAdapter.Fill(this.dbStudents2DataSet.tbCustomers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCustomersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbCustomersBindingSource.EndEdit();
            tbCustomersTableAdapter.Update(dbStudents2DataSet.tbCustomers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbCustomersBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbCustomersBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbCustomersBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbCustomersBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbCustomersBindingSource.MoveNext();
        }
    }
}
