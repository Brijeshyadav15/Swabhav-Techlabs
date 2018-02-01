using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathDelegateApp
{
    delegate int DMathDelegate(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            //casewithReturn();

            
        }

        private static void casewithReturn()
        {
            DMathDelegate calc;
            calc = Add;
            Console.WriteLine(calc(20, 10));

            calc += Subtract;
            Console.WriteLine(calc(20, 10));

            calc += Divide;
            Console.WriteLine(calc(20, 10));

            calc += Multiply;
            Console.WriteLine(calc(20, 10));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Divide(int x, int y)
        {
            return x / y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Calculator(DMathDelegate obj)
        {
            Console.WriteLine();
        }

    }
}
