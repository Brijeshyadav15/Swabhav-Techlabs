using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BookmarkCore
{
    class UserLogin
    {
        public String CheckLogin(string email, string password)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand selectBookmarks = new SqlCommand("Select * from BookMarkUsers where email = '" + email + "' and password = '" + password + "'", conn);
            conn.Open();

            SqlDataReader reader = selectBookmarks.ExecuteReader();
            while (reader.Read())
            {
                if (email == reader[1].ToString() && password == reader[2].ToString())
                {
                    return reader[3].ToString();
                }
            }
            return null;
        }

        public String GetUser(int id)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand selectBookmarks = new SqlCommand("Select * from BookMarkUsers where id = " + id + "", conn);
            conn.Open();

            SqlDataReader reader = selectBookmarks.ExecuteReader();
            while (reader.Read())
            {
                return reader[0].ToString();
            }
            return null;
        }
    }
}
