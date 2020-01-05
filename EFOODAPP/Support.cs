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
    public partial class Support : Form
    {
        string connectionString= @"Data Source=DESKTOP-ITOMRGU;Initial Catalog=MRDELIVERY;Integrated Security=True";
        public Support()
        {
            InitializeComponent();
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        private void Support_Load(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            
                if (txtName.Text == "" || txtEpwn.Text =="" || txtMail.Text == "" || txtThl.Text == " ")
                {
                    MessageBox.Show("Please fill the fields");
                }
                else
                {
                   using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UsrSupport", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@name", txtName.Text);
                    sqlCmd.Parameters.AddWithValue("@epwn", txtEpwn.Text);
                    sqlCmd.Parameters.AddWithValue("@mail", txtMail.Text);
                    sqlCmd.Parameters.AddWithValue("@msg", rtxtMsg.Text);
                    sqlCmd.Parameters.AddWithValue("@thl", txtThl.Text);
                    sqlCmd.ExecuteNonQuery();
                }

                    
                    

           
                }
                void Clear()
            {
                txtName.Text = txtEpwn.Text = txtMail.Text = txtThl.Text = rtxtMsg.Text = "";
            }
            
        }
    }
}
