using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            shouldnotchange_height_ifwidthischanged(new Rectangle(5, 2));
            shouldnotchange_height_ifwidthischanged(new Square(5));
        }

        private static void shouldnotchange_height_ifwidthischanged(
            Rectangle rectangle)
        {
            int before = rectangle.Height;
            rectangle.Width = 50;
            int after = rectangle.Height;

            Console.WriteLine("Height before:" + before);
            Console.WriteLine("Height After:" + after);

        }
    }
}
