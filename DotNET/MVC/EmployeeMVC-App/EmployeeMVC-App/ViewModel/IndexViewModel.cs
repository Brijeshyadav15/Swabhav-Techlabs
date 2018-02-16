using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMVC_App.ViewModel
{
    public class IndexViewModel
    {
        public List<Models.Employee> Employees
        {
            get;
            set;
        }
    }
}