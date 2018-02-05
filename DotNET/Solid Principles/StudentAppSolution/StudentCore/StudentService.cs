using System;
using System.Collections.Generic;
using System.IO;

namespace StudentCore
{
    public class StudentService
    {
        private List<Student> _students = new List<Student>();
        BinaryDataLoader loader = new BinaryDataLoader();
        BinaryDataSaver saver = new BinaryDataSaver();

        public List<Student> GetStudents()
        {
            return loader.GetStudents();
        }

        public void Save(List<Student> students)
        {
            saver.SaveStudents(students);
        }

        public List<Student> Search(int id, String name, int age, String location)
        {
            List<Student> resultstudents = new List<Student>();

            if (loader.GetStudents().Count > 0)
            {
                List<Student> _students = loader.GetStudents();

                foreach (Student student in _students)
                {
                    if (name != null && student.Name.Equals(name))
                        resultstudents.Add(student);
                    else if (location != null && student.Location.Equals(location))
                        resultstudents.Add(student);
                    else if (age > 0 && student.Age == age)
                        resultstudents.Add(student);
                    else if (id > 0 && student.Id == id)
                        resultstudents.Add(student);
                }
            }
            return resultstudents;
        }
    }
}
