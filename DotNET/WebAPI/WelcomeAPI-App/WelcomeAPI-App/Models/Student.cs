using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WelcomeAPI_App.Controllers
{
    [Serializable]
    public class Student
    {
        private long _id;
        private String _name;
        private int _age;
        private String _location;

        public Student()
        {
        }

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
            set
            {
                _id= value;
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public String Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
    }
}
