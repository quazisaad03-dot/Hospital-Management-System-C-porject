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
    public partial class Login : Form

    {
        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
            textBoxPass.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resuslt = MessageBox.Show("Do you Really want to close??", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resuslt == DialogResult.Yes)
                this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUN.Clear();
            textBoxPass.Clear();
            comboBoxRole.Text = "";
            textBoxUN.Focus();

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            
            string select_query = "select * from LoginDB where [UserName]='" + textBoxUN.Text + "' and Password='" + textBoxPass.Text + "' and Role='" + comboBoxRole.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(select_query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count ==1)
            {
                string role = dt.Rows[0][3].ToString();

                if (role == "Admin")
                {
                    new ManageUsers().Show();
                    this.Hide();
                }
                else if (role == "Doctor")
                {
                    new Doctor().Show();
                    this.Hide();
                }
                else if (role == "Pharmacist")
                {
                    new ManageUsers().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPass.PasswordChar = checkBoxSP.Checked ? '\0' : '*';
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
