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
    public partial class ManageUsers : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUSVIVOBOOK\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");

        public ManageUsers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemActivities sa = new SystemActivities();
            sa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            PharmacyStock ps = new PharmacyStock();
            ps.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login al = new Login();
            al.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

           
            string query = "SELECT ID, UserName, Role, Status FROM LoginDB";

            using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();

                sda.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void LoadUserData()
        {
            string query = "SELECT ID, UserName, Role, Status FROM LoginDB";

            using (SqlDataAdapter da = new SqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            string id = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells["UserName"].Value.ToString();

            DialogResult dialog = MessageBox.Show("Delete " + name + "?", "Confirm", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM LoginDB WHERE ID = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                button8_Click(sender, e); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT ID, UserName, Role, Status FROM LoginDB WHERE UserName LIKE '" + textBoxSearch.Text + "%'";

            using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string userId = row.Cells["ID"].Value.ToString();
                string newStatus = row.Cells["Status"].Value.ToString();

                string query = "UPDATE LoginDB SET Status = @stat WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@stat", newStatus);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }

            con.Close();
            MessageBox.Show("All status updates saved successfully!");

            button8_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
