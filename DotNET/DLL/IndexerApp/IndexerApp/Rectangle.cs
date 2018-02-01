using System;

namespace IndexerApp
{
    class Rectangle
    {
        private int _height;
        private int _width;

        public Rectangle()
        {

        }
        public Rectangle(int width, int height)
        {
            _height = height;
            _width = width;
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Area
        {
            get
            {
                return _width * _height;
            }
        }

        private string[] data = new string[5];
        public string this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

    }
}
