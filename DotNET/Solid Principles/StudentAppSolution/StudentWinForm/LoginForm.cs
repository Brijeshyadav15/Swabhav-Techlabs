using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentCore;

namespace StudentWinForm
{
    public partial class LoginForm : Form
    {
        private static string _username = "";

        public String Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginService loginservice = new LoginService();
            if (loginservice.checkLogin(txtUser.Text, txtPassword.Text))
            {
                new LoginForm().Username = txtUser.Text;
                Form MDI = (Form)Application.OpenForms["MDIForm"];
                MenuStrip menu = (MenuStrip)MDI.Controls["menuStrip1"];
                menu.Items.Remove(menu.Items.Find("mnuLogin", true)[0]);
                menu.Items.Find("mnuAdd", true)[0].Enabled = true;
                menu.Items.Find("mnuDisplay", true)[0].Enabled = true;
                menu.Items.Find("mnuSearch", true)[0].Enabled = true;
                menu.Items.Find("mnuLogout", true)[0].Enabled = true;
                this.Visible = false;
                MainForm mainform = new MainForm();
                mainform.MdiParent = this.ParentForm;
                mainform.Dock = DockStyle.Fill;
                mainform.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username/Password");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
