using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQWithCollectionApp
{
    class Student
    {
        private int _id;
        private String _fname;
        private string _lastName;
        private int _cgpa;
        private string _location;
        private int _age;

        public Student(int id, string fname, string lastname, int cgpa, string location, int age)
        {
            _id = Id;
            _fname = fname;
            _lastName = lastname;
            _cgpa = cgpa;
            _location = location;
            _age = age;
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public int CGPA
        {
            get { return _cgpa; }
            set { _cgpa = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public String FirstName
        {
            get { return _fname; }
            set { _fname = value; }
        }

    }
}
