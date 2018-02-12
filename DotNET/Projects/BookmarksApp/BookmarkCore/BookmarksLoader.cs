using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BookmarkCore
{
    class BookmarksLoader
    {
        public Object LoadBookmarks(int userId)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand selectBookmarks = new SqlCommand("Select * from Bookmarks where userId =@userId", conn);
            selectBookmarks.Parameters.AddWithValue("@userId", userId);
            conn.Open();
            return selectBookmarks.ExecuteReader();
        }
    }
}
