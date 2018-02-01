using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncActionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEvenV1;
            isEvenV1 = isAnEvenNo;
            Console.WriteLine(isEvenV1(30));

            Predicate<int> isEvenV2 = (n) => n % 2 == 0;
            Console.WriteLine(isEvenV2(30));


            Func<int, long> cubeevenV1;
            cubeevenV1 = CubeEven;
            Console.WriteLine(cubeevenV1(30));

            Func<int, long> cubeevenV2 = (n) => { if (isAnEvenNo(n)) { return n * n * n; } return 0; };
            Console.WriteLine(cubeevenV2(30));

            Action<int> actionV1;
            actionV1 = printEven;
            actionV1(20);

            Action<int> actionV2 = (n) =>
            {
                if (isAnEvenNo(n))
                {
                    for (int i = 1; i <= n; i++)
                    { { Console.WriteLine(n); } }
                };


            };
        }

        private static bool isAnEvenNo(int no)
        {
            return no % 2 == 0;
        }

        private static long CubeEven(int no)
        {
            if (isAnEvenNo(no))
            {
                return no * no * no;
            }
            return 0;
        }

        private static void printEven(int no)
        {
            for (int i = 1; i <= no; i++)
            {
                if (isAnEvenNo(i))
                    Console.WriteLine(i);
            }
        }
    }
}
