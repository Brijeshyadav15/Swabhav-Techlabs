using EmployeeMVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace EmployeeMVC_App
{
    public class EmployeeService
    {

        private static List<Employee> _employees = new List<Models.Employee>();

        static EmployeeService()
        {
            _employees.Add(new Models.Employee(1, "Brijesh", 10));
            _employees.Add(new Models.Employee(3, "Akash", 30));
            _employees.Add(new Models.Employee(2, "Himanshu", 20));
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public Employee Get(int id)
        {
            return _employees.Single(e => e.Id == id);
        }

        public void Update(Employee emp)
        {
            _employees.RemoveAll(e => e.Id == emp.Id);
            _employees.Add(emp);
        }

        public void Delete(int id)
        {
            _employees.RemoveAll(e => e.Id == id);
        }

        public void Add(Employee emp)
        {
            _employees.Add(emp);
        }
    }
}