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
    public partial class S2 : Form
    {
        double ichange;
        const double Price_Sokolata = 2.1;
        const double Price_Bueno = 2.5;
        const double Price_3bit = 3.1;
        const double Price_Mpiskoto = 2.7;
        const double Price_Leykh = 10.2;
        const double Price_Oreo = 1.5;
        const double Price_Cheesecake = 3.3;
        const double Price_Ygeias = 4.5;
        const double Price_Zampon = 2.2;
        const double Price_Tyria = 3.4;
        const double Price_Kotompoukies = 4.5;
        const double Price_Vegan = 3.1;
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
        public S2()
        {
            InitializeComponent();
        }

        private void S2_Load(object sender, EventArgs e)
        {

        }

        private void prosthiki2_Click(object sender, EventArgs e)
        {
            var newForm = new CartPayment(txtTotal.Text);
            newForm.Show(this);
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


        private void chksokola_CheckedChanged(object sender, EventArgs e)
        {
            if (chksokola.Checked == true)
            {
                txtSokola.Enabled = true;
                txtSokola.Text = "";
                txtSokola.Focus();
            }
            else
            {
                txtSokola.Enabled = false;
                txtSokola.Text = "0";
            }
        }

        private void chkbueno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbueno.Checked == true)
            {
                txtBueno.Enabled = true;
                txtBueno.Text = "";
                txtBueno.Focus();
            }
            else
            {
                txtBueno.Enabled = false;
                txtBueno.Text = "0";
            }
        }

        private void chk3bit_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3bit.Checked == true)
            {
                txt3bit.Enabled = true;
                txt3bit.Text = "";
                txt3bit.Focus();
            }
            else
            {
                txt3bit.Enabled = false;
                txt3bit.Text = "0";
            }
        }

        private void chkbisc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbisc.Checked == true)
            {
                txtBisc.Enabled = true;
                txtBisc.Text = "";
                txtBisc.Focus();
            }
            else
            {
                txtBisc.Enabled = false;
                txtBisc.Text = "0";
            }
        }

        private void chkwhite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkwhite.Checked == true)
            {
                txtWhite.Enabled = true;
                txtWhite.Text = "";
                txtWhite.Focus();
            }
            else
            {
                txtWhite.Enabled = false;
                txtWhite.Text = "0";
            }
        }

        private void chkoreo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkoreo.Checked == true)
            {
                txtOreo.Enabled = true;
                txtOreo.Text = "";
                txtOreo.Focus();
            }
            else
            {
                txtOreo.Enabled = false;
                txtOreo.Text = "0";
            }
        }

        private void chkcheesecake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcheesecake.Checked == true)
            {
                txtCheese.Enabled = true;
                txtCheese.Text = "";
                txtCheese.Focus();
            }
            else
            {
                txtCheese.Enabled = false;
                txtCheese.Text = "0";
            }
        }

        private void chkhealth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhealth.Checked == true)
            {
                txtHealth.Enabled = true;
                txtHealth.Text = "";
                txtHealth.Focus();
            }
            else
            {
                txtHealth.Enabled = false;
                txtHealth.Text = "0";
            }
        }

        private void chkzampon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkzampon.Checked == true)
            {
                txtZampon.Enabled = true;
                txtZampon.Text = "";
                txtZampon.Focus();
            }
            else
            {
                txtZampon.Enabled = false;
                txtZampon.Text = "0";
            }
        }

        private void chktyria_CheckedChanged(object sender, EventArgs e)
        {
            if (chktyria.Checked == true)
            {
                txtTyria.Enabled = true;
                txtTyria.Text = "";
                txtTyria.Focus();
            }
            else
            {
                txtTyria.Enabled = false;
                txtTyria.Text = "0";
            }
        }

        private void chkkotomp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkkotomp.Checked == true)
            {
                txtKotomp.Enabled = true;
                txtKotomp.Text = "";
                txtKotomp.Focus();
            }
            else
            {
                txtKotomp.Enabled = false;
                txtKotomp.Text = "0";
            }
        }

        private void chkvegan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvegan.Checked == true)
            {
                txtVegan.Enabled = true;
                txtVegan.Text = "";
                txtVegan.Focus();
            }
            else
            {
                txtVegan.Enabled = false;
                txtVegan.Text = "0";
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

        private void commbtn_Click(object sender, EventArgs e)
        {
            var newForm = new Comm2();
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var newForm = new Comm1();
            newForm.Show();
        }

        private void resetbut_Click_1(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes(); 
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[20];
            itemcost[0] = Convert.ToDouble(txtSokola.Text) * Price_Sokolata;
            itemcost[1] = Convert.ToDouble(txtBueno.Text) * Price_Bueno;
            itemcost[2] = Convert.ToDouble(txt3bit.Text) * Price_3bit;
            itemcost[3] = Convert.ToDouble(txtBisc.Text) * Price_Mpiskoto;
            itemcost[4] = Convert.ToDouble(txtWhite.Text) * Price_Leykh;
            itemcost[5] = Convert.ToDouble(txtOreo.Text) * Price_Oreo;
            itemcost[6] = Convert.ToDouble(txtCheese.Text) * Price_Cheesecake;
            itemcost[7] = Convert.ToDouble(txtHealth.Text) * Price_Ygeias;
            itemcost[8] = Convert.ToDouble(txtZampon.Text) * Price_Zampon;
            itemcost[9] = Convert.ToDouble(txtTyria.Text) * Price_Tyria;
            itemcost[10] = Convert.ToDouble(txtKotomp.Text) * Price_Kotompoukies;
            itemcost[11] = Convert.ToDouble(txtVegan.Text) * Price_Vegan;
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
            ichange = Convert.ToDouble(txtPayment.Text);
            cost = ichange - iTotal;
            txtChange.Text = Convert.ToString(cost);

            txtChange.Text = String.Format("{0:C}", cost);
            txtTax.Text = String.Format("{0:C}", iTax);
            txtSub.Text = String.Format("{0:C}", iSub);
            txtTotal.Text = String.Format("{0:C}", iTotal);
        }
    }

       
       
    }

