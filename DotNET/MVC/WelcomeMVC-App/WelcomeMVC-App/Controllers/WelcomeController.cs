using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVC_App.Controllers
{
    public class WelcomeController : Controller
    {
        public string SayHello()
        {
            return "<h1>H1 says MVC Action Method</h1>";
        }

        public ActionResult GetDept(Nullable<int> id)
        {

            return Content("<h1>Display Employee in Dept No " + id + "</h1>");
        }

        public ActionResult GetStudent(int rollNo)
        {
            return Content("<h1>Display Student in Dept No " + rollNo + "</h1>");
        }
        //public ActionResult Index()
        //{

        //    return View();
        //}

        public ActionResult Index()
        {
            ViewData["Username"] = "Brijesh";
            ViewBag.Username = "Akash";

            ViewData["Username"] = "Jay";
            ViewData["Username"] = "Akash";

            ViewData["Username"] = "Jay";
            ViewData["Username"] = "Akash";

            return View();
        }
    }
}