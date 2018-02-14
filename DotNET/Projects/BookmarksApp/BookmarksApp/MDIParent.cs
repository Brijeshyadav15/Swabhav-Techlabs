using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookmarksApp
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
            InitializeComponent();
        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            AddBookmark ab = new AddBookmark();
            ab.MdiParent = this;
            ab.Show();
        }

        private void showMenu_Click(object sender, EventArgs e)
        {
            ShowBookmark sb = new ShowBookmark(0);
            sb.MdiParent = this;
            sb.Show();
        }

        private void loginMenu_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void registerMenu_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.MdiParent = this;
            register.Show();
        }
    }
}
