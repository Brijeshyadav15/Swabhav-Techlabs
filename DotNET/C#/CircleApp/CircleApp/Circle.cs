using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleApp
{
    class Circle
    {
        private float _radius;
        private float _pie = 3.14f;
        private BorderStyle _borderstyle;

        public Circle(float rad)
        {
            _radius = rad;
            _borderstyle = BorderStyle.SINGLE;
        }

        public Circle(float rad, BorderStyle border_style)
        {
            _radius = rad;
            _borderstyle = border_style;
        }

        public float Radius
        {
            get
            {
                return _radius;
            }
        }

        public BorderStyle Borderstyle
        {
            get
            {
                return _borderstyle;
            }
        }

        public float calcArea()
        {
            return 2 * _pie * Radius;
        }

    }
}
