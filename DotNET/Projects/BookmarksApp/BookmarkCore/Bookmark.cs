using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookmarkCore
{
    public class Bookmark
    {
        private int _id;
        private string _name;
        private int _userId;
        private DateTime _date;
        private string _url;

        public Bookmark(int id, string name, int userId, DateTime date, string url)
        {
            _id = id;
            _name = name;
            _userId = userId;
            _date = date;
            _url = url;
        }

        public int Id
        {
            get
            {
                return _id;
            }

        }

        public string Name
        {
            get { return _name; }
        }

        public string URL
        {
            get { return _url; }
        }

        public int UserID
        {
            get { return _userId; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

    }
}
