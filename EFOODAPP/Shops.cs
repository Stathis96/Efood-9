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
    public partial class Shops : Form
    {
        public Shops()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            var newForm = new S1();
            newForm.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            var newForm = new S2();
            newForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var newForm = new S3();
            newForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var newForm = new S4();
            newForm.Show();
        }
    }
}
