using System;
using System.Linq;

namespace WelcomeApp
{
    class Program
    {
        static void Main(string[] names)
        {
            //Case1(names);

            //Case2();

            //Case3();

            var namesStartingWIthA = names.Where((n) => { if (n.Contains("s")) { return true; } return false; });

            var top1 = namesStartingWIthA.Take(1);
            foreach (String name in top1)
            {
                Console.WriteLine(name);
            }
        }

        private static void Case3()
        {
            Rectangle[] rect = new Rectangle[3];
            rect[0] = new Rectangle(10, 20, BorderStyle.SINGLE);
            rect[1] = new Rectangle(20, 30, BorderStyle.DOUBLE);
            rect[2] = new Rectangle(30, 40, BorderStyle.DOTTED);

            foreach (Rectangle rec in rect)
            {
                Console.WriteLine("Rectangle Height is :" + rec.Height);
                Console.WriteLine("Rectangle Width is :" + rec.Width);
                Console.WriteLine("Rectangle Border is :" + rec.Border);
                Console.WriteLine("Rectangle Area is : " + rec.Area);
                Console.WriteLine();
            }
        }

        private static void Case2()
        {
            Rectangle r1 = new Rectangle(10, 15);
            Console.WriteLine(r1.Area);

            Rectangle r2 = new Rectangle(10, 15, BorderStyle.DOUBLE);
            Console.WriteLine(r2.Border);
            r2.Border = BorderStyle.SINGLE;
            Console.WriteLine(r2.Border);
            r2.Height = 15;
            r2.Width = 20;
            Console.WriteLine(r2.Area);
        }

        private static void Case1(string[] names)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(names.Length);

            foreach (String name in names)
            {
                Console.WriteLine("Hello " + name);
            }
            Console.ReadKey();
        }
    }
}
