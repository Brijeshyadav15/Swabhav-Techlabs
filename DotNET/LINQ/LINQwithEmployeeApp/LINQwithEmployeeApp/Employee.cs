using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQwithEmployeeApp
{
    class Employee
    {
        private int _empno;
        private string _ename;
        private string _job;
        private int _mgr;
        private DateTime _hiredate;
        private int _sal;
        private int _comm;
        private int _deptNum;

        public Employee(int empno, string ename, string job, int mgr, DateTime hiredate, int sal, int comm, int deptNum)
        {
            _empno = empno;
            _ename = ename;
            _job = job;
            _mgr = mgr;
            _hiredate = hiredate;
            _sal = sal;
            _comm = comm;
            _deptNum = deptNum;
        }

        public int DeptNum
        {
            get { return _deptNum; }
            set { _deptNum = value; }
        }


        public int Comm
        {
            get { return _comm; }
            set { _comm = value; }
        }

        public int Sal
        {
            get { return _sal; }
            set { _sal = value; }
        }

        public DateTime HireDate
        {
            get { return _hiredate; }
            set { _hiredate = value; }
        }

        public int MGR
        {
            get { return _mgr; }
            set { _mgr = value; }
        }


        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }

        public string Ename
        {
            get { return _ename; }
            set { _ename = value; }
        }

        public int EmpNo
        {
            get { return _empno; }
            set { _empno = value; }
        }

    }
}
