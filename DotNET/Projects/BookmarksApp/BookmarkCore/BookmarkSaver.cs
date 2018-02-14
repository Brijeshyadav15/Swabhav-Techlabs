using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BookmarkCore
{
    class BookmarkSaver
    {
        public void AddBookmark(string name, string url, int userId, DateTime date)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand insertCommand = new SqlCommand("Insert into Bookmarks Values('" + name + "','" + userId + "','" + date + "','" + url + "')", conn);
            //insertCommand.Parameters.AddWithValue("@id", id);
            //insertCommand.Parameters.AddWithValue("@name", name);
            //insertCommand.Parameters.AddWithValue("@userId", userId);
            //insertCommand.Parameters.AddWithValue("@url", url);
            //insertCommand.Parameters.AddWithValue("@date", date);
            conn.Open();
            insertCommand.ExecuteNonQuery();
        }
    }
}
