using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StudentSerializeApp
{
    class BinaryStore : IStudentStore
    {
        private List<Student> _studentList;
        BinaryFormatter formatter = new BinaryFormatter();

        public BinaryStore()
        {
            Init();
        }

        public void Init()
        {
            FileStream filestream = new FileStream("Data/Student.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (filestream)
                {

                    _studentList = (List<Student>)formatter.Deserialize(filestream);
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured");

            }

        }

        public List<Student> Get()
        {
            return _studentList;
        }

        public void Add(Student student)
        {
            _studentList.Add(student);
            Save();
        }

        private void Save()
        {

            FileStream filestream = new FileStream("Data/Student.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (filestream)
                {
                    formatter.Serialize(filestream, _studentList);
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured");

            }
            Init();
        }

        public String Delete(long id)
        {
            foreach (Student studentName in _studentList)
            {
                if (id == studentName.Id)
                {
                    _studentList.Remove(studentName);
                    Save();
                    return "Student Deleted by name of :" + studentName.Name;
                }
            }
            return "No Student found with the Given Name";
        }

        public void Export()
        {
            throw new NotImplementedException();
        }

        public Student Search(string name)
        {
            foreach (Student studentName in _studentList)
            {
                if (name.Equals(studentName.Name))
                {
                    return studentName;
                }
            }
            return null;
        }
    }
}
