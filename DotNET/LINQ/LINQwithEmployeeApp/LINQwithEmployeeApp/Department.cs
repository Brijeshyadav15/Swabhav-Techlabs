using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQwithEmployeeApp
{
    class Department
    {
        private int _deptid;
        private string _name;
        private string _location;

        public Department(int deptid, string name, string location)
        {
            _deptid = deptid;
            _name = name;
            _location = location;
        }

        public int DeptId
        {
            get { return _deptid; }
            set { _deptid = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

    }
}
