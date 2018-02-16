using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMVC_App.Models
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

        [Required]
        public int DeptNo
        {
            get { return _deptNo; }
            set { _deptNo = value; }
        }


        [Required]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [Required]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}