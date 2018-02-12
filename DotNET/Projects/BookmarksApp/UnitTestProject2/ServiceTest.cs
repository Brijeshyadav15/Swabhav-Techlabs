using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookmarkCore;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BookmarksApp
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void Should_Insert_User_into_DB()
        {
            //ACT
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            var id = 5;
            BookmarkService service = new BookmarkService();
            service.AddUser(id, "Brijesh", "brijeshyadav152@gmail.com");

            //Arrange
            SqlCommand insertCommand = new SqlCommand("Select id from BookMarkUsers where id =" + id + "", conn);
            conn.Open();

            var reader1 = insertCommand.ExecuteReader();
            var retrievedId = 0;

            while (reader1.Read())
            {
                retrievedId = Convert.ToInt32(reader1[0]);
            }

            //Assert
            Assert.AreEqual(id, retrievedId);
        }

    }
}
