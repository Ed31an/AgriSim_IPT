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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Searchbar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DashBoardBttn_Click(object sender, EventArgs e)
        {
            DashBoardBttn.FillColor = Color.FromArgb(82, 182, 154);
            OverviewBttn.FillColor = Color.DarkSlateGray;
            SettingBttn.FillColor = Color.DarkSlateGray;
        }

        private void OverviewBttn_Click(object sender, EventArgs e)
        {
            OverviewBttn.FillColor = Color.FromArgb(82, 182, 154);
            DashBoardBttn.FillColor = Color.DarkSlateGray;
            SettingBttn.FillColor = Color.DarkSlateGray;
        }

        private void SettingBttn_Click(object sender, EventArgs e)
        {
            SettingBttn.FillColor = Color.FromArgb(82, 182, 154);
            DashBoardBttn.FillColor = Color.DarkSlateGray;
            OverviewBttn.FillColor = Color.DarkSlateGray;
        }

        private void LogoutBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
