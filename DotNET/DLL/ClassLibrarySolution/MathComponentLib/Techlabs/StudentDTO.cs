using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MathComponentLib.Techlabs
{
    public class StudentDTO
    {
        private int _id = 101;
        private static int _nextId = 0;

        public StudentDTO()
        {
            _id = _id + _nextId;
            _nextId++;
        }

        public String Name
        {
            get;
            set;
        }
        public String Location
        {
            get;
            set;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public override string ToString()
        {
            return "{ 'Id':" + Id + ",'Name':" + Name + ", 'Location' :" + Location + "}";
        }
    }
}
