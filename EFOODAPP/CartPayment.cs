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

namespace MrDelivery
{
    public partial class CartPayment : Form
    {
        string connectionString = @"Data Source=DESKTOP-ITOMRGU;Initial Catalog=MRDELIVERY;Integrated Security=True";
        public CartPayment()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MrDelivery();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new ShoppingCart();
            newForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var newForm = new CreditCard();
            newForm.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/us/home");
        }

        private void CartPayment_Load(object sender, EventArgs e)
        {

        }

        private void rbcash_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Pmethod", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@cash", lblcost.Text);
                sqlCmd.Parameters.AddWithValue("@card", 0);
                sqlCmd.Parameters.AddWithValue("@cardnum", "null");
                sqlCmd.Parameters.AddWithValue("@cardname", "null");
                sqlCmd.Parameters.AddWithValue("@cardcvv", "null");
                sqlCmd.Parameters.AddWithValue("@carddate", "");
                //sqlCmd.ExecuteNonQuery();
               
            }

        }
    }
}
