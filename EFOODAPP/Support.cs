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
        string connectionString= @"Data Source=DESKTOP-FKR3N92;Initial Catalog-efood;Integrated Security=True";
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
            
                if (txtName.Text == "" && txtEpwn.Text =="" && txtMail.Text == "" && txtThl.Text == " ")
                {
                    MessageBox.Show("Please fill the fields");
                }
                else
                {
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand cmd = new SqlCommand("select * from support where name=@name and epwn=@epwn and mail=@mail and thl=@thl and msg=@msg", con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@epwn", txtEpwn.Text);
                    cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                    cmd.Parameters.AddWithValue("@msg", rtxtMsg.Text);

                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();
                }
            
        }
    }
}
