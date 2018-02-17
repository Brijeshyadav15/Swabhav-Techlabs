using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestFilterApp.ViewModel
{
    public class Employee
    {
        private int _id;
        private string _name;
        private int _deptNo;

        public Employee()
        {
            _id = 0;
            _name = null;
            _deptNo = 0;
        }

        public Employee(int id, string name, int dept)
        {
            _id = id;
            _name = name;
            _deptNo = dept;
        }

        public int DeptNo
        {
            get { return _deptNo; }
            set { _deptNo = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}



