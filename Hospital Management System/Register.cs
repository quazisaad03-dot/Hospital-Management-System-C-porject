using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
            textBoxPass.PasswordChar = '*';

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string Insert_query = "insert into LoginDB values('" + textBoxUN.Text + "','" + textBoxPass.Text + "','" + comboBoxRoll.Text + "',0)";
            SqlCommand cmd = new SqlCommand(Insert_query, con);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Registration is successful");
                }
                else
                    MessageBox.Show("Registration is not successful");
            }
            else
                MessageBox.Show("Database connection is not valid!");
            con.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUN.Clear();
            textBoxPass.Clear();
            textBoxUN.Focus();
            checkBoxSP.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPass.PasswordChar = checkBoxSP.Checked ? '\0' : '*';

        }

        private void comboBoxRoll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
