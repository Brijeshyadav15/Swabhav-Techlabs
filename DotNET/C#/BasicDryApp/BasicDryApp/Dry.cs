using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicDryApp
{
    class Dry
    {
        private String _username;
        private String _password;
        private List<String> _user = new List<string>();

        public String Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public String Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public void AddUser(String username)
        {
            _user.Add(_username);
        }

        public void ShowUser()
        {
            foreach (String user in _user)
            {
                Console.WriteLine(user);
            }
        }

        public String emaillogin()
        {
            AddUser(Username);
            return "You are login through Email LOGIN Method";
        }

        public String fblogin()
        {
            AddUser(Username);
            return "You are login through FB LOGIN Method";
        }
    }
}
