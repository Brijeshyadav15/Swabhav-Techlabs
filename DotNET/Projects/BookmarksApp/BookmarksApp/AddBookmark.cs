using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookmarkCore;
using System.Globalization;

namespace BookmarksApp
{
    public partial class AddBookmark : Form
    {
        private int _id;
        public AddBookmark(int id)
        {
            _id = id;
            InitializeComponent();
        }
        public int Id
        {
            get { return _id; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookmarkService service = new BookmarkService();
            var temptoday = DateTime.ParseExact(DateTime.Now.ToString("YYYY-MM-DD"), "YYYY-MM-DD", CultureInfo.InvariantCulture);
            service.AddBookmarks(txtName.Text, txtUrl.Text, Id, temptoday);

        }

        private void AddBookmark_Load(object sender, EventArgs e)
        {
        }
    }
}
