using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrisim
{
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection ("server=localhost;user=root;database=db_agrisim_admin;password= 123456789");
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=db_agrisim_admin;password=123456789"))
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_accounts WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Login successful!");
<<<<<<< HEAD
=======
                        dashboard dashboardform = new dashboard();
                        dashboardform.Show();
                        this.Hide();
                        // Proceed to the next form or main application
>>>>>>> cbab1c947f6bd2503e73d3f8dfbd417328f21375
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

<<<<<<< HEAD
        private void textBoxPassword_IconRightClick(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '•')
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.IconRight = global::Agrisim.Properties.Resources.eye_solid;
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxPassword.IconRight = global::Agrisim.Properties.Resources.eye_regular;
            }
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Visible = false;
=======
        private void label2_Click_1(object sender, EventArgs e)
        {
         
>>>>>>> cbab1c947f6bd2503e73d3f8dfbd417328f21375
        }
    }
}
