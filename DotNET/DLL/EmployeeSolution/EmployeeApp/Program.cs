using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeLibrary;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var developer = new Developer
            {
                Name = "Brijesh",
                Desgination = "Developer",
                Basic = 5000,
                DOB = Convert.ToDateTime("1996/02/15")
            };
            printDetails(developer);

            var manager = new Manager
            {
                Name = "Akaash",
                Desgination = "Manager",
                Basic = 5000,
                HRA = 2500,
                DOB = Convert.ToDateTime("1994/05/15")
            };
            printDetails(manager);
        }

        private static void printDetails(Employee employee)
        {
            Console.WriteLine("Employee Name :" + employee.Name);
            Console.WriteLine("Employee Dob :" + employee.DOB);
            Console.WriteLine("Employee Basic :" + employee.Basic);
            Console.WriteLine("Employee PA :" + employee.Pa);
            Console.WriteLine("Employee HRA :" + employee.HRA);
            Console.WriteLine("Employee Salary :" + employee.CalculateSalary());
            Console.WriteLine("Employee Age :" + employee.CalculateAge());
            Console.WriteLine();
        }
    }
}
