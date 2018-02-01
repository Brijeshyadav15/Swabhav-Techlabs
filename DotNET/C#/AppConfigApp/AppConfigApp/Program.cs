using System;
using System.Configuration;

namespace AppConfigApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            var title = ConfigurationManager.AppSettings["Title"];
            var language = ConfigurationManager.AppSettings["Language"];
            var worktype = ConfigurationManager.AppSettings["WorkType"];

            Console.WriteLine("Title :" + title);
            Console.WriteLine("Language :" + language);
            Console.WriteLine("WorkType :" + worktype);

            //var appSetting = ConfigurationManager.GetSection("appSettings");

            //foreach (var key in appSetting.AllKeys)
            //{
              //  Console.WriteLine(key + " = " + appSetting[key]);
            //}


        }
    }
}
