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
    public partial class S1 : Form
    {
        double ichange;
        const double Price_Fries =2.1;
        const double Price_Salad = 2.5;
        const double Price_Burger = 3.1;
        const double Price_Sandw = 2.7;
        const double Price_Pizza = 10.2;
        const double Price_Souvlakia = 1.5;
        const double Price_Gyros = 3.3;
        const double Price_Club = 4.5;
        const double Price_Soufle = 2.2;
        const double Price_Revani = 3.4;
        const double Price_Poutingka = 4.5;
        const double Price_Profiterol = 3.1;
        const double Price_Cola = 1.5;
        const double Price_Orange = 1.5;
        const double Price_Lemon = 1.5;
        const double Price_Sprite = 1.5;
        const double Price_Tea = 1.5;
        const double Price_NeroMe = 1.2;
        const double Price_NeroMi = 0.5;
        const double Price_Xymos = 1.5;
        const double Tax_Rate = 2.4;
         double iTax,iSub,iTotal;
        public S1()
        {
            InitializeComponent();
        }

        private void prosthiki1_Click(object sender, EventArgs e)
        {
            var newForm = new CartPayment();
            newForm.Show();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void chkfries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfries.Checked == true)
            {
                txtFries.Enabled = true;
                txtFries.Text = "";
                txtFries.Focus();
            }
            else
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        private void chksalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chksalad.Checked == true)
            {
                txtSalad.Enabled = true;
                txtSalad.Text = "";
                txtSalad.Focus();
            }
            else
            {
                txtSalad.Enabled = false;
                txtSalad.Text = "0";
            }
        }

        private void chkburger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkburger.Checked == true)
            {
                txtBurger.Enabled = true;
                txtBurger.Text = "";
                txtBurger.Focus();
            }
            else
            {
                txtBurger.Enabled = false;
                txtBurger.Text = "0";
            }
        }

        private void chksandw_CheckedChanged(object sender, EventArgs e)
        {
            if (chksandw.Checked == true)
            {
                txtSandw.Enabled = true;
                txtSandw.Text = "";
                txtSandw.Focus();
            }
            else
            {
                txtSandw.Enabled = false;
                txtSandw.Text = "0";
            }
        }

        private void chkpizza_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpizza.Checked == true)
            {
                txtPizza.Enabled = true;
                txtPizza.Text = "";
                txtPizza.Focus();
            }
            else
            {
                txtPizza.Enabled = false;
                txtPizza.Text = "0";
            }
        }

        private void chksouvlaki_CheckedChanged(object sender, EventArgs e)
        {
            if (chksouvlaki.Checked == true)
            {
                txtSouvlakia.Enabled = true;
                txtSouvlakia.Text = "";
                txtSouvlakia.Focus();
            }
            else
            {
                txtSouvlakia.Enabled = false;
                txtSouvlakia.Text = "0";
            }
        }

        private void chkgyros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkgyros.Checked == true)
            {
                txtGyros.Enabled = true;
                txtGyros.Text = "";
                txtGyros.Focus();
            }
            else
            {
                txtGyros.Enabled = false;
                txtGyros.Text = "0";
            }
        }

        private void chkclub_CheckedChanged(object sender, EventArgs e)
        {
            if (chkclub.Checked == true)
            {
                txtClub.Enabled = true;
                txtClub.Text = "";
                txtClub.Focus();
            }
            else
            {
                txtClub.Enabled = false;
                txtClub.Text = "0";
            }
        }

        private void chksoufle_CheckedChanged(object sender, EventArgs e)
        {
            if (chksoufle.Checked == true)
            {
                txtSoufle.Enabled = true;
                txtSoufle.Text = "";
                txtSoufle.Focus();
            }
            else
            {
                txtSoufle.Enabled = false;
                txtSoufle.Text = "0";
            }
        }

        private void chkrevani_CheckedChanged(object sender, EventArgs e)
        {
            if (chkrevani.Checked == true)
            {
                txtRevani.Enabled = true;
                txtRevani.Text = "";
                txtRevani.Focus();
            }
            else
            {
                txtRevani.Enabled = false;
                txtRevani.Text = "0";
            }
        }

        private void chkpoutingka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpoutingka.Checked == true)
            {
                txtPoutingka.Enabled = true;
                txtPoutingka.Text = "";
                txtPoutingka.Focus();
            }
            else
            {
                txtPoutingka.Enabled = false;
                txtPoutingka.Text = "0";
            }
        }

        private void chkprofiterol_CheckedChanged(object sender, EventArgs e)
        {
            if (chkprofiterol.Checked == true)
            {
                txtProfiterol.Enabled = true;
                txtProfiterol.Text = "";
                txtProfiterol.Focus();
            }
            else
            {
                txtProfiterol.Enabled = false;
                txtProfiterol.Text = "0";
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

        private void chkxymos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkxymos.Checked == true)
            {
                txtXymos.Enabled = true;
                txtXymos.Text = "";
                txtXymos.Focus();
            }
            else
            {
                txtXymos.Enabled = false;
                txtXymos.Text = "0";
            }
        }

        private void resetbut_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void txtFries_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void S1_Load(object sender, EventArgs e)
        {

        }

        private void commbtn_Click(object sender, EventArgs e)
        {
            var newForm = new Comm1();
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var newForm = new Comm1();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[20];
            itemcost[0] = Convert.ToDouble(txtFries.Text) * Price_Fries;
            itemcost[1] = Convert.ToDouble(txtSalad.Text) * Price_Salad;
            itemcost[2] = Convert.ToDouble(txtBurger.Text) * Price_Burger;
            itemcost[3] = Convert.ToDouble(txtSandw.Text) * Price_Sandw;
            itemcost[4] = Convert.ToDouble(txtPizza.Text) * Price_Pizza;
            itemcost[5] = Convert.ToDouble(txtSouvlakia.Text) * Price_Souvlakia;
            itemcost[6] = Convert.ToDouble(txtGyros.Text) * Price_Gyros;
            itemcost[7] = Convert.ToDouble(txtClub.Text) * Price_Club;
            itemcost[8] = Convert.ToDouble(txtSoufle.Text) * Price_Soufle;
            itemcost[9] = Convert.ToDouble(txtRevani.Text) * Price_Revani;
            itemcost[10] = Convert.ToDouble(txtPoutingka.Text) * Price_Poutingka;
            itemcost[11] = Convert.ToDouble(txtProfiterol.Text) * Price_Profiterol;
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
            txtChange.Text= Convert.ToString(cost);

            txtChange.Text = String.Format("{0:C}", cost);
            txtTax.Text = String.Format("{0:C}", iTax);
            txtSub.Text = String.Format("{0:C}", iSub);
            txtTotal.Text = String.Format("{0:C}", iTotal);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
