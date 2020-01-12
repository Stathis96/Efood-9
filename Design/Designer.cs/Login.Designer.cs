namespace MrDelivery
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.eisodos = new System.Windows.Forms.Label();
            this.go_to_signup = new System.Windows.Forms.Label();
            this.go_to_sign_up_button = new System.Windows.Forms.Button();
            this.loginbut = new System.Windows.Forms.Button();
            this.login_user = new System.Windows.Forms.Label();
            this.login_pass = new System.Windows.Forms.Label();
            this.unameLogin = new System.Windows.Forms.TextBox();
            this.passLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // eisodos
            // 
            this.eisodos.AutoSize = true;
            this.eisodos.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.eisodos.ForeColor = System.Drawing.Color.Firebrick;
            this.eisodos.Location = new System.Drawing.Point(190, 21);
            this.eisodos.Name = "eisodos";
            this.eisodos.Size = new System.Drawing.Size(228, 36);
            this.eisodos.TabIndex = 0;
            this.eisodos.Text = "ΕΙΣΟΔΟΣ ΧΡΗΣΤΗ";
            // 
            // go_to_signup
            // 
            this.go_to_signup.AutoSize = true;
            this.go_to_signup.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.go_to_signup.ForeColor = System.Drawing.Color.Firebrick;
            this.go_to_signup.Location = new System.Drawing.Point(12, 421);
            this.go_to_signup.Name = "go_to_signup";
            this.go_to_signup.Size = new System.Drawing.Size(254, 29);
            this.go_to_signup.TabIndex = 2;
            this.go_to_signup.Text = "Δεν έχεις λογαριασμό ? ";
            // 
            // go_to_sign_up_button
            // 
            this.go_to_sign_up_button.BackColor = System.Drawing.Color.Snow;
            this.go_to_sign_up_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.go_to_sign_up_button.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.go_to_sign_up_button.ForeColor = System.Drawing.Color.Firebrick;
            this.go_to_sign_up_button.Location = new System.Drawing.Point(300, 421);
            this.go_to_sign_up_button.Name = "go_to_sign_up_button";
            this.go_to_sign_up_button.Size = new System.Drawing.Size(184, 31);
            this.go_to_sign_up_button.TabIndex = 3;
            this.go_to_sign_up_button.Text = "ΕΓΓΡΑΦΗ ΧΡΗΣΤΗ";
            this.go_to_sign_up_button.UseVisualStyleBackColor = false;
            this.go_to_sign_up_button.Click += new System.EventHandler(this.go_to_sign_up_button_Click);
            // 
            // loginbut
            // 
            this.loginbut.BackColor = System.Drawing.Color.Snow;
            this.loginbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.loginbut.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginbut.ForeColor = System.Drawing.Color.Firebrick;
            this.loginbut.Location = new System.Drawing.Point(260, 290);
            this.loginbut.Name = "loginbut";
            this.loginbut.Size = new System.Drawing.Size(123, 35);
            this.loginbut.TabIndex = 4;
            this.loginbut.Text = "ΣΥΝΔΕΣΗ";
            this.loginbut.UseVisualStyleBackColor = false;
            this.loginbut.Click += new System.EventHandler(this.loginbut_Click);
            // 
            // login_user
            // 
            this.login_user.AutoSize = true;
            this.login_user.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.login_user.ForeColor = System.Drawing.Color.Firebrick;
            this.login_user.Location = new System.Drawing.Point(206, 107);
            this.login_user.Name = "login_user";
            this.login_user.Size = new System.Drawing.Size(132, 33);
            this.login_user.TabIndex = 0;
            this.login_user.Text = "Username";
            this.login_user.Click += new System.EventHandler(this.loginbut_Click);
            // 
            // login_pass
            // 
            this.login_pass.AutoSize = true;
            this.login_pass.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.login_pass.ForeColor = System.Drawing.Color.Firebrick;
            this.login_pass.Location = new System.Drawing.Point(206, 191);
            this.login_pass.Name = "login_pass";
            this.login_pass.Size = new System.Drawing.Size(126, 33);
            this.login_pass.TabIndex = 1;
            this.login_pass.Text = "Password";
            // 
            // unameLogin
            // 
            this.unameLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameLogin.Location = new System.Drawing.Point(212, 143);
            this.unameLogin.Name = "unameLogin";
            this.unameLogin.Size = new System.Drawing.Size(220, 26);
            this.unameLogin.TabIndex = 2;
            // 
            // passLogin
            // 
            this.passLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLogin.Location = new System.Drawing.Point(212, 227);
            this.passLogin.Name = "passLogin";
            this.passLogin.Size = new System.Drawing.Size(220, 26);
            this.passLogin.TabIndex = 3;
            this.passLogin.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MrDelivery.Properties.Resources.l4;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(153, 143);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(153, 227);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(643, 512);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_user);
            this.Controls.Add(this.login_pass);
            this.Controls.Add(this.passLogin);
            this.Controls.Add(this.unameLogin);
            this.Controls.Add(this.loginbut);
            this.Controls.Add(this.go_to_sign_up_button);
            this.Controls.Add(this.go_to_signup);
            this.Controls.Add(this.eisodos);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eisodos;
        private System.Windows.Forms.Label go_to_signup;
        private System.Windows.Forms.Button go_to_sign_up_button;
        private System.Windows.Forms.Button loginbut;
        private System.Windows.Forms.Label login_user;
        private System.Windows.Forms.Label login_pass;
        private System.Windows.Forms.TextBox unameLogin;
        private System.Windows.Forms.TextBox passLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}