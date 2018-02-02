using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetApp
{
    class Set
    {
        private int _id;
        private String _name;

        public Set(int id, String name)
        {
            _id = id;
            _name = name;
        }

        public int Id
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
    }
}
