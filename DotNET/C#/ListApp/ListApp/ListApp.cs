using System;

namespace ListApp
{
    class ListApp
    {
        private int _id;
        private String _name;

        public ListApp(int id, String name)
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
            set
            {
                _name = value;
            }
        }
    }
}
