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
    public partial class ChangePassword : Form
    {
        private int _id;

        public ChangePassword(int id)
        {
            
            _id = id;
            InitializeComponent();
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            BookmarkService service = new BookmarkService();
            lblHello.Text += service.GetUser(Id);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNew.Text == txtConfirm.Text)
            {
                BookmarkService service = new BookmarkService();
                var message = service.ChangePassword(Id, txtOld.Text, txtNew.Text);
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("New Password and Confirm Password does not match");
            }
        }
    }
}
