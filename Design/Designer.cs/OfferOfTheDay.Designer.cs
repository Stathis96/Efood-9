namespace MrDelivery
{
    partial class OfferOfTheDay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.offerlabel = new System.Windows.Forms.Label();
            this.offerpricelabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OfferdescrLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.offer = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.offer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HarvestItal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ΠΡΟΣΦΟΡΑ ΗΜΕΡΑΣ ";
            // 
            // offerlabel
            // 
            this.offerlabel.AutoSize = true;
            this.offerlabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.offerlabel.ForeColor = System.Drawing.Color.Maroon;
            this.offerlabel.Location = new System.Drawing.Point(8, 379);
            this.offerlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.offerlabel.Name = "offerlabel";
            this.offerlabel.Size = new System.Drawing.Size(544, 23);
            this.offerlabel.TabIndex = 2;
            this.offerlabel.Text = "Μια οικογενειακή πίτσα της αρεσκείας σας και μια Coke Cola (1L) ";
            // 
            // offerpricelabel1
            // 
            this.offerpricelabel1.AutoSize = true;
            this.offerpricelabel1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offerpricelabel1.Location = new System.Drawing.Point(533, 17);
            this.offerpricelabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.offerpricelabel1.Name = "offerpricelabel1";
            this.offerpricelabel1.Size = new System.Drawing.Size(50, 18);
            this.offerpricelabel1.TabIndex = 3;
            this.offerpricelabel1.Text = "TIMH";
            this.offerpricelabel1.Click += new System.EventHandler(this.offerpricelabel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(564, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "5 €";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OfferdescrLabel
            // 
            this.OfferdescrLabel.AutoSize = true;
            this.OfferdescrLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfferdescrLabel.Location = new System.Drawing.Point(12, 17);
            this.OfferdescrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OfferdescrLabel.Name = "OfferdescrLabel";
            this.OfferdescrLabel.Size = new System.Drawing.Size(99, 18);
            this.OfferdescrLabel.TabIndex = 5;
            this.OfferdescrLabel.Text = "ΠΕΡΙΓΡΑΦΗ";
            this.OfferdescrLabel.Click += new System.EventHandler(this.OfferdescrLabel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(167, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "ΠΡΟΣΘΗΚΗ ΣΤΟ ΚΑΛΑΘΙ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // offer
            // 
            this.offer.Image = global::MrDelivery.Properties.Resources.offer;
            this.offer.Location = new System.Drawing.Point(113, 56);
            this.offer.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.offer.Name = "offer";
            this.offer.Size = new System.Drawing.Size(386, 254);
            this.offer.TabIndex = 1;
            this.offer.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.offerpricelabel1);
            this.panel1.Controls.Add(this.OfferdescrLabel);
            this.panel1.Location = new System.Drawing.Point(12, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 43);
            this.panel1.TabIndex = 7;
            // 
            // OfferOfTheDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(634, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.offerlabel);
            this.Controls.Add(this.offer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "OfferOfTheDay";
            this.Text = "OfferOfTheDay";
            this.Load += new System.EventHandler(this.MenuOfTheDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox offer;
        private System.Windows.Forms.Label offerlabel;
        private System.Windows.Forms.Label offerpricelabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OfferdescrLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}