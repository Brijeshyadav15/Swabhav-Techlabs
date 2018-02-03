using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGenericApp
{
    class StudentGeneric
    {
        private int _std;
        private int _rollNo;
        private String _name;

        public StudentGeneric(int std, int rollNo, String name)
        {
            _std = std;
            _rollNo = rollNo;
            _name = name;
        }

        public int Std
        {
            get
            {
                return _std;
            }
        }

        public int RollNo
        {
            get
            {
                return _rollNo;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }        
    }
}
