using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentWinForm
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            menuStrip1.Items.Find("mnuAdd", true)[0].Enabled = false;
            menuStrip1.Items.Find("mnuDisplay", true)[0].Enabled = false;
            menuStrip1.Items.Find("mnuSearch", true)[0].Enabled = false;
            menuStrip1.Items.Find("mnuLogout", true)[0].Enabled = false;
            LoginForm loginform = new LoginForm();
            loginform.MdiParent = this;
            loginform.WindowState = FormWindowState.Maximized;
            loginform.Dock = DockStyle.Fill;
            loginform.Show();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.WindowState = FormWindowState.Maximized;
            loginform.MdiParent = this;
            loginform.Show();
        }

        private void mnuDisplay_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.MdiParent = this;
            mainForm.WindowState = FormWindowState.Maximized;
            mainForm.Dock = DockStyle.Fill;
            mainForm.Show();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            AddStudent studentForm = new AddStudent();
            studentForm.WindowState = FormWindowState.Maximized;
            studentForm.MdiParent = this;
            studentForm.Dock = DockStyle.Fill;
            studentForm.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            MDIForm_Load(this, null);
        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.WindowState = FormWindowState.Maximized;
            searchForm.MdiParent = this;
            searchForm.Dock = DockStyle.Fill;
            searchForm.Show();
        }
    }
}
