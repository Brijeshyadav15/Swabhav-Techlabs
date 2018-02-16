using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookmarksMVC_App.ViewModel;
using BookmarkCore;

namespace BookmarksMVC_App.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            if (Session["UserId"] != null)
                return RedirectToAction("Bookmarks", "ShowBookmarks", new { Area = "" });

            IndexViewModel ivm = new IndexViewModel();
            return View(ivm);
        }

        public ActionResult Register()
        {
            if (Session["UserId"] != null)
                return RedirectToAction("Bookmarks", "ShowBookmarks", new { Area = "" });

            RegisterViewModel rvm = new RegisterViewModel();
            return View(rvm);
        }

        public ActionResult Logout()
        {
            if (Session["UserId"] != null)
            {
                Session["UserId"] = null;
                Session["UserName"] = null;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel ivm)
        {
            if (ivm.Username == null || ivm.Password == null)
                return View(ivm);
            else
            {
                BookmarkService svc = new BookmarkService();
                var checkLogin = svc.CheckLogin(ivm.Username, ivm.Password);
                if (checkLogin != null)
                {
                    Session["UserId"] = checkLogin;
                    return RedirectToAction("ShowBookmarks", "Bookmarks", new { Area = "" });
                }
                return View(ivm);
            }
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel rvm)
        {
            if (rvm.Name == null || rvm.Email == null)
                return View(rvm);
            else
            {
                BookmarkService svc = new BookmarkService();
                svc.AddUser(rvm.Name, rvm.Email);
                return Content("<h3>Your Email Address has been registered. Please Check your Email Address for Password</h3>"); ;
            }
        }        

    }
}