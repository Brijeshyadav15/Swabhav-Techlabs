using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIApiApp
{
    public class Student
    {
        public Student()
        {
        }

        public Student(Guid tempid, string tempfname, string templname, int tempage, string templocation, double cgpa)
        {
            Id = tempid;
            FirstName = tempfname;
            LastName = templname;
            Age = tempage;
            Location = templocation;
            CGPA = cgpa;
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Location { get; set; }

        public double CGPA { get; set; }
    }
}
