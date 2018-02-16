using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMVC_App.ViewModel;

namespace EmployeeMVC_App.Controllers
{
    public class ApplicationController : Controller
    {
        public ActionResult Index()
        {
            if (System.Web.HttpContext.Current.Application["Count"] == null)
            {

                System.Web.HttpContext.Current.Application.Lock();
                System.Web.HttpContext.Current.Application["Count"] = 1;
                System.Web.HttpContext.Current.Application.UnLock();
            }

            SessionViewModel am = new SessionViewModel();
            am.OldValue = Convert.ToInt32(System.Web.HttpContext.Current.Application["Count"]);

            Session["Count"] = Convert.ToInt32(System.Web.HttpContext.Current.Application["Count"]) + 1;
            am.NewValue = Convert.ToInt32(System.Web.HttpContext.Current.Application["Count"]);
            return View(am);
        }
    }
}