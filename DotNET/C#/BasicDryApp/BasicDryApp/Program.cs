using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicDryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dry d = new Dry();
            d.Username = "Brijesh";
            d.Password = "123456";
            Console.WriteLine(d.emaillogin());

            d.Username = "Akash";
            d.Password = "65321";
            Console.WriteLine(d.fblogin());
            d.ShowUser();
        }
    }
}
