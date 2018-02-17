using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestFilterApp.ViewModel;

namespace TestFilterApp.Controllers
{
    public class DropController : Controller
    {
        public ActionResult Index()
        {
            List<Dept> depts = new List<Dept>();
            depts.Add(new Dept(1, "IT"));
            depts.Add(new Dept(3, "Computer"));
            depts.Add(new Dept(4, "CIVILS"));
            depts.Add(new Dept(2, "EC"));
            depts.Add(new Dept(5, "MECH"));

            var deptlist = new List<SelectListItem>();
            foreach (var d in depts)
            {
                deptlist.Add(new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Name
                });
            }
            DropDownViewModel ddvm = new DropDownViewModel();
            ddvm.Departments = deptlist;
            return View(ddvm);
        }

        [HttpPost]
        public ActionResult Index(int deptNum)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee(1, "Brijesh",1));
            emp.Add(new Employee(2, "Akash", 3));
            emp.Add(new Employee(3, "Kannan", 4));
            emp.Add(new Employee(4, "Mayur", 2));
            emp.Add(new Employee(5, "Raj", 3));
            emp.Add(new Employee(6, "Vivek", 4));
            emp.Add(new Employee(7, "Akshay", 2));

            var result = emp.Where(e => e.DeptNo == deptNum);
            return Json(result);
        }
    }
}