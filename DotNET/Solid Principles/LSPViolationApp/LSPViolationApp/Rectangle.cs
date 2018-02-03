using System;

namespace LSPViolationApp
{
    class Rectangle
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public virtual int Width
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

        public virtual int Height
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

        public int CalculateArea()
        {
            return Height * Width;
        }
    }
}
