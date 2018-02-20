using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BookmarkCore
{
    public class UserPassword
    {

        public string ChangePassword(int id, string oldPassword, string newPassword)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand checkUserPassword = new SqlCommand("Select * from BookMarkUsers where id = " + id + "", conn);
            conn.Open();

            SqlDataReader reader = checkUserPassword.ExecuteReader();
            string userPassword = null;
            int rowsAffected = 0;

            while (reader.Read())
            {
                userPassword = reader[2].ToString();
            }

            if (userPassword == oldPassword)
            {
                SqlCommand changePassword = new SqlCommand("Update BookMarkUsers Set password = " + newPassword + " where id = " + id + "", conn);
                rowsAffected = changePassword.ExecuteNonQuery();
            }

            if (rowsAffected > 0)
                return "Password changed successfully";
            else
                return "Something went Wrong. Password cannot be changed ";
        }
    }
}
