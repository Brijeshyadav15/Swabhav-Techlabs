﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.MdiParent = this.ParentForm;
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BookmarkService service = new BookmarkService();
            var email = UsernameTxt.Text;
            var password = PasswordTxt.Text;
            var result = service.CheckLogin(email, password);
            if (result != null)
            {
                ShowBookmark bookmarks = new ShowBookmark(Convert.ToInt32(result));
                bookmarks.MdiParent = this.ParentForm;
                this.Hide();
                bookmarks.Show();
            }
        }
    }
}
