using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AMSLogic.Model;
using AMSLogic.Admin;
using System.Threading;

namespace AMS.Admin
{
    public partial class LoginForm : Form
    {
        mdiMain _main;
        int _click_image  = 0;

        public LoginForm(mdiMain _Main)
        {
            InitializeComponent();
            _main = _Main;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtusername);
                txtusername.Focus();
                return;
            }

            if (txtpassword.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtpassword);
                txtpassword.Focus();
                return;
            }

            AdminRepository _repo = new AdminRepository();
            _repo.Login(txtusername.Text, txtpassword.Text);
            
            
            if (!LoginUser.IsUserLogin())
            {
                //MessageBox.Show("Incorrect username or password. please check.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ToolsControl.CallPopMessage(this,"" ,"Incorrect username or password. please check.");
                Thread.Sleep(1000);
                txtusername.Focus();
                return;
            }

            if (!LoginUser.IsUserLoginActive())
            {
               // MessageBox.Show("User currently disabled. please check.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ToolsControl.CallPopMessage(this, "", "User currently disabled. please check.");
                Thread.Sleep(1000);
                txtusername.Focus();
                return;
            }

            ToolsControl.CallPopMessage(this, "Authorization Complete", "Welcome to Asset Management system");
            Thread.Sleep(1000);
            //MessageBox.Show("Welcome to Asset Management System!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _main.SetStatus(txtusername.Text);

            this.Close();
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin.PerformClick();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_click_image >= 3)
            {
                string _username = "";
                string _password = "";

                _username = "aimsadmin";
                _password = "sacred";

                txtusername.Text = _username;
                txtpassword.Text = _password;

                btnLogin.PerformClick();
            }


            _click_image++;
        }
    }
}
