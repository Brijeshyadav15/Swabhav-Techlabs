using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQwithEmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> {
                            new Employee(7839, "KING", "PRESIDENT", 0, Convert.ToDateTime("17-NOV-81"), 5000, 0, 10),
                            new Employee(7698, "BLAKE", "MANAGER", 7839, Convert.ToDateTime("1-MAY-81"), 2850, 0, 30),
                            new Employee(7782, "CLARK", "MANAGER", 7839, Convert.ToDateTime("9-JUN-81"), 2450, 0, 10),
                            new Employee(7566, "JONES", "MANAGER", 7839, Convert.ToDateTime("2-APR-81"), 2975, 0, 20),
                            new Employee(7654, "MARTIN", "SALESMAN", 7698, Convert.ToDateTime("28-SEP-81"), 1250, 1400, 30),
                            new Employee(7499, "ALLEN", "SALESMAN", 7698, Convert.ToDateTime("20-FEB-81"), 1600, 300, 30),
                            new Employee(7844, "TURNER", "SALESMAN", 7698, Convert.ToDateTime("8-SEP-81"), 1500, 0, 30),
                            new Employee(7900, "JAMES", "CLERK", 7698, Convert.ToDateTime("3-DEC-81"), 950, 0, 30),
                            new Employee(7521, "WARD", "SALESMAN", 7698, Convert.ToDateTime("22-FEB-81"), 1250, 500, 30),
                            new Employee(7902, "FORD", "ANALYST", 7566, Convert.ToDateTime("3-DEC-81"), 3000, 0, 20),
                            new Employee(7369, "SMITH", "CLERK", 7902, Convert.ToDateTime("17-DEC-80"), 800, 0, 20),
                            new Employee(7788, "SCOTT", "ANALYST", 7566, Convert.ToDateTime("09-DEC-82"), 3000, 0, 20),
                            new Employee(7876, "ADAMS", "CLERK", 7788,Convert.ToDateTime("12-JAN-83"), 1100, 0, 20),
                            new Employee(7934, "MILLER", "CLERK", 7782, Convert.ToDateTime("23-JAN-82"), 1300, 0, 10)
                            };

            List<Department> departments = new List<Department>
                                        {
                                            new Department(10,"ACCOUNTING","NEW YORK"),
                                            new Department(20,"RESEARCH","DALLAS"),
                                            new Department(30,"SALES","CHICAGO"),
                                            new Department(40,"OPERATIONS","BOSTON")
                                        };

            //BasicQueries(employees);

            var enameDeptname = from e in employees
                                join d in departments on e.DeptNum equals d.DeptId
                                select new
                                {
                                    d.DeptId,
                                    d.Name,
                                    e.Ename,

                                };

            Console.WriteLine("Department Id\t Department Name\tEmployee Name");

            //foreach (var d in enameDeptname)
            //  Console.WriteLine(d.DeptId + "\t\t" + d.Name + "\t\t" + d.Ename);


            var deptname = from d in departments
                           join e in employees on d.DeptId equals e.DeptNum into ed
                           from eds in ed
                           select new
                           {
                               departname = d.Name,
                               employeename = eds.Ename != null ? eds.Ename : "No Employee"
                           };

            Console.WriteLine("Ename\t\t DName");
            foreach (var d in deptname)
                Console.WriteLine(d.departname + "\t\t" + d.employeename);

            var deptwithoutEmployee = from d in departments
                                      join e in employees on d.DeptId equals e.DeptNum into ed
                                      from eds in ed
                                      select new
                                      {
                                          departname = d.Name,
                                          employeename = eds.Ename != null ? eds.Ename : "No Employee"
                                      };





        }

        private static void BasicQueries(List<Employee> employees)
        {
            var employeesByAscendingOrderofFirstname = employees.OrderBy(E => E.Ename);

            var employeesByLower = employees.OrderBy(E => E.Ename.ToLower());

            foreach (var Employee in employeesByAscendingOrderofFirstname)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.EmpNo, Employee.Ename, Employee.MGR, Employee.Job));

            foreach (var Employee in employeesByLower)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.EmpNo, Employee.Ename, Employee.MGR, Employee.Job));

            var ctc = employees.Select(e => new { e = e.Ename, s = e.Sal, c = e.Comm, ctc = (e.Sal * 12) + (e.Comm * 12) });

            foreach (var ct in ctc)
                Console.WriteLine(String.Format("Name :{0} Salary : {1} Commision :{2} CTC:{3}", ct.e, ct.s, ct.c, ct.ctc));

            var deptNo = employees.Where(e => e.DeptNum == 10);

            foreach (var Employee in deptNo)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.EmpNo, Employee.Ename, Employee.MGR, Employee.Job));


            var deptNoTT = employees.Where(e => e.DeptNum == 10 || e.DeptNum == 20);

            foreach (var Employee in deptNoTT)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.EmpNo, Employee.Ename, Employee.MGR, Employee.Job));

            var enameScott = employees.Single(e => e.Ename == "SCOTT");
            Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", enameScott.EmpNo, enameScott.Ename, enameScott.MGR, enameScott.Job));

            var ctcTop3 = employees.OrderByDescending(e => ctc).Select(e => new { e = e.Ename, s = e.Sal, c = e.Comm, ctc = (e.Sal * 12) + (e.Comm * 12) }).Take(3);

            foreach (var ct in ctcTop3)
                Console.WriteLine(String.Format("Name :{0} Salary : {1} Commision :{2} CTC:{3}", ct.e, ct.s, ct.c, ct.ctc));

            var startsWitha = employees.Where(e => e.Ename.StartsWith("A"));

            foreach (var Employee in startsWitha)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.EmpNo, Employee.Ename, Employee.MGR, Employee.Job));

            var containsS = employees.Where(e => e.Ename.Contains("S"));
            foreach (var Employee in containsS)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.EmpNo, Employee.Ename, Employee.MGR, Employee.Job));


            var endsWithN = employees.Where(e => e.Ename.EndsWith("N"));

            foreach (var Employee in endsWithN)
                Console.WriteLine(String.Format("EMPNO :{0} Name : {1} Manager :{2} DESG :{3}", Employee.EmpNo, Employee.Ename, Employee.MGR, Employee.Job));

            var deptOfScott = employees.Where(e => e.DeptNum == employees.First(f => f.Ename.Equals("SCOTT")).DeptNum);

            foreach (var ct in deptOfScott)
                Console.WriteLine(String.Format("Name :{0} Salary : {1} Deptartment Number :{2}", ct.Ename, ct.Sal, ct.DeptNum));

            Console.WriteLine();


            var distinct = employees.Select(e => new { e = e.DeptNum }).Distinct();

            foreach (var ct in distinct)
                Console.WriteLine("Dept Num :" + ct.e);


            var hiredate = employees.Select(e => new { e = e.HireDate });
            foreach (var ct in hiredate)
                Console.WriteLine("Hire Date :" + ct.e);

            var total = ctc.Sum(c => c.ctc);
            Console.WriteLine("Total Salary :" + total);

            var empsCount = employees.Count();
            Console.WriteLine("Total Employee :" + empsCount);

            var empsin10 = deptNo.Count();
            Console.WriteLine("Total Employee in Dept 10:" + empsin10);
        }
    }
}
