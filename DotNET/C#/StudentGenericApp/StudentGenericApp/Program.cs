using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            caseStudyOne();
        }

        private static void caseStudyOne()
        {
            HashSet<StudentGeneric> students = new HashSet<StudentGeneric>();

            StudentGeneric student1 = new StudentGeneric(4, 14, "Brijesh");
            StudentGeneric student2 = new StudentGeneric(4, 15, "Aakash");
            students.Add(student1);
            students.Add(student2);

            foreach (StudentGeneric student in students)
            {
                Console.WriteLine(student.Std);
                Console.WriteLine(student.RollNo);
                Console.WriteLine(student.Name);
            }
        }
    }
}
