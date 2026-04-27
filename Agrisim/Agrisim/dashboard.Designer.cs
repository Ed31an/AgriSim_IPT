using Org.BouncyCastle.Tls.Crypto;
using System.Web.UI.WebControls;

namespace Agrisim
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.temp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.TpCount = new System.Windows.Forms.Label();
            this.TotalPlayerLbl = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Title = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.AsCount = new System.Windows.Forms.Label();
            this.ActiveSessionLbl = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.TrCount = new System.Windows.Forms.Label();
            this.TotalrevLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Design = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ModeBttn = new Guna.UI2.WinForms.Guna2Button();
            this.NotifBttn = new Guna.UI2.WinForms.Guna2Button();
            this.Design1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LogoutBttn = new Guna.UI2.WinForms.Guna2Button();
            this.SettingBttn = new Guna.UI2.WinForms.Guna2Button();
            this.OverviewBttn = new Guna.UI2.WinForms.Guna2Button();
            this.DashBoardBttn = new Guna.UI2.WinForms.Guna2Button();
            this.Searchbar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Design)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Design1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel1.Location = new System.Drawing.Point(344, 179);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(805, 434);
            this.guna2Panel1.TabIndex = 0;
            // 
            // temp
            // 
            this.temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.temp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.temp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.temp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.temp.FillColor = System.Drawing.Color.DarkSlateGray;
            this.temp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.temp.ForeColor = System.Drawing.Color.White;
            this.temp.Location = new System.Drawing.Point(1012, 12);
            this.temp.Name = "temp";
            this.temp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.temp.Size = new System.Drawing.Size(36, 36);
            this.temp.TabIndex = 4;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.Controls.Add(this.TpCount);
            this.guna2Panel3.Controls.Add(this.TotalPlayerLbl);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel3.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(256, 113);
            this.guna2Panel3.TabIndex = 0;
            // 
            // TpCount
            // 
            this.TpCount.AutoSize = true;
            this.TpCount.Font = new System.Drawing.Font("Yu Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpCount.ForeColor = System.Drawing.Color.White;
            this.TpCount.Location = new System.Drawing.Point(3, 39);
            this.TpCount.Name = "TpCount";
            this.TpCount.Size = new System.Drawing.Size(30, 35);
            this.TpCount.TabIndex = 0;
            this.TpCount.Text = "0";
            // 
            // TotalPlayerLbl
            // 
            this.TotalPlayerLbl.AutoSize = true;
            this.TotalPlayerLbl.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPlayerLbl.ForeColor = System.Drawing.Color.White;
            this.TotalPlayerLbl.Location = new System.Drawing.Point(3, 7);
            this.TotalPlayerLbl.Name = "TotalPlayerLbl";
            this.TotalPlayerLbl.Size = new System.Drawing.Size(72, 16);
            this.TotalPlayerLbl.TabIndex = 0;
            this.TotalPlayerLbl.Text = "Total player";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.Design1);
            this.guna2Panel2.Controls.Add(this.LogoutBttn);
            this.guna2Panel2.Controls.Add(this.SettingBttn);
            this.guna2Panel2.Controls.Add(this.OverviewBttn);
            this.guna2Panel2.Controls.Add(this.DashBoardBttn);
            this.guna2Panel2.Controls.Add(this.Title);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.TopLeft = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(338, 625);
            this.guna2Panel2.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(65, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(125, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "AgriSim";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.Controls.Add(this.AsCount);
            this.guna2Panel4.Controls.Add(this.ActiveSessionLbl);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel4.Location = new System.Drawing.Point(273, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(256, 113);
            this.guna2Panel4.TabIndex = 0;
            // 
            // AsCount
            // 
            this.AsCount.AutoSize = true;
            this.AsCount.Font = new System.Drawing.Font("Yu Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsCount.ForeColor = System.Drawing.Color.White;
            this.AsCount.Location = new System.Drawing.Point(3, 39);
            this.AsCount.Name = "AsCount";
            this.AsCount.Size = new System.Drawing.Size(30, 35);
            this.AsCount.TabIndex = 0;
            this.AsCount.Text = "0";
            // 
            // ActiveSessionLbl
            // 
            this.ActiveSessionLbl.AutoSize = true;
            this.ActiveSessionLbl.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveSessionLbl.ForeColor = System.Drawing.Color.White;
            this.ActiveSessionLbl.Location = new System.Drawing.Point(3, 7);
            this.ActiveSessionLbl.Name = "ActiveSessionLbl";
            this.ActiveSessionLbl.Size = new System.Drawing.Size(86, 16);
            this.ActiveSessionLbl.TabIndex = 0;
            this.ActiveSessionLbl.Text = "Active session";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.Controls.Add(this.TrCount);
            this.guna2Panel5.Controls.Add(this.TotalrevLbl);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel5.Location = new System.Drawing.Point(543, 3);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(259, 113);
            this.guna2Panel5.TabIndex = 0;
            // 
            // TrCount
            // 
            this.TrCount.AutoSize = true;
            this.TrCount.Font = new System.Drawing.Font("Yu Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrCount.ForeColor = System.Drawing.Color.White;
            this.TrCount.Location = new System.Drawing.Point(3, 39);
            this.TrCount.Name = "TrCount";
            this.TrCount.Size = new System.Drawing.Size(30, 35);
            this.TrCount.TabIndex = 0;
            this.TrCount.Text = "0";
            // 
            // TotalrevLbl
            // 
            this.TotalrevLbl.AutoSize = true;
            this.TotalrevLbl.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalrevLbl.ForeColor = System.Drawing.Color.White;
            this.TotalrevLbl.Location = new System.Drawing.Point(3, 7);
            this.TotalrevLbl.Name = "TotalrevLbl";
            this.TotalrevLbl.Size = new System.Drawing.Size(83, 16);
            this.TotalrevLbl.TabIndex = 0;
            this.TotalrevLbl.Text = "Total revenue";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.66653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.0002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.66653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.0002F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.66653F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel5, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(344, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 119);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Design
            // 
            this.Design.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Design.ImageRotate = 0F;
            this.Design.Location = new System.Drawing.Point(348, 43);
            this.Design.Name = "Design";
            this.Design.Size = new System.Drawing.Size(513, 1);
            this.Design.TabIndex = 0;
            this.Design.TabStop = false;
            // 
            // ModeBttn
            // 
            this.ModeBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeBttn.BackColor = System.Drawing.Color.Transparent;
            this.ModeBttn.BorderRadius = 10;
            this.ModeBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ModeBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ModeBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ModeBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ModeBttn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.ModeBttn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ModeBttn.ForeColor = System.Drawing.Color.White;
            this.ModeBttn.Image = ((System.Drawing.Image)(resources.GetObject("ModeBttn.Image")));
            this.ModeBttn.Location = new System.Drawing.Point(958, 12);
            this.ModeBttn.Name = "ModeBttn";
            this.ModeBttn.Size = new System.Drawing.Size(36, 36);
            this.ModeBttn.TabIndex = 3;
            // 
            // NotifBttn
            // 
            this.NotifBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotifBttn.BackColor = System.Drawing.Color.Transparent;
            this.NotifBttn.BorderRadius = 10;
            this.NotifBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NotifBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NotifBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NotifBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NotifBttn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.NotifBttn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NotifBttn.ForeColor = System.Drawing.Color.White;
            this.NotifBttn.Image = ((System.Drawing.Image)(resources.GetObject("NotifBttn.Image")));
            this.NotifBttn.Location = new System.Drawing.Point(905, 12);
            this.NotifBttn.Name = "NotifBttn";
            this.NotifBttn.Size = new System.Drawing.Size(36, 36);
            this.NotifBttn.TabIndex = 3;
            // 
            // Design1
            // 
            this.Design1.FillColor = System.Drawing.Color.Transparent;
            this.Design1.ImageRotate = 0F;
            this.Design1.Location = new System.Drawing.Point(16, 59);
            this.Design1.Name = "Design1";
            this.Design1.ShadowDecoration.BorderRadius = 0;
            this.Design1.ShadowDecoration.Color = System.Drawing.Color.White;
            this.Design1.ShadowDecoration.Depth = 5;
            this.Design1.ShadowDecoration.Enabled = true;
            this.Design1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.Design1.Size = new System.Drawing.Size(307, 1);
            this.Design1.TabIndex = 0;
            this.Design1.TabStop = false;
            // 
            // LogoutBttn
            // 
            this.LogoutBttn.BorderRadius = 10;
            this.LogoutBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutBttn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.LogoutBttn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBttn.ForeColor = System.Drawing.Color.White;
            this.LogoutBttn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutBttn.Location = new System.Drawing.Point(16, 315);
            this.LogoutBttn.Name = "LogoutBttn";
            this.LogoutBttn.Size = new System.Drawing.Size(307, 61);
            this.LogoutBttn.TabIndex = 2;
            this.LogoutBttn.Text = "Logout";
            this.LogoutBttn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutBttn.Click += new System.EventHandler(this.LogoutBttn_Click);
            // 
            // SettingBttn
            // 
            this.SettingBttn.BorderRadius = 10;
            this.SettingBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingBttn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.SettingBttn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBttn.ForeColor = System.Drawing.Color.White;
            this.SettingBttn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingBttn.Location = new System.Drawing.Point(16, 239);
            this.SettingBttn.Name = "SettingBttn";
            this.SettingBttn.Size = new System.Drawing.Size(307, 61);
            this.SettingBttn.TabIndex = 2;
            this.SettingBttn.Text = "Setting";
            this.SettingBttn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingBttn.Click += new System.EventHandler(this.SettingBttn_Click);
            // 
            // OverviewBttn
            // 
            this.OverviewBttn.BorderRadius = 10;
            this.OverviewBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OverviewBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OverviewBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OverviewBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OverviewBttn.FillColor = System.Drawing.Color.DarkSlateGray;
            this.OverviewBttn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewBttn.ForeColor = System.Drawing.Color.White;
            this.OverviewBttn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OverviewBttn.Location = new System.Drawing.Point(16, 163);
            this.OverviewBttn.Name = "OverviewBttn";
            this.OverviewBttn.Size = new System.Drawing.Size(307, 61);
            this.OverviewBttn.TabIndex = 2;
            this.OverviewBttn.Text = "Overview";
            this.OverviewBttn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OverviewBttn.Click += new System.EventHandler(this.OverviewBttn_Click);
            // 
            // DashBoardBttn
            // 
            this.DashBoardBttn.BorderColor = System.Drawing.Color.Transparent;
            this.DashBoardBttn.BorderRadius = 5;
            this.DashBoardBttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashBoardBttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashBoardBttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashBoardBttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashBoardBttn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(182)))), ((int)(((byte)(154)))));
            this.DashBoardBttn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardBttn.ForeColor = System.Drawing.Color.White;
            this.DashBoardBttn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashBoardBttn.Location = new System.Drawing.Point(16, 87);
            this.DashBoardBttn.Name = "DashBoardBttn";
            this.DashBoardBttn.Size = new System.Drawing.Size(307, 61);
            this.DashBoardBttn.TabIndex = 1;
            this.DashBoardBttn.Text = "Dashboard";
            this.DashBoardBttn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashBoardBttn.Click += new System.EventHandler(this.DashBoardBttn_Click);
            // 
            // Searchbar
            // 
            this.Searchbar.BackColor = System.Drawing.Color.Transparent;
            this.Searchbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.Searchbar.BorderRadius = 1;
            this.Searchbar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchbar.DefaultText = "";
            this.Searchbar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchbar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchbar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.Searchbar.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.Searchbar.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.Searchbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Searchbar.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Searchbar.IconRight = ((System.Drawing.Image)(resources.GetObject("Searchbar.IconRight")));
            this.Searchbar.IconRightCursor = System.Windows.Forms.Cursors.Cross;
            this.Searchbar.Location = new System.Drawing.Point(344, 12);
            this.Searchbar.Name = "Searchbar";
            this.Searchbar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Searchbar.PlaceholderText = "Search";
            this.Searchbar.SelectedText = "";
            this.Searchbar.ShadowDecoration.BorderRadius = 0;
            this.Searchbar.ShadowDecoration.Depth = 10;
            this.Searchbar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Searchbar.Size = new System.Drawing.Size(517, 36);
            this.Searchbar.TabIndex = 1;
            this.Searchbar.WordWrap = false;
            this.Searchbar.TextChanged += new System.EventHandler(this.Searchbar_TextChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1161, 625);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Design);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.ModeBttn);
            this.Controls.Add(this.NotifBttn);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.Searchbar);
            this.Controls.Add(this.guna2Panel1);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Design)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Design1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox Searchbar;
        private Guna.UI2.WinForms.Guna2Button NotifBttn;
        private Guna.UI2.WinForms.Guna2Button ModeBttn;
        private Guna.UI2.WinForms.Guna2CircleButton temp;
        private Guna.UI2.WinForms.Guna2PictureBox Design;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label Title;
        private Guna.UI2.WinForms.Guna2Button DashBoardBttn;
        private Guna.UI2.WinForms.Guna2Button LogoutBttn;
        private Guna.UI2.WinForms.Guna2Button SettingBttn;
        private Guna.UI2.WinForms.Guna2Button OverviewBttn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TpCount;
        private System.Windows.Forms.Label TotalPlayerLbl;
        private System.Windows.Forms.Label ActiveSessionLbl;
        private System.Windows.Forms.Label TotalrevLbl;
        private System.Windows.Forms.Label AsCount;
        private System.Windows.Forms.Label TrCount;
        private Guna.UI2.WinForms.Guna2PictureBox Design1;
    }
}