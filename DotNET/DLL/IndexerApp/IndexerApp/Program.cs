using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle[0] = "First Element";
            rectangle[1] = "Second Element";
            rectangle[2] = "Third Element";
            rectangle[3] = "Fourth Element";
            rectangle[4] = "Fifth Element";
            Console.WriteLine("{0},{1},{2},{3},{4}", rectangle[0], rectangle[1], rectangle[2], rectangle[3], rectangle[4]);
        }
    }
}
