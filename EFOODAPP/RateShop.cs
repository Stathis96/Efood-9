﻿using System;
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


    public partial class RateShop : Form
    {
        string connectionString = @"Data Source=STAM\STAMSQL; Initial Catalog= ShopRatingDB; Integrated Security=True";

        
        public RateShop()
        {
            InitializeComponent();
            
        }

        

        double ShpID;
        double ScoreTaxitita;
        double ScorePoiothta;
        double currentmo = 0;
        double mo;
        double oldMo = 0;
        string convertMo;
        string txtMo;

        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = false;
            te4.Visible = true;
            te5.Visible = true;
            te6.Visible = true;
            te7.Visible = true;
            te8.Visible = true;
            te9.Visible = false;
            te10.Visible = false;

            ScoreTaxitita = 3;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = false;
            te4.Visible = false;
            te5.Visible = true;
            te6.Visible = true;
            te7.Visible = true;
            te8.Visible = true;
            te9.Visible = true;
            te10.Visible = false;

            ScoreTaxitita = 4;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newForm = new Rating();
            newForm.Show();
        }

        private void pp1_Click_1(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = true;
            pp3.Visible = true;
            pp4.Visible = true;
            pp5.Visible = true;
            pp6.Visible = true;
            pp7.Visible = false;
            pp8.Visible = false;
            pp9.Visible = false;
            pp10.Visible = false;

            ScorePoiothta = 1;
        }

        private void pp2_Click(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = false;
            pp3.Visible = true;
            pp4.Visible = true;
            pp5.Visible = true;
            pp6.Visible = true;
            pp7.Visible = true;
            pp8.Visible = false;
            pp9.Visible = false;
            pp10.Visible = false;

            ScorePoiothta = 2;
        }

        private void pp3_Click(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = false;
            pp3.Visible = false;
            pp4.Visible = true;
            pp5.Visible = true;
            pp6.Visible = true;
            pp7.Visible = true;
            pp8.Visible = true;
            pp9.Visible = false;
            pp10.Visible = false;

            ScorePoiothta = 3;
        }

        private void pp4_Click(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = false;
            pp3.Visible = false;
            pp4.Visible = false;
            pp5.Visible = true;
            pp6.Visible = true;
            pp7.Visible = true;
            pp8.Visible = true;
            pp9.Visible = true;
            pp10.Visible = false;

            ScorePoiothta = 4;
        }

        private void pp5_Click(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = false;
            pp3.Visible = false;
            pp4.Visible = false;
            pp5.Visible = false;
            pp6.Visible = true;
            pp7.Visible = true;
            pp8.Visible = true;
            pp9.Visible = true;
            pp10.Visible = true;

            ScorePoiothta = 5;
        }

        private void pp6_Click(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = true;
            pp3.Visible = true;
            pp4.Visible = true;
            pp5.Visible = true;
            pp6.Visible = true;
            pp7.Visible = false;
            pp8.Visible = false;
            pp9.Visible = false;
            pp10.Visible = false;

            ScorePoiothta = 1;
        }

        private void pp7_Click(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = false;
            pp3.Visible = true;
            pp4.Visible = true;
            pp5.Visible = true;
            pp6.Visible = true;
            pp7.Visible = true;
            pp8.Visible = false;
            pp9.Visible = false;
            pp10.Visible = false;

            ScorePoiothta = 2;
        }

        private void pp8_Click(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = false;
            pp3.Visible = false;
            pp4.Visible = true;
            pp5.Visible = true;
            pp6.Visible = true;
            pp7.Visible = true;
            pp8.Visible = true;
            pp9.Visible = false;
            pp10.Visible = false;

            ScorePoiothta = 3;
        }

        private void pp9_Click(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = false;
            pp3.Visible = false;
            pp4.Visible = false;
            pp5.Visible = true;
            pp6.Visible = true;
            pp7.Visible = true;
            pp8.Visible = true;
            pp9.Visible = true;
            pp10.Visible = false;

            ScorePoiothta = 4;
        }

        private void pp10_Click(object sender, EventArgs e)
        {
            pp1.Visible = false;
            pp2.Visible = false;
            pp3.Visible = false;
            pp4.Visible = false;
            pp5.Visible = false;
            pp6.Visible = true;
            pp7.Visible = true;
            pp8.Visible = true;
            pp9.Visible = true;
            pp10.Visible = true;

            ScorePoiothta = 5;
        }

        private void te6_Click(object sender, EventArgs e)
        {
            te1.Visible = true;
            te2.Visible = true;
            te3.Visible = true;
            te4.Visible = true;
            te5.Visible = true;
            te6.Visible = true;
            te7.Visible = false;
            te8.Visible = false;
            te9.Visible = false;
            te10.Visible = false;

            ScoreTaxitita = 1;
        }

        private void te7_Click(object sender, EventArgs e)
        {
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = true;
            te4.Visible = true;
            te5.Visible = true;
            te6.Visible = true;
            te7.Visible = true;
            te8.Visible = false;
            te9.Visible = false;
            te10.Visible = false;

            ScoreTaxitita = 2;
        }

        private void te8_Click(object sender, EventArgs e)
        {
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = false;
            te4.Visible = true;
            te5.Visible = true;
            te6.Visible = true;
            te7.Visible = true;
            te8.Visible = true;
            te9.Visible = false;
            te10.Visible = false;

            ScoreTaxitita = 3;
        }

        private void te9_Click(object sender, EventArgs e)
        {
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = false;
            te4.Visible = false;
            te5.Visible = true;
            te6.Visible = true;
            te7.Visible = true;
            te8.Visible = true;
            te9.Visible = true;
            te10.Visible = false;

            ScoreTaxitita = 4;
        }

        private void te10_Click(object sender, EventArgs e)
        {
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = false;
            te4.Visible = false;
            te5.Visible = false;
            te6.Visible = true;
            te7.Visible = true;
            te8.Visible = true;
            te9.Visible = true;
            te10.Visible = true;

            ScoreTaxitita = 5;
        }

        private void te1_Click(object sender, EventArgs e)
        {
            te1.Visible = false;
            te2.Visible = true;
            te3.Visible = true;
            te4.Visible = true;
            te5.Visible = true;
            te6.Visible = true;
            te7.Visible = false;
            te8.Visible = false;
            te9.Visible = false;
            te10.Visible = false;

            ScoreTaxitita = 1;
        }

        private void te2_Click(object sender, EventArgs e)
        {
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = true;
            te4.Visible = true;
            te5.Visible = true;
            te6.Visible = true;
            te7.Visible = true;
            te8.Visible = false;
            te9.Visible = false;
            te10.Visible = false;

            ScoreTaxitita = 2;
        }

        private void te5_Click(object sender, EventArgs e)
        {
            te1.Visible = false;
            te2.Visible = false;
            te3.Visible = false;
            te4.Visible = false;
            te5.Visible = false;
            te6.Visible = true;
            te7.Visible = true;
            te8.Visible = true;
            te9.Visible = true;
            te10.Visible = true;

            ScoreTaxitita = 5;
        }

        int ShopID;
        string ShopIDtoInt;
        private void RateShop_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            using (SqlCommand command = sqlCon.CreateCommand())
            {
                sqlCon.Open();
                command.CommandText = "SELECT * from tbl_ShopID_ForRate";

                SqlDataReader reader = (null);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ShopIDtoInt = (reader["ShopID"].ToString());
                }

                int.TryParse(ShopIDtoInt, out ShopID);

            }
        }

        private void ApostoliButton_Click(object sender, EventArgs e)
        {
            
            currentmo = (ScorePoiothta + ScoreTaxitita) / 2;

            if (ShopID == 1)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                using (SqlCommand command = sqlCon.CreateCommand())
                {

                    sqlCon.Open();
                    command.CommandText = "SELECT ShopRating FROM(SELECT ShopRating, ROW_NUMBER() OVER(ORDER BY ShopID) AS rownumber FROM tbl_RateShop) AS foo WHERE foo.rownumber BETWEEN 1 and 1";

                    SqlDataReader reader = (null);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        convertMo = (reader["ShopRating"].ToString());
                    }
                    sqlCon.Close();

                    double.TryParse(convertMo, out oldMo);

                    mo = (currentmo + oldMo) / 2;

                    txtMo = mo.ToString();

                    sqlCon.Open();

                    command.CommandText = "UPDATE tbl_RateShop SET ShopRating = '" + txtMo + "' WHERE ShopID = 1";
                    command.ExecuteNonQuery();

                    sqlCon.Close();

                    MessageBox.Show("Ευχαριστούμε για την αξιολόγηση!");
                    this.Hide();
                    var newForm = new MrDelivery();
                    newForm.Show();
                }
            }

            if (ShopID == 2)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                using (SqlCommand command = sqlCon.CreateCommand())
                {

                    sqlCon.Open();
                    command.CommandText = "SELECT ShopRating FROM(SELECT ShopRating, ROW_NUMBER() OVER(ORDER BY ShopID) AS rownumber FROM tbl_RateShop) AS foo WHERE foo.rownumber BETWEEN 2 and 2";

                    SqlDataReader reader = (null);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        convertMo = (reader["ShopRating"].ToString());
                    }
                    sqlCon.Close();

                    double.TryParse(convertMo, out oldMo);

                    mo = (currentmo + oldMo) / 2;

                    txtMo = mo.ToString();

                    sqlCon.Open();

                    command.CommandText = "UPDATE tbl_RateShop SET ShopRating = '" + txtMo + "' WHERE ShopID = 2";
                    command.ExecuteNonQuery();

                    sqlCon.Close();

                    MessageBox.Show("Ευχαριστούμε για την αξιολόγηση!");
                    this.Hide();
                    var newForm = new MrDelivery();
                    newForm.Show();
                }
            }

            if (ShopID == 3)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                using (SqlCommand command = sqlCon.CreateCommand())
                {

                    sqlCon.Open();
                    command.CommandText = "SELECT ShopRating FROM(SELECT ShopRating, ROW_NUMBER() OVER(ORDER BY ShopID) AS rownumber FROM tbl_RateShop) AS foo WHERE foo.rownumber BETWEEN 3 and 3";

                    SqlDataReader reader = (null);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        convertMo = (reader["ShopRating"].ToString());
                    }
                    sqlCon.Close();

                    double.TryParse(convertMo, out oldMo);

                    mo = (currentmo + oldMo) / 2;

                    txtMo = mo.ToString();

                    sqlCon.Open();

                    command.CommandText = "UPDATE tbl_RateShop SET ShopRating = '" + txtMo + "' WHERE ShopID = 3";
                    command.ExecuteNonQuery();

                    sqlCon.Close();

                    MessageBox.Show("Ευχαριστούμε για την αξιολόγηση!");
                    this.Hide();
                    var newForm = new MrDelivery();
                    newForm.Show();
                }
            }

            if (ShopID == 4)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                using (SqlCommand command = sqlCon.CreateCommand())
                {

                    sqlCon.Open();
                    command.CommandText = "SELECT ShopRating FROM(SELECT ShopRating, ROW_NUMBER() OVER(ORDER BY ShopID) AS rownumber FROM tbl_RateShop) AS foo WHERE foo.rownumber BETWEEN 4 and 4";

                    SqlDataReader reader = (null);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        convertMo = (reader["ShopRating"].ToString());
                    }
                    sqlCon.Close();

                    double.TryParse(convertMo, out oldMo);

                    mo = (currentmo + oldMo) / 2;

                    txtMo = mo.ToString();

                    sqlCon.Open();

                    command.CommandText = "UPDATE tbl_RateShop SET ShopRating = '" + txtMo + "' WHERE ShopID = 4";                   
                    command.ExecuteNonQuery();

                    sqlCon.Close();

                    MessageBox.Show("Ευχαριστούμε για την αξιολόγηση!");
                    this.Hide();
                    var newForm = new MrDelivery();
                    newForm.Show();
                }
            }

        }

    }
}

