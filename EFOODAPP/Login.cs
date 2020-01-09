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
    public partial class Login : Form
    {
        string connectionString = @"Data Source=DESKTOP-QABCRCQ;Initial Catalog=MRDELIVERY;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

       

        private void go_to_sign_up_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new SignUp();
            newForm.Show();
        }

        private void loginbut_Click(object sender, EventArgs e)
        {
            try
            {
                if (unameLogin.Text == "" && passLogin.Text == "")
                {
                    MessageBox.Show("Please Enter Username And Password");
                }
                else
                {
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand cmd = new SqlCommand("select * from tbl_user2 where Username=@Username and Password=@Password", con);
                    cmd.Parameters.AddWithValue("@Username", unameLogin.Text);
                    cmd.Parameters.AddWithValue("@Password", passLogin.Text);

                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();

                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("Successfully Login");
                        this.Hide();
                    
                        var newForm = new Shops();
                        newForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password");

                    }
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        
        }

        private void login_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void guestbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form1();
            newForm.Show();
        }
    }
}
