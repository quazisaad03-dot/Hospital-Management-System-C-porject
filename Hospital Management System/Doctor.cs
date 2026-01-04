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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appoinments a = new Appoinments();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prescription p = new Prescription();
            p.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login al = new Login();
            al.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
