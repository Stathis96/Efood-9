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
using System.Configuration;

namespace MrDelivery
{
    public partial class OrderNow : Form
    {
        string connectionString = @"Data Source=STATHIS-PC\SQLEXPRESS;Initial Catalog = tempdb; Integrated Security = True";

        public OrderNow()
        {
            InitializeComponent();
        }

        private void OrderNow_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string sqlquery = "select * from [dbo].[Table] ";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlCon);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
                comboBox1.DisplayMember = "tupos";
                comboBox1.DataSource = dt;
                sqlcomm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            var newForm = new S1();
            newForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var newForm = new S2();
            newForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var newForm = new S3();
            newForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var newForm = new S4();
            newForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string sqlquery = "select * from [dbo].[Table] where name like '" + textBox1.Text + "%'";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlCon);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcomm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string sqlquery = "select * from [dbo].[Table] where tupos='" +comboBox1.Text.ToString()+"'";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlCon);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcomm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

