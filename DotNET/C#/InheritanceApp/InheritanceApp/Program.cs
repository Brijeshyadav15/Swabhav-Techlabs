using System;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //case1();
            //case2();
            //case3();
            case4();
        }



        private static void case1()
        {
            Man x = new Man();
            x.Read();
            x.Play();
        }

        private static void case2()
        {
            Boy y = new Boy();
            y.Play();
            y.Eat();
            y.Read();
        }

        private static void case3()
        {
            Man x;
            x = new Boy();
            x.Play();
            x.Read();
        }

        private static void case4()
        {
            atThePark(new Man());
            atThePark(new Boy());
            atThePark(new Kid());
            atThePark(new Infant());
        }

        public static void atThePark(Man x)
        {
            Console.WriteLine("At the Park");
            x.Play();
        }
    }
}
