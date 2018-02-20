using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntity_App
{
    class Program
    {
        static void Main(string[] args)
        {
            case1();
            case2();
            case3();
            case4();
            case5();
        }

        private static void case5()
        {
            HiTechDbContext db = new HiTechDbContext();
            var data = db.Students.Where(s => s.Name.Contains("a"))
                                  .Where(s => s.Age > 18)
                                  .ToList()
                                  .Select(s => new { n = s.Name.Split(' ')[0] , a = s.Age})
                                  .Take(2);


            foreach (var d in data)
                Console.WriteLine("Name : " + d.n + " Age :" + d.a);
        }

        private static void case4()
        {
            HiTechDbContext db = new HiTechDbContext();
            var data = db.Students.ToList()
                                  .Where(s => s.Name.Contains("a"))
                                  .Take(2);


            foreach (var d in data)
                Console.WriteLine("Name : " + d.Name + " Age :" + d.Age);
        }

        private static void case3()
        {
            HiTechDbContext db = new HiTechDbContext();
            var data = db.Students.Where(s => s.Name.Contains("a"))
                                  .Take(2)
                                  .ToList();

            foreach (var d in data)
                Console.WriteLine("Name : " + d.Name + " Age :" + d.Age);
        }

        private static void case1()
        {
            HiTechDbContext db = new HiTechDbContext();
            Student s = new Student(Guid.NewGuid(), "Brijesh", 22, "Gandhidham");
            Student s1 = new Student();
            s1.ID = Guid.NewGuid();
            s1.Name = "Akash";
            s1.Age = 23;
            s1.Location = "Ahmedabad";

            db.Students.Add(s);
            db.Students.Add(s1);
            db.SaveChanges();

            Console.WriteLine("Actions Performed");
        }

        private static void case2()
        {
            HiTechDbContext db = new HiTechDbContext();
            var data = db.Students.Select(s => new { n = s.Name, a = s.Age }).ToList();
            foreach (var d in data)
            {
                Console.WriteLine("Name : " + d.n + " Age :" + d.a);
            }


            var data1 = db.Students.Where(s => s.Name.Contains("s")).ToList();
            Console.WriteLine();
            Console.WriteLine("Students whose Name contains S");
            foreach (var d in data1)
            {
                Console.WriteLine("Name : " + d.Name + " Age :" + d.Age);
            }


            var data2 = db.Students.Where(s => s.Name.Equals("Akash")).ToList();
            Console.WriteLine("Students whose Name contains S");
            foreach (var d in data1)
            {
                Console.WriteLine("Name : " + d.Name + " Age :" + d.Age);
            }
        }
    }
}
