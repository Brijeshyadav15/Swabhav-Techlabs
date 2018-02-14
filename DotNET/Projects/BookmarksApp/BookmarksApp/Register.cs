using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookmarkCore;

namespace BookmarksApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            BookmarkService service = new BookmarkService();
            var name = txtName.Text;
            var email = txtEmail.Text;
            service.AddUser(name,email);
            MessageBox.Show("Registration Successfull. Please Email for Password");

            Login login = new Login();
            login.MdiParent = this.ParentForm;
            this.Visible = false;
            login.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
