using EmployeeMVC_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC_App.Controllers
{
    public class SessionController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Count"] == null)
            {
                Session["Count"] = 1;
            }

            SessionViewModel sm = new SessionViewModel();
            sm.OldValue = Convert.ToInt32(Session["Count"]);

            Session["Count"] = Convert.ToInt32(Session["Count"]) + 1;
            sm.NewValue = Convert.ToInt32(Session["Count"]);
            
            return View(sm);
        }
    }
}