using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestFilterApp.ViewModel
{
    public class DropDownViewModel
    {
        public IEnumerable<System.Web.Mvc.SelectListItem> Departments
        {
            get;
            set;
        }


    }
}