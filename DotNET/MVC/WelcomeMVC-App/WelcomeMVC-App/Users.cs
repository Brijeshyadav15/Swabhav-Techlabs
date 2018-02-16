using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMVC_App
{
    public class Users
    {
        private string _username;

        public string Username
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
    }
}