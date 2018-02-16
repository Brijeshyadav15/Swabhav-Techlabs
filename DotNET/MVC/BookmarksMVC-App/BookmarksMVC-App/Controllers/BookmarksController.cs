using System;
using System.Web.Mvc;
using BookmarksMVC_App.ViewModel;
using BookmarkCore;
using System.Globalization;

namespace BookmarksMVC_App.Controllers
{
    public class BookmarksController : Controller
    {
        public ActionResult AddBookmarks()
        {
               if (Session["UserId"] == null)
                return RedirectToAction("Index", "User", new { Area = "" });

            AddBookmarksViewModel abvm = new AddBookmarksViewModel();
            return View(abvm);
        }

        public ActionResult ShowBookmarks()
        {
            if (Session["UserId"] == null)
                return RedirectToAction("Index", "User", new { Area = "" });

            BookmarkService svc = new BookmarkService();
            Session["UserName"] = svc.GetUser(Convert.ToInt32(Session["UserId"]));
            var tempBookmarks = svc.LoadBookmarks(Convert.ToInt32(Session["UserId"]));

            ShowBookmarksViewModel sbvm = new ShowBookmarksViewModel();
            sbvm.Bookmarks = tempBookmarks;

            return View(sbvm);
        }

        [HttpPost]
        public ActionResult AddBookmarks(AddBookmarksViewModel abvm)
        {
            if (abvm.Name == null || abvm.URL == null)
                return View(abvm);
            else
            {
                BookmarkService svc = new BookmarkService();
                var temptoday = DateTime.ParseExact(DateTime.Now.ToString("YYYY-MM-DD"), "YYYY-MM-DD", CultureInfo.InvariantCulture);
                svc.AddBookmarks(abvm.Name, abvm.URL, Convert.ToInt32(Session["UserId"]), temptoday);
                return RedirectToAction("ShowBookmarks");
            }
        }
    }
}