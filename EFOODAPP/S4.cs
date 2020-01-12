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
    public partial class S4 : Form
    {
        public S4()
        {
            InitializeComponent();
        }
        double ichange;
        const double Price_Special = 2.1;
        const double Price_Margarita = 2.5;
        const double Price_Allantikwn = 3.1;
        const double Price_4tyria = 2.7;
        const double Price_Xwriatikhpizza = 10.2;
        const double Price_AlPolo = 1.5;
        const double Price_BBQ = 3.3;
        const double Price_Mexicana = 4.5;
        const double Price_Ceasars = 2.2;
        const double Price_Chef = 3.4;
        const double Price_Xwriatikh = 4.5;
        const double Price_Epoxhs = 3.1;
        const double Price_Cola = 1.5;
        const double Price_Orange = 1.5;
        const double Price_Lemon = 1.5;
        const double Price_Sprite = 1.5;
        const double Price_Tea = 1.5;
        const double Price_NeroMe = 1.2;
        const double Price_NeroMi = 0.5;
        const double Price_Xymos = 1.5;
        const double Tax_Rate = 2.4;
        double iTax, iSub, iTotal;
        private void chkHam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHam.Checked == true)
            {
                txtHam.Enabled = true;
                txtHam.Text = "";
                txtHam.Focus();
            }
            else
            {
                txtHam.Enabled = false;
                txtHam.Text = "0";
            }
        }
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void chkCheeseB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheeseB.Checked == true)
            {
                txtCheeseb.Enabled = true;
                txtCheeseb.Text = "";
                txtCheeseb.Focus();
            }
            else
            {
                txtCheeseb.Enabled = false;
                txtCheeseb.Text = "0";
            }
        }

        private void chkbbq_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBBQB.Checked == true)
            {
                txtBBQburger.Enabled = true;
                txtBBQburger.Text = "";
                txtBBQburger.Focus();
            }
            else
            {
                txtBBQburger.Enabled = false;
                txtBBQburger.Text = "0";
            }
        }

        private void chkjack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkjack.Checked == true)
            {
                txtJack.Enabled = true;
                txtJack.Text = "";
                txtJack.Focus();
            }
            else
            {
                txtJack.Enabled = false;
                txtJack.Text = "0";
            }
        }

        private void chkblack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkblack.Checked == true)
            {
                txtBlack.Enabled = true;
                txtBlack.Text = "";
                txtBlack.Focus();
            }
            else
            {
                txtBlack.Enabled = false;
                txtBlack.Text = "0";
            }
        }

        private void chkphilly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkphilly.Checked == true)
            {
                txtPhilly.Enabled = true;
                txtPhilly.Text = "";
                txtPhilly.Focus();
            }
            else
            {
                txtPhilly.Enabled = false;
                txtPhilly.Text = "0";
            }
        }

        private void chkchicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchicken.Checked == true)
            {
                txtChicken.Enabled = true;
                txtChicken.Text = "";
                txtChicken.Focus();
            }
            else
            {
                txtChicken.Enabled = false;
                txtChicken.Text = "0";
            }
        }

        private void chkceasar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkceasar.Checked == true)
            {
                txtCeasars.Enabled = true;
                txtCeasars.Text = "";
                txtCeasars.Focus();
            }
            else
            {
                txtCeasars.Enabled = false;
                txtCeasars.Text = "0";
            }
        }

        private void chkchef_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchef.Checked == true)
            {
                txtChef.Enabled = true;
                txtChef.Text = "";
                txtChef.Focus();
            }
            else
            {
                txtChef.Enabled = false;
                txtChef.Text = "0";
            }
        }

        private void chkxwriatiki_CheckedChanged(object sender, EventArgs e)
        {
            if (chkxwriatiki.Checked == true)
            {
                txtXwriatikh.Enabled = true;
                txtXwriatikh.Text = "";
                txtXwriatikh.Focus();
            }
            else
            {
                txtXwriatikh.Enabled = false;
                txtXwriatikh.Text = "0";
            }
        }

        private void chkepoxhs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkepoxhs.Checked == true)
            {
                txtEpoxis.Enabled = true;
                txtEpoxis.Text = "";
                txtEpoxis.Focus();
            }
            else
            {
                txtEpoxis.Enabled = false;
                txtEpoxis.Text = "0";
            }
        }

        private void chkveggie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkveggie.Checked == true)
            {
                txtVeggie.Enabled = true;
                txtVeggie.Text = "";
                txtVeggie.Focus();
            }
            else
            {
                txtVeggie.Enabled = false;
                txtVeggie.Text = "0";
            }
        }

        private void chkCola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCola.Checked == true)
            {
                txtCola.Enabled = true;
                txtCola.Text = "";
                txtCola.Focus();
            }
            else
            {
                txtCola.Enabled = false;
                txtCola.Text = "0";
            }
        }

        private void chkOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrange.Checked == true)
            {
                txtOrange.Enabled = true;
                txtOrange.Text = "";
                txtOrange.Focus();
            }
            else
            {
                txtOrange.Enabled = false;
                txtOrange.Text = "0";
            }
        }

        private void chkLemon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLemon.Checked == true)
            {
                txtLemon.Enabled = true;
                txtLemon.Text = "";
                txtLemon.Focus();
            }
            else
            {
                txtLemon.Enabled = false;
                txtLemon.Text = "0";
            }
        }

        private void chksprite_CheckedChanged(object sender, EventArgs e)
        {
            if (chksprite.Checked == true)
            {
                txtSprite.Enabled = true;
                txtSprite.Text = "";
                txtSprite.Focus();
            }
            else
            {
                txtSprite.Enabled = false;
                txtSprite.Text = "0";
            }
        }

        private void chktea_CheckedChanged(object sender, EventArgs e)
        {
            if (chktea.Checked == true)
            {
                txtTea.Enabled = true;
                txtTea.Text = "";
                txtTea.Focus();
            }
            else
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void chknerome_CheckedChanged(object sender, EventArgs e)
        {
            if (chknerome.Checked == true)
            {
                txtNeroMe.Enabled = true;
                txtNeroMe.Text = "";
                txtNeroMe.Focus();
            }
            else
            {
                txtNeroMe.Enabled = false;
                txtNeroMe.Text = "0";
            }
        }

        private void chkneromi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkneromi.Checked == true)
            {
                txtNeroMi.Enabled = true;
                txtNeroMi.Text = "";
                txtNeroMi.Focus();
            }
            else
            {
                txtNeroMi.Enabled = false;
                txtNeroMi.Text = "0";
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[20];
            itemcost[0] = Convert.ToDouble(txtHam.Text) * Price_Special;
            itemcost[1] = Convert.ToDouble(txtCheeseb.Text) * Price_Margarita;
            itemcost[2] = Convert.ToDouble(txtBBQburger.Text) * Price_Allantikwn;
            itemcost[3] = Convert.ToDouble(txtJack.Text) * Price_4tyria;
            itemcost[4] = Convert.ToDouble(txtBlack.Text) * Price_Xwriatikhpizza;
            itemcost[5] = Convert.ToDouble(txtPhilly.Text) * Price_AlPolo;
            itemcost[6] = Convert.ToDouble(txtChicken.Text) * Price_BBQ;
            itemcost[7] = Convert.ToDouble(txtVeggie.Text) * Price_Mexicana;
            itemcost[8] = Convert.ToDouble(txtCeasars.Text) * Price_Ceasars;
            itemcost[9] = Convert.ToDouble(txtChef.Text) * Price_Chef;
            itemcost[10] = Convert.ToDouble(txtEpoxis.Text) * Price_Epoxhs;
            itemcost[11] = Convert.ToDouble(txtXwriatikh.Text) * Price_Xwriatikh;
            itemcost[12] = Convert.ToDouble(txtCola.Text) * Price_Cola;
            itemcost[13] = Convert.ToDouble(txtOrange.Text) * Price_Orange;
            itemcost[14] = Convert.ToDouble(txtLemon.Text) * Price_Lemon;
            itemcost[15] = Convert.ToDouble(txtTea.Text) * Price_Tea;
            itemcost[16] = Convert.ToDouble(txtSprite.Text) * Price_Sprite;
            itemcost[17] = Convert.ToDouble(txtNeroMe.Text) * Price_NeroMe;
            itemcost[18] = Convert.ToDouble(txtNeroMi.Text) * Price_NeroMi;
            itemcost[19] = Convert.ToDouble(txtXymos.Text) * Price_Xymos;
            double cost;


            iSub = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] +
                itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] +
                itemcost[18] + itemcost[19];

            txtSub.Text = Convert.ToString(iSub);
            iTax = (iSub * Tax_Rate) / 100;
            txtTax.Text = Convert.ToString(iTax);
            iTotal = (iSub + iTax);
            txtTotal.Text = Convert.ToString(iTotal);
            cost = ichange - (iTax + iTotal);
            txtChange.Text = Convert.ToString(cost);

            txtChange.Text = String.Format("{0:C}", cost);
            txtTax.Text = String.Format("{0:C}", iTax);
            txtSub.Text = String.Format("{0:C}", iSub);
            txtTotal.Text = String.Format("{0:C}", iTotal);
        }

        private void resetbut_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void commbtn_Click(object sender, EventArgs e)
        {
            var newForm = new Comm4();
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var newForm = new Comm1();
            newForm.Show();
        }

        private void S4_Load(object sender, EventArgs e)
        {

        }

        private void prosthiki4_Click(object sender, EventArgs e)
        {
            var newForm = new CartPayment();
            newForm.Show();
        }
    }
}
