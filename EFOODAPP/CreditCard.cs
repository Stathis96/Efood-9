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
    public partial class CreditCard : Form
    {
        string connectionString = @"Data Source=DESKTOP-ITOMRGU;Initial Catalog=MRDELIVERY;Integrated Security=True";
        public CreditCard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Pmethod", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@cash", "0");
                sqlCmd.Parameters.AddWithValue("@card", 1);
                sqlCmd.Parameters.AddWithValue("@cardnum", txtnumber.Text);
                sqlCmd.Parameters.AddWithValue("@cardname", txtonoma.Text);
                sqlCmd.Parameters.AddWithValue("@cardcvv", txtccv.Text);
                sqlCmd.Parameters.AddWithValue("@carddate", txtdate.Text);
                //sqlCmd.ExecuteNonQuery();

            }
            this.Hide();
            CartPayment newForm = new CartPayment(null);
            newForm.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CreditCard_Load(object sender, EventArgs e)
        {

        }
    }
}
