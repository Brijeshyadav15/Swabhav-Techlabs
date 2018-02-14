using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BookmarkCore;
using System.Windows.Forms;

namespace BookmarksApp
{
    public partial class ShowBookmark : Form
    {
        private int _id;
        public ShowBookmark(int userId)
        {
            _id = userId;
            InitializeComponent();
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }

        private void ShowBookmark_Load(object sender, EventArgs e)
        {
            BookmarkService service = new BookmarkService();
            lblHello.Text += service.GetUser(Id);
            gridBookmarks.DataSource = service.LoadBookmarks(Id);
            //gridBookmarks.DataBind();
        }
    }
}
