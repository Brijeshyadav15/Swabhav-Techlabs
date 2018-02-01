using System;
using System.Collections.Generic;
using System.Reflection;

namespace AttributeFinderApp
{
    class Employee
    {
        private int _id;
        private String _name;
        private String _desg;
        private String _reportingId;
        private DateTime _dob;
        private int _salary;
        private String _da;
        private String _department;
        private List<Employee> _reportees;

        public Employee(int id, String name, String desg, String reportingid,
            DateTime dob, int salary, String da, String department)
        {
            _id = id;
            _name = name;
            _desg = desg;
            _reportingId = reportingid;
            _dob = dob;
            _salary = salary;
            _da = da;
            _department = department;
            _reportees = new List<Employee>();

        }

        [NeedRefactoring]
        public int Id
        {
            get
            {
                return _id;
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }
        public String Desg
        {
            get
            {
                return _desg;
            }
        }
        public String ReportingId
        {
            get
            {
                return _reportingId;
            }
        }
        public DateTime Dob
        {
            get
            {
                return _dob;
            }
        }

        public int Salary
        {
            get
            {
                return _salary;
            }
        }
        public String Da
        {
            get
            {
                return _da;
            }
        }
        public String Department
        {
            get
            {
                return _department;
            }
        }

        public List<Employee> GetReportees()
        {
            return _reportees;
        }

        [NeedRefactoring]
        public void addReportee(Employee employee)
        {
            _reportees.Add(employee);
        }


        public override String ToString()
        {
            return Id + " " + Name + " " + Desg + " " + Dob
                + " " + Salary + " " + Department;
        }

    }

    public class NeedRefactoring : Attribute
    {
        public string Property { get; set; }
    }
}
