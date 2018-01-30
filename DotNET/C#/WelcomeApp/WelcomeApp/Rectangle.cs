using System;

namespace WelcomeApp
{
    class Rectangle
    {
        private int _height;
        private int _width;
        private BorderStyle _border;

        public Rectangle(int width, int height)
        {
            _height = height;
            _width = width;
        }

        public Rectangle(int width, int height, BorderStyle border)
        {
            _height = height;
            _width = width;
            _border = border;
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

        public BorderStyle Border
        {
            get
            {
                return _border;
            }
            set
            {
                _border = value;
            }
        }

    }
}
