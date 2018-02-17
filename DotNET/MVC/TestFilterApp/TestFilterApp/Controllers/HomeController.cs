using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestFilterApp.AuthData;
using TestFilterApp.Filters;

namespace TestFilterApp.Controllers
{

    public class HomeController : Controller
    {
        [CustomActionFilter]
        public ActionResult Index()
        {
            return View();
        }

        [CustomActionFilter]
        public ActionResult About()
        {
            return View();
        }

        [CustomActionFilter]
        public ActionResult ClickMe()
        {
            TempData["Clicked"] = true;
            return RedirectToAction("Index");
        }


    }
}