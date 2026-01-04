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
    public partial class ForgetPassword : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

        public ForgetPassword()
        {
            InitializeComponent();
            textBoxPass.PasswordChar = '*';

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUN.Clear();
            textBoxPass.Clear();
            textBoxCPass.Clear();
            comboBoxRole.Text = "";
            textBoxUN.Focus();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == textBoxCPass.Text)
            {
                string Update_query = "update LoginDB set Password='" + textBoxPass.Text + "' where UserName='" + textBoxUN.Text + "' and Role='" + comboBoxRole.Text + "'";

                SqlCommand cmd = new SqlCommand(Update_query, con);

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Update is successful");
                    }
                    else
                        MessageBox.Show("Update is not successful");
                }
                else
                    MessageBox.Show("Database connection is not valid!");

                con.Close();
            }
            else
            {
                MessageBox.Show("Password and Confirm Password do not match!");
            }
        }

        private void checkBoxSP_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPass.PasswordChar = checkBoxSP.Checked ? '\0' : '*';
            textBoxCPass.PasswordChar = checkBoxSP.Checked ? '\0' : '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
