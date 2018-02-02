using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(2.5f);
            displayDetails(c1);

            Circle c2 = new Circle(4.5f, BorderStyle.DOUBLE);
            displayDetails(c2);

            Circle[] circles = new Circle[3];
            circles[0] = new Circle(5.5f);
            circles[1] = new Circle(5.5f, BorderStyle.SINGLE);
            circles[2] = new Circle(5.5f, BorderStyle.DOTTED);

            foreach (Circle circle in circles)
                displayDetails(circle);

        }

        public static void displayDetails(Circle circle)
        {
            Console.WriteLine("Radius is :" + circle.Radius);
            Console.WriteLine("Area is :" + circle.calcArea());
            Console.WriteLine("Border Style is :" + circle.Borderstyle);
            Console.WriteLine("Hash Code is :" + circle.GetHashCode());
        }
    }
}
