namespace Agrisim
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
<<<<<<< HEAD
            this.LoginPnl = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Title = new System.Windows.Forms.Label();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.ForgotLnk = new System.Windows.Forms.LinkLabel();
            this.LoginPnl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
=======
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
>>>>>>> cbab1c947f6bd2503e73d3f8dfbd417328f21375
            this.SuspendLayout();
            // 
            // LoginPnl
            // 
<<<<<<< HEAD
            this.LoginPnl.BackColor = System.Drawing.Color.Transparent;
            this.LoginPnl.Controls.Add(this.guna2Panel1);
            this.LoginPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPnl.Location = new System.Drawing.Point(0, 0);
            this.LoginPnl.Name = "LoginPnl";
            this.LoginPnl.Size = new System.Drawing.Size(1161, 625);
            this.LoginPnl.TabIndex = 10;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.guna2Panel1.Controls.Add(this.Title);
            this.guna2Panel1.Controls.Add(this.textBoxPassword);
            this.guna2Panel1.Controls.Add(this.textBoxUsername);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Controls.Add(this.ForgotLnk);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(427, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(734, 625);
            this.guna2Panel1.TabIndex = 10;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Stencil", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.Title.Location = new System.Drawing.Point(210, 81);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(318, 56);
            this.Title.TabIndex = 10;
            this.Title.Text = "Admin Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.textBoxPassword.BorderRadius = 5;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.IconLeft = global::Agrisim.Properties.Resources.lock_solid;
            this.textBoxPassword.IconLeftOffset = new System.Drawing.Point(1, 0);
            this.textBoxPassword.IconLeftSize = new System.Drawing.Size(18, 18);
            this.textBoxPassword.IconRight = global::Agrisim.Properties.Resources.eye_regular;
            this.textBoxPassword.IconRightOffset = new System.Drawing.Point(1, 0);
            this.textBoxPassword.IconRightSize = new System.Drawing.Size(16, 16);
            this.textBoxPassword.Location = new System.Drawing.Point(164, 281);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(407, 41);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.IconRightClick += textBoxPassword_IconRightClick;
=======
            this.textBoxUsername.Location = new System.Drawing.Point(210, 129);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(198, 20);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(210, 214);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(198, 20);
            this.textBoxPassword.TabIndex = 1;
>>>>>>> cbab1c947f6bd2503e73d3f8dfbd417328f21375
            // 
            // textBoxUsername
            // 
<<<<<<< HEAD
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.textBoxUsername.BorderRadius = 5;
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.DefaultText = "";
            this.textBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.IconLeft = global::Agrisim.Properties.Resources.user_solid;
            this.textBoxUsername.IconLeftOffset = new System.Drawing.Point(1, 0);
            this.textBoxUsername.IconLeftSize = new System.Drawing.Size(18, 18);
            this.textBoxUsername.Location = new System.Drawing.Point(164, 215);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "Username";
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(407, 41);
            this.textBoxUsername.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(164, 392);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(407, 56);
            this.btnLogin.TabIndex = 8;
=======
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(210, 111);
            this.labelusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(71, 19);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "Username";
            this.labelusername.Click += new System.EventHandler(this.labelusername_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(210, 193);
            this.labelpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(68, 19);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Password";
            this.labelpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.Location = new System.Drawing.Point(260, 258);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 28);
            this.btnLogin.TabIndex = 4;
>>>>>>> cbab1c947f6bd2503e73d3f8dfbd417328f21375
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // ForgotLnk
            // 
<<<<<<< HEAD
            this.ForgotLnk.ActiveLinkColor = System.Drawing.Color.Green;
            this.ForgotLnk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForgotLnk.AutoSize = true;
            this.ForgotLnk.BackColor = System.Drawing.Color.Transparent;
            this.ForgotLnk.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotLnk.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ForgotLnk.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.ForgotLnk.Location = new System.Drawing.Point(309, 350);
            this.ForgotLnk.Name = "ForgotLnk";
            this.ForgotLnk.Size = new System.Drawing.Size(117, 19);
            this.ForgotLnk.TabIndex = 9;
            this.ForgotLnk.TabStop = true;
            this.ForgotLnk.Text = "Forgot password?";
            this.ForgotLnk.VisitedLinkColor = System.Drawing.Color.Green;
=======
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(178, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "AGRISIM ADMIN";
>>>>>>> cbab1c947f6bd2503e73d3f8dfbd417328f21375
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = " Sign up here!";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 625);
            this.Controls.Add(this.LoginPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
=======
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> cbab1c947f6bd2503e73d3f8dfbd417328f21375
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPnl.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< HEAD
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.LinkLabel ForgotLnk;
        private System.Windows.Forms.Panel LoginPnl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label Title;
=======

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
>>>>>>> cbab1c947f6bd2503e73d3f8dfbd417328f21375
    }
}

