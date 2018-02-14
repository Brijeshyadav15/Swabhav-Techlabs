using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BookmarkCore
{
    class BookmarksLoader
    {
        public List<Bookmark> LoadBookmarks(int userId)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand selectBookmarks = new SqlCommand("Select * from Bookmarks where userId =" + userId + "", conn);
            conn.Open();
            List<Bookmark> result = new List<Bookmark>();
            var tempresult = selectBookmarks.ExecuteReader();

            while (tempresult.Read())
            {
                if (tempresult[0] != null)
                {
                    result.Add(new Bookmark(Convert.ToInt32(tempresult[0]), tempresult[1].ToString(), Convert.ToInt32(tempresult[2]), Convert.ToDateTime(tempresult[3]), tempresult[4].ToString()));
                }
            }
            return result;
        }
    }
}
