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
            if (loader.GetStudents().Count > 0)
            {
                List<Student> _students = loader.GetStudents();
                
                //_students.Sele(Find(s => s.Age > age && s.Id == id && s.Name.Contains(name) && s.Location.Contains(location)));

                //return _students.Find(s => s.Age > age && s.Id == id && s.Name.Contains(name) && s.Location.Contains(location));
            }
            return null;
        }
    }
}
