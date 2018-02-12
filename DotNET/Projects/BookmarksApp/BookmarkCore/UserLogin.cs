using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BookmarkCore
{
    class UserLogin
    {
        public  Object CheckLogin(string email, string password)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand selectBookmarks = new SqlCommand("Select * from BookMarkUsers where email = @email and password = @password", conn);
            selectBookmarks.Parameters.AddWithValue("@email", email);
            selectBookmarks.Parameters.AddWithValue("@password", password);
            conn.Open();
            SqlDataReader reader = selectBookmarks.ExecuteReader();
            while (reader.Read())
            {
                if (email == reader[0].ToString() && password == reader[3].ToString())
                {
                    return reader;
                }
            }

            return null;
        }
    }
}
