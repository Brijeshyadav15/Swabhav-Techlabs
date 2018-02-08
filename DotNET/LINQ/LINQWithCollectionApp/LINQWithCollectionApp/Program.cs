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
            List<Student> student = new List<Student> { new Student(1, "ABC", "XYZ", 7, "MUMBAI", 20), new Student(2, "DEF", "ZXY", 8, "MUMBAI", 21), new Student(3, "DEFGHI", "ZXY", 8, "MUMBAI", 22), new Student(4, "NOOEPW", "QWSZ", 10, "MUMBAI", 23), new Student(5, "QWER", "ABCD", 9, "MUMBAI", 23) };

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

            var TOP2 = student.OrderByDescending(s => s.CGPA).Take(2);

            foreach (var topper in TOP2)
            {
                Console.WriteLine(String.Format("First Name :{0} Last Name : {1} CGPA :{2}", topper.FirstName, topper.LastName, topper.CGPA));
            }

            var stud = student.First(s => s.Id == 1);

            Console.WriteLine("Student ID:" + stud.Id + " Student Name:" + stud.FirstName + " Student Name:" + stud.LastName);

            var averageAge = student.Average(s => s.Age);
            Console.WriteLine("Average Age of Students :" + averageAge);



        }
    }
}
