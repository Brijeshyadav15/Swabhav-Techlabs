using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeCSV_App
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService emp = new EmployeeService();
            HashSet<Employee> employeeset = emp.GetEmployees();

            foreach (Employee employee in employeeset)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
