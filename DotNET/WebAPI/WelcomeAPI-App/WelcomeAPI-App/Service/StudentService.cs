using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace WelcomeAPI_App.Controllers
{
    public class StudentService
    {
        private List<Student> _students = new List<Student>();
        BinaryDataLoader loader = new BinaryDataLoader();
        BinaryDataSaver saver = new BinaryDataSaver();

        public StudentService()
        {
            _students.Add(new Student(1, "brijesh", 22, "Ahmedabad"));
            _students.Add(new Student(2, "Akash", 23, "Mumbai"));
            _students.Add(new Student(3, "Ajay", 22, "Surat"));
        }
        public List<Student> Students
        {
            get
            {
                return _students;
            }
        }
        public List<Student> GetStudents()
        {
            //return loader.GetStudents();
            return Students;
        }

        public void Save(List<Student> students)
        {
            //saver.SaveStudents(students);
        }

        public List<Student> Search(Expression<Func<Student, bool>> query)
        {
            if (loader.GetStudents().Count > 0)
            {
                List<Student> students = loader.GetStudents();
                List<Student> resultStudents = new List<Student>();
                var newList = from x in students
                   .Where(query.Compile())
                              select x;
                return newList.ToList();
            }
            return null;
        }


        public Student GetStudent(int id)
        {

            foreach (Student s in _students)
            {
                if (s.Id == id)
                    return s;
            }
            return null;
        }

        public Student UpdateStudent(Student stud)
        {

            foreach (Student s in _students)
            {
                if (stud.Id == s.Id)
                    _students.Remove(s);
            }
            _students.Add(stud);
            return null;
        }

        public List<Student> AddStudent(Student student)
        {
            _students.Add(student);
            return _students;
        }
    }
}
