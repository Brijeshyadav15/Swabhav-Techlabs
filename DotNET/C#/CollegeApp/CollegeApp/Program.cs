using System;

namespace CollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            caseStudyonStudent();

            caseStudyonProfessor();
        }

        private static void caseStudyonProfessor()
        {
            Professor professor = new Professor(2, "Delhi", Convert.ToDateTime("15/02/1976"), 5000);

            Console.WriteLine(professor.Id + "\t" + professor.Address + "\t" + "\t" + professor.Dob + "\t"
                + professor.CalculateSalary());
        }

        private static void caseStudyonStudent()
        {
            Student student = new Student(1, "Mumbai", Convert.ToDateTime("15/02/1996"),
                            Branch.CIVIL);

            Console.WriteLine(student.Id + "\t" + student.Address + "\t" + "\t" + student.Dob + "\t" + student.Branch);
        }
    }
}
