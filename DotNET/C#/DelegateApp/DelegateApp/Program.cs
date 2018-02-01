using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateApp
{
    delegate void DSaySomething(String name);
    class Program
    {
        static void Main(string[] args)
        {
            //case1();

            //case2();

            //case3();

            //case4();

            casewithLambda();

        }

        private static void casewithLambda()
        {
            MessageWizard((n) => Console.WriteLine("Inside Lambada : {0} says Hello", n));
        }

        private static void case4()
        {
            MessageWizard(delegate (String name)
            {
                Console.WriteLine("Inside Message Wizard");
                Console.WriteLine("{0} says Hello", name);
            });
        }

        private static void case3()
        {
            MessageWizard(SayHello);
            MessageWizard(SayGoodBye);
        }

        private static void case2()
        {
            DSaySomething obj = SayHello;
            obj += SayGoodBye;
            obj("Brijesh");
        }

        private static void case1()
        {
            DSaySomething obj = SayHello;
            obj("Brijesh");

            obj = SayGoodBye;
            obj("Brijesh");
        }

        static void SayHello(String name)
        {
            Console.WriteLine("{0} says Hello", name);
        }

        static void SayGoodBye(String name)
        {
            Console.WriteLine("{0} says GoodBye", name);
        }

        static void MessageWizard(DSaySomething obj)
        {
            Console.WriteLine("Inside Message Wizard");
            obj("Message Wizard");
        }

        void Foo()
        {
            Console.WriteLine("Inside Foo");
        }
    }
}
