using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_GMS;
namespace GUI_GMS
{
    public partial class GUI_Login : Form
    {
        BUS_User busUser = new BUS_User();
        public GUI_Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.ToString();
            string pass = txtPass.Text.ToString();
            if (busUser.ktdn(user, pass) == true)
            {
                Luu.KT = !Luu.KT;
                MessageBox.Show("login successful", "Attention");
                Close();
            }
            else
            {
                MessageBox.Show("Username or Password is not correct !", "Attention");
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
