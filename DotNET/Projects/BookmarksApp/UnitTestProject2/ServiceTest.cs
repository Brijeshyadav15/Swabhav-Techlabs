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
        //[TestMethod]
        public void Should_Insert_User_into_DB()
        {
            //ACT
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            var id = 5;
            BookmarkService service = new BookmarkService();
            service.AddUser("Brijesh", "brijeshyadav152@gmail.com");

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

        //[TestMethod]
        public void Should_Send_Mail()
        {
            //ACT
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            UserSaver user = new UserSaver();
            user.SendRegisterMail("brijeshyadav152@gmail.com", "Brijesh", user.GeneratePassword(8));

            //Arrange         

            //Assert

        }


        //[TestMethod]
        public void Should_Login_User()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            BookmarkService service = new BookmarkService();
            var result = service.CheckLogin("brijeshyadav152@gmail.com", "NR7AN0YA");

            Assert.IsNotNull(result);
        }

        //[TestMethod]
        public void Should_Add_Bookmarks()
        {
            //ACT
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            var id = 1;
            BookmarkService service = new BookmarkService();
            service.AddBookmarks(id, "Google", "https://www.google.co.in/?gfe_rd=cr&dcr=0&ei=y4SBWpiHKqry8AeBvIqoAQ", 5, DateTime.Today);

            //Arrange
            SqlCommand insertCommand = new SqlCommand("Select id from Bookmarks where id =" + id + "", conn);
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

        [TestMethod]
        public void Should_Load_Bookmarks()
        {
            //ACT
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            var id = 5;
            BookmarkService service = new BookmarkService();
            var result = service.LoadBookmarks(id);

            Assert.IsNotNull(result);

        }

    }
}
