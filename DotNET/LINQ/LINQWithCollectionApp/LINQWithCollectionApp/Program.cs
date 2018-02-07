using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQWithCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student> { new Student(1, "ABC", "XYZ", 7, "MUMBAI", 20), new Student(2, "DEF", "ZXY", 8, "MUMBAI", 21), new Student(3, "DEFGHI", "ZXY", 8, "MUMBAI", 22), new Student(4, "NOOEPW", "QWSZ", 6, "MUMBAI", 23), new Student(5, "QWER", "ABCD", 6, "MUMBAI", 23) };

            var studentByAscendingOrderofFirstname = student.OrderBy(s => s.FirstName);

            foreach (var Student in studentByAscendingOrderofFirstname)
            {
                Console.WriteLine(String.Format("First Name :{0} Last Name : {1} Age :{2} CGPA :{3}", Student.FirstName, Student.LastName, Student.Age, Student.CGPA));

            }

            var FirstLastName = student.Select(s => new { f = s.FirstName, l = s.LastName });

            foreach (var name in FirstLastName)
            {
                Console.WriteLine(String.Format("First Name :{0} Last Name : {1}", name.f, name.l));
            }

        }
    }
}
