using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntity_App
{
    public class Student
    {
        public Guid id;
        public string name;
        public int age;
        public string location;

        public Student()
        {
        }

        public Student(Guid tempid, string tempname, int tempage, string templocation)
        {
            id = tempid;
            name = tempname;
            age = tempage;
            location = templocation;
        }

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

    }
}
