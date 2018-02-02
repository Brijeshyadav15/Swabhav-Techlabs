using System;

namespace CollegeApp
{
    class Student
    {
        private int _id;
        private String _address;
        private DateTime _dob;
        private Branch _branch;
        
        public Student(int id,String address, DateTime dob,Branch branch)
        {
            _id = id;
            _address = address;
            _dob = dob;
            _branch = branch;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public String Address
        {
            get
            {
                return _address;
            }
        }

        public DateTime Dob
        {
            get
            {
                return _dob;
            }
        }

        public Branch Branch
        {
            get
            {
                return _branch;
            }
        }




    }
}
