using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentSerializeApp
{
    class StudentConsole
    {

        private static int ADD_CHOICE = 1;
        private static int DISPLAY_CHOICE = 2;
        private static int SEARCH_STUDENT_CHOICE = 3;
        private static int DELETE_STUDENT_CHOICE = 4;
        private static int EXPORT_TO_HTML = 5;
        IStudentStore studentobj;

        public StudentConsole(IStudentStore obj)
        {
            studentobj = obj;
        }

        public void Start()
        {

            Console.WriteLine("Press 1 to add Student");
            Console.WriteLine("Press 2 to Display Students");
            Console.WriteLine("Press 3 to Search Student By Name");
            Console.WriteLine("Press 4 to Delete Student");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GetDetails();
                    break;
                case 2:
                    Print(studentobj.Get());
                    break;
                case 3:
                    Search();
                    break;
                case 4:
                    Delete();
                    break;
            }

        }

        public void GetDetails()
        {
            List<Student> studentlist = new List<Student>();

            do
            {
                Console.WriteLine("Enter Student Id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Name: ");
                String name = Console.ReadLine();

                Console.WriteLine("Enter Student Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Location: ");
                String location = Console.ReadLine();



                Student student = new Student(id, name, age, location);
                ((IStudentStore)studentobj).Add(student);

                Console.WriteLine("Thank You !! Your details are being saved.");
                Console.WriteLine("Press 1 to add more Student");
                Console.WriteLine("Any Other number to exit");

            } while (Convert.ToInt32(Console.ReadLine()) == ADD_CHOICE);
            Start();
        }

        public void Print(List<Student> list)
        {
            foreach (Student student in list)
            {
                Console.WriteLine("Student Id:" + student.Id);
                Console.WriteLine("Student Name:" + student.Name);
                Console.WriteLine("Student Age:" + student.Age);
                Console.WriteLine("Student Location:" + student.Location + "\n");
            }
        }

        public void Search()
        {
            Console.WriteLine("Enter Student Name :");
            Student result = studentobj.Search(Console.ReadLine());


            Console.WriteLine("Student ID:" + result.Id);
            Console.WriteLine("Student Name:" + result.Name);
            Console.WriteLine("Student Age:" + result.Age);
            Console.WriteLine("Student Location:" + result.Location);
        }

        private void Delete()
        {
            Console.WriteLine("Enter Student Id to delete:");
            Console.WriteLine(studentobj.Delete(Convert.ToInt64(Console.ReadLine())));
        }
    }
}
