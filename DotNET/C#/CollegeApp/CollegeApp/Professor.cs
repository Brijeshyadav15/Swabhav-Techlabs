using System;

namespace CollegeApp
{
    class Professor
    {
        private int _id;
        private String _address;
        private DateTime _dob;
        private double _basic;
        private double _hra;
        private double _da;

        public Professor(int id, String address, DateTime dob, double basic)
        {
            _id = id;
            _address = address;
            _dob = dob;
            _basic = basic;
            _hra = basic / 2;
            _da = basic / 3;
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

        public double Basic
        {
            get
            {
                return _basic;
            }
        }

        public double Id
        {
            get
            {
                return _id;
            }
        }

        public double Da
        {
            get
            {
                return _da;
            }
        }

        public double Hra
        {
            get
            {
                return _hra;
            }
        }

        public double CalculateSalary()
        {
            return Basic + Da + Hra;
        }

    }
}
