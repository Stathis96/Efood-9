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
    public partial class Comm2 : Form
    {
        private const string V = "2";
        string connectionString = @"Data Source=DESKTOP-QABCRCQ;Initial Catalog=MRDELIVERY;Integrated Security=True";
        public Comm2()
        {
            InitializeComponent();
        }

        private void Comm2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();



            string sqlSelectQuery = "SELECT Phone FROM tbl_Shop WHERE ID= " + int.Parse(V);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                epiklbl.Text = (dr["Phone"].ToString());



            }
        }
    }
}
