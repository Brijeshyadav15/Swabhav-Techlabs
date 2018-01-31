using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentSerializeApp
{
    [Serializable]
    class Student
    {
        private long _id;
        private String _name;
        private int _age;
        private String _location;

        public Student(long id, String name, int age, String location)
        {
            _id = id;
            _name = name;
            _age = age;
            _location = location;
        }

        public long Id
        {
            get
            {
                return _id;
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public String Location
        {
            get
            {
                return _location;
            }
        }



    }
}
