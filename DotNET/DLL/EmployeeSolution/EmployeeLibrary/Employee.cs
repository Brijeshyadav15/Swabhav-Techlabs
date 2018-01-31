using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeLibrary
{
    public abstract class Employee
    {
        private int _basic;

        public String Name
        {
            get;
            set;
        }

        public String Desgination
        {
            get;
            set;
        }

        public DateTime DOB
        {
            get;
            set;
        }


        public int Basic
        {
            get
            {
                return _basic;
            }
            set
            {
                _basic = value;
            }
        }

        public int Pa
        {
            get
            {
                return (Basic * 20) / 100; ;
            }
        }

        public int HRA
        {
            get;
            set;
        }

        public int CalculateAge()
        {
            int age;
            age = DateTime.Now.Year - DOB.Year;
            if (DateTime.Now.DayOfYear < DOB.DayOfYear)
                age = age - 1;

            return age;
        }

        public abstract int CalculateSalary();

    }
}
