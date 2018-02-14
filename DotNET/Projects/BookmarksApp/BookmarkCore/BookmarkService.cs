using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookmarkCore
{
    public class BookmarkService
    {
        public void AddUser(string name, string email)
        {
            UserSaver user = new UserSaver();
            user.AddUser(name, email);
        }

        public string CheckLogin(string email, string password)
        {
            UserLogin login = new UserLogin();
            var resutltLogin = login.CheckLogin(email, password);
            Console.WriteLine(resutltLogin);
            return resutltLogin;
        }

        public string GetUser(int id)
        {
            UserLogin login = new UserLogin();
            var resutltLogin = login.GetUser(id);
            return resutltLogin;
        }

        public void AddBookmarks(string name, string url, int userID, DateTime date)
        {
            BookmarkSaver saver = new BookmarkSaver();
            saver.AddBookmark(name, url, userID, date);
        }

        public List<Bookmark> LoadBookmarks(int userId)
        {
            BookmarksLoader saver = new BookmarksLoader();
            var result = saver.LoadBookmarks(userId);
            return result;
        }
    }
}
