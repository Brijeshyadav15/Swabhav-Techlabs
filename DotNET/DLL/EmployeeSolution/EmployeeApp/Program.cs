using System;
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
                DOB = Convert.ToDateTime("1996/01/15")
            };
            printDetails(developer);

            var manager = new Manager
            {
                Name = "Akaash",
                Desgination = "Manager",
                Basic = 15000,
                DOB = Convert.ToDateTime("1994/05/15")
            };
            printDetails(manager);
        }

        private static void printDetails(Employee employee)
        {
            Console.WriteLine("Employee Name :" + employee.Name);
            Console.WriteLine("Employee Designation :" + employee.Desgination);
            Console.WriteLine("Employee Dob :" + employee.DOB);
            Console.WriteLine("Employee Basic :" + employee.Basic);
            Console.WriteLine("Employee PA :" + employee.Pa);

            if (employee.GetType().Equals(typeof(Manager)))
            {
                Console.WriteLine("Employee HRA :" + employee.HRA);
            }

            Console.WriteLine("Employee Salary :" + employee.CalculateSalary());
            Console.WriteLine("Employee Age :" + employee.CalculateAge());
            Console.WriteLine();
        }
    }
}
