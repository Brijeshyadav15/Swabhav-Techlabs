using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRepository_App
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository repo = new StudentRepository(new HiTechDbContext());
            //repo.Add(new Student(Guid.NewGuid(), "Brijesh", "Yadav", 22, "Mumbai", 8.4));
            //repo.Add(new Student(Guid.NewGuid(), "Akash", "Malaviya", 23, "Ahmedabad", 6.4));

            //repo.Add(new Student(Guid.NewGuid(), "Raj", "NNNNN", 22, "Mumbai", 8.4));
            //repo.Add(new Student(Guid.NewGuid(), "Akshay", "PPPP", 23, "Mumbai", 6.4));

            IEnumerable<Student> students = repo.Get().Where(s => s.FirstName.Length > 6).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine("Name :" + student.FirstName + student.LastName + " CGPA :" + student.CGPA);
            }

            IQueryable<Student> CGPAquery = repo.Find(s => s.CGPA > 7);

            IQueryable<Student> top3 = CGPAquery.Take(3);

            IQueryable<Student> findStudents = top3.Select(s => new  {full  = s.FirstName + s.LastName });

        }
    }
}
