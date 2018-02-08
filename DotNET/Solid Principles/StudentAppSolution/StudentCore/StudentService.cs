using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

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
    }
}
