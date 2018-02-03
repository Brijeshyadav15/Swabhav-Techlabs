using System;

namespace LSPViolationApp
{
    class Square : Rectangle
    {
        private int _side;

        public Square(int side) : base(side, side)
        {
            _side = side;
        }

        public override int Height
        {
            set
            {
                _height = _width = value;
            }
        }

        public override int Width
        {
            set
            {
                _width = _height = value;
            }
        }
    }
}
