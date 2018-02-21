using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity_App
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDbContext emdbc = new EmployeeDbContext();

            //addDepartments(emdbc);
            //sortedByName(emdbc);
            //employeesByLower(emdbc);
            //CalculateCTC(emdbc);
            //EmpinDept10(emdbc);
            //EmpinDept10OR20(emdbc);
            //empNamedScott(emdbc);
            //startsWithA(emdbc);
            //endsWithN(emdbc);
            //empInScottsDept(emdbc);
            //distinctDepartments(emdbc);
            //hireDate(emdbc);
            //totalSalary(emdbc);
            //empCount(emdbc);
            //empsInDept10(emdbc);


            var ctc = emdbc.Employees.Select(e => new { e = e.Name, s = e.Salary, c = e.Commision, ctc = (e.Salary * 12) + (e.Commision * 12) }).ToList();
            var ctcTop3 = emdbc.Employees.OrderByDescending(e => ctc).Select(e => new { e = e.Name, s = e.Salary, c = e.Commision, ctc = (e.Salary * 12) + (e.Commision * 12) }).Take(3).ToList();
            foreach (var ct in ctcTop3)
                Console.WriteLine(String.Format("Name :{0} Salary : {1} Commision :{2} CTC:{3}", ct.e, ct.s, ct.c, ct.ctc));

            emdbc.SaveChanges();
        }

        private static void empsInDept10(EmployeeDbContext emdbc)
        {
            var deptNo10 = emdbc.Employees.Where(e => e.DeptId == 10).ToList();
            var empsin10 = deptNo10.Count();
            Console.WriteLine("Total Employee in Dept 10:" + empsin10);
        }

        private static void empCount(EmployeeDbContext emdbc)
        {
            var empsCount = emdbc.Employees.Count();
            Console.WriteLine("Total Employee :" + empsCount);
        }

        private static void totalSalary(EmployeeDbContext emdbc)
        {
            var ctc = emdbc.Employees.Select(e => new { e = e.Name, s = e.Salary, c = e.Commision, ctc = (e.Salary * 12) + (e.Commision * 12) }).ToList();
            var total = ctc.Sum(c => c.ctc);
            Console.WriteLine("Total Salary :" + total);
        }

        private static void hireDate(EmployeeDbContext emdbc)
        {
            var hiredate = emdbc.Employees.Select(e => new { e = e.HireDate }).ToList();
            foreach (var ct in hiredate)
                Console.WriteLine("Hire Date :" + ct.e);
        }

        private static void distinctDepartments(EmployeeDbContext emdbc)
        {
            var distinct = emdbc.Employees.Select(e => new { e = e.DeptId }).Distinct();

            foreach (var ct in distinct)
                Console.WriteLine("Dept Num :" + ct.e);
        }

        private static void empInScottsDept(EmployeeDbContext emdbc)
        {
            var scottDept = emdbc.Employees.First(f => f.Name.Equals("SCOTT")).DeptId;
            var deptOfScott = emdbc.Employees.Where(e => e.Id == scottDept).ToList();

            foreach (var ct in deptOfScott)
                Console.WriteLine(String.Format("Name :{0} Salary : {1} Deptartment Number :{2}", ct.Name, ct.Salary, ct.DeptId));
        }

        private static void endsWithN(EmployeeDbContext emdbc)
        {
            var endsWithN = emdbc.Employees.Where(e => e.Name.EndsWith("N"));
            foreach (var Employee in endsWithN)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.Id, Employee.Name, Employee.Manager, Employee.Job));
        }

        private static void startsWithA(EmployeeDbContext emdbc)
        {
            var startsWitha = emdbc.Employees.Where(e => e.Name.StartsWith("A")).ToList();
            foreach (var Employee in startsWitha)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.Id, Employee.Name, Employee.Manager, Employee.Job));
        }

        private static void empNamedScott(EmployeeDbContext emdbc)
        {
            var enameScott = emdbc.Employees.Single(e => e.Name == "SCOTT");
            Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", enameScott.Id, enameScott.Name, enameScott.Manager, enameScott.Job));
        }

        private static void EmpinDept10OR20(EmployeeDbContext emdbc)
        {
            var deptNoTT = emdbc.Employees.Where(e => e.DeptId == 10 || e.DeptId == 20);

            foreach (var Employee in deptNoTT)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.Id, Employee.Name, Employee.Manager, Employee.Job));
        }

        private static void EmpinDept10(EmployeeDbContext emdbc)
        {
            var deptNo = emdbc.Employees.Where(e => e.DeptId == 10).ToList();

            foreach (var dept in deptNo)
            {
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", dept.Id, dept.Name, dept.Manager, dept.Job));
            }
        }

        private static void CalculateCTC(EmployeeDbContext emdbc)
        {
            var ctc = emdbc.Employees.Select(e => new { e = e.Name, s = e.Salary, c = e.Commision, ctc = (e.Salary * 12) + (e.Commision * 12) }).ToList();
            foreach (var ct in ctc)
            {
                Console.WriteLine(String.Format("Name :{0} Salary : {1} Commision :{2} CTC:{3}", ct.e, ct.s, ct.c, ct.ctc));
            }
        }

        private static void employeesByLower(EmployeeDbContext emdbc)
        {
            var employeesByLower = emdbc.Employees.OrderBy(E => E.Name.ToLower()).ToList();
            foreach (var emp in employeesByLower)
            {
                Console.WriteLine("Employee Name :" + emp.Name.ToLower());
            }
        }

        private static void sortedByName(EmployeeDbContext emdbc)
        {
            var sortedByName = emdbc.Employees.OrderBy(e => e.Name).ToList();
            foreach (var emp in sortedByName)
            {
                Console.WriteLine("Employee Name :" + emp.Name);
            }
        }

        private static void addDepartments(EmployeeDbContext emdbc)
        {
            Department accounting = new Department(10, "ACCOUNTING", "NEW YORK");
            Department research = new Department(20, "RESEARCH", "DALLAS");
            Department sales = new Department(30, "SALES", "CHICAGO");
            Department operations = new Department(40, "OPERATIONS", "BOSTON");

            emdbc.Department.Add(accounting);
            emdbc.Department.Add(research);
            emdbc.Department.Add(sales);
            emdbc.Department.Add(operations);
        }
    }
}

