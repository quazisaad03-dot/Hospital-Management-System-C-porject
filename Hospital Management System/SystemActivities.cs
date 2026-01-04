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
    public partial class SystemActivities : Form
    {
        public SystemActivities()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUsers mu = new ManageUsers();
            mu.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PharmacyStock ps = new PharmacyStock();
            ps.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageUsers mu = new ManageUsers();
            mu.Show();
            this.Hide();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
