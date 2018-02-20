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
        private int _id;
        public MDIParent()
        {
            InitializeComponent();
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            AddBookmark ab = new AddBookmark(Id);
            ab.MdiParent = this;
            ab.WindowState = FormWindowState.Maximized;
            ab.Show();
        }

        private void showMenu_Click(object sender, EventArgs e)
        {
            ShowBookmark sb = new ShowBookmark(Id);
            sb.MdiParent = this;
            sb.WindowState = FormWindowState.Maximized;
            sb.Show();
        }

        private void loginMenu_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }

        private void registerMenu_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.MdiParent = this;
            register.WindowState = FormWindowState.Maximized;
            register.Show();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
