using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WelcomeAPI_App.Controllers
{
    public class LoginService
    {
        Dictionary<string, string> userData = new Dictionary<string, string>();

        public LoginService()
        {
            userData.Add("ADMIN", "ADMIN123");
            userData.Add("TIGER", "SCOTT");
            userData.Add("ADMIN123", "ADMIN@123");
            userData.Add("ALEX", "TIGER");
        }

        public bool checkLogin(String username, String password)
        {
            foreach (KeyValuePair<string, string> user in userData)
            {
                if (user.Key == username && user.Value == password)
                    return true;
            }
            return false;
        }
    }
}
