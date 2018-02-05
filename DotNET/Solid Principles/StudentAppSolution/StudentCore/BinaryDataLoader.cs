﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StudentCore
{
    [Serializable]
    class BinaryDataLoader
    {
        private List<Student> _studentList;
        private BinaryFormatter _formatter;
        private FileStream _filestream;


        public BinaryDataLoader()
        {
            _studentList = new List<Student>();
            _formatter = new BinaryFormatter();
            try
            {
                _filestream = new FileStream("Data/Student.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch
            {

            }

        }

        public List<Student> GetStudents()
        {
            using (_filestream)
            {
                try
                {
                    _studentList = (List<Student>)_formatter.Deserialize(_filestream);
                }
                catch
                {

                }
            }
            return _studentList;
        }
    }
}
