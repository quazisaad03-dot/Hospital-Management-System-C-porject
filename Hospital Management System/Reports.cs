using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageUsers mu = new ManageUsers();
            mu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUsers mu = new ManageUsers();
            mu.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemActivities sa = new SystemActivities();
            sa.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PharmacyStock ps = new PharmacyStock();
            ps.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
