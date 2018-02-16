using EmployeeMVC_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC_App.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeService svc = new EmployeeService();
            var TestEmployees = svc.GetEmployees();
            ViewModel.IndexViewModel vm = new ViewModel.IndexViewModel();
            vm.Employees = TestEmployees;
            return View(vm);
        }

        public ActionResult Edit(int id)
        {
            EmployeeService svc = new EmployeeService();
            var TempEmployee = svc.Get(id);

            EditViewModel vm = new EditViewModel();
            vm.Employee = TempEmployee;
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel vm)
        {
            if (vm.Employee.Id == 0 || vm.Employee.Name == null || vm.Employee.DeptNo == 0)
            {
                return View(vm);
            }
            else
            {
                EmployeeService svc = new EmployeeService();
                svc.Update(vm.Employee);
                return RedirectToAction("Index");
            }

        }

        public ActionResult Delete(int id)
        {
            EmployeeService svc = new EmployeeService();
            svc.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AddViewModel vm)
        {
            if (vm.Employee.Id == 0 || vm.Employee.Name == null || vm.Employee.DeptNo == 0)
            {
                return View(vm);
            }
            else
            {
                EmployeeService svc = new EmployeeService();
                svc.Add(vm.Employee);
                return RedirectToAction("Index");
            }

        }
    }
}