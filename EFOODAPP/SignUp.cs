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
    public partial class SignUp : Form
    {
        string connectionString = @"Data Source=DESKTOP-QABCRCQ;Initial Catalog=MRDELIVERY;Integrated Security=True";
        public SignUp()
        {
            InitializeComponent();
        }



        private void submit_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == "" || passwordtxt.Text == "")
            {
                MessageBox.Show("Please Fill Mandatory Fields");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd12", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", usernametxt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", passwordtxt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone", numtxt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", emailtxt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Firstname", firstnametxt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Lastname", lastnametxt.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", addresstxt.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");
                    Clear();


                }
            }
        }
            void Clear()
            {
                usernametxt.Text = passwordtxt.Text = numtxt.Text = emailtxt.Text = firstnametxt.Text = lastnametxt.Text = addresstxt.Text = "";
            }

            private void SignUp_Load(object sender, EventArgs e)
            {

            }

            private void numtxt_KeyPress(object sender, KeyPressEventArgs e)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

            private void firstnametxt_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            private void lastnametxt_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Hide();
                var newForm = new Login();
                newForm.Show();
            }
        }
    }

