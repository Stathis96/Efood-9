using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrDelivery
{
    public partial class Current_Location : Form
    {
        public Current_Location()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street = textBox1.Text;
            string city = textBox2.Text;

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                if (street != string.Empty)
                {
                    queryaddress.Append(street + "," + "+");    
                }
                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
