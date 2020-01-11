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
        string connectionString = @"Data Source=DESKTOP-QABCRCQ;Initial Catalog=MRDELIVERY;Integrated Security=True";

        public OrderNow()
        {
            InitializeComponent();
        }

        private void OrderNow_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string sqlquery = "select * from [dbo].[tbl_Shop] ";
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string sqlquery = "select * from [dbo].[tbl_Shop] where Name like '" + textBox1.Text + "%'";
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
                string sqlquery = "select * from [dbo].[tbl_Shop] where Tupos='" + comboBox1.Text.ToString() + "'";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlCon);
                SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlcomm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var item = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if ((int)item >100 && (int)item < 200) //Range 100++ tupos Souvlakia
                {
                    var newForm = new S1();
                    newForm.Show();
                }
                else if ((int)item > 200 && (int)item < 300) //Range 200++ tupos Crepes
                {
                    var newForm = new S2();
                    newForm.Show();
                }
                else if ((int)item > 200 && (int)item < 300) //Range 300++ tupos Burgers
                {
                    var newForm = new S3();
                    newForm.Show();
                }
                else //Range 400++ tupos Pizza
                {
                    var newForm = new S4();
                    newForm.Show();
                }

            }
        }
    }
}

