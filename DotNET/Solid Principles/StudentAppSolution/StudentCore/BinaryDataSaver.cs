using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StudentCore
{
    class BinaryDataSaver
    {
        public void SaveStudents(List<Student> studentList)
        {
            BinaryFormatter _formatter = new BinaryFormatter();
            FileStream _filestream = new FileStream("Data/Student.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            using (_filestream)
            {
                _formatter.Serialize(_filestream, studentList);
            }
        }
    }
}
