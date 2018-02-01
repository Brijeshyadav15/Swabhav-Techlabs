using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParamsArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            result = Add(10, 10, 10);
            Console.WriteLine(result);

            result = Add(10, 10, 10, 10);
            Console.WriteLine(result);

            result = Add(10, 10, 10, 10, 10);
            Console.WriteLine(result);


            int[] x = { 10, 10, 10, 10, 10, 10, 10, 10 };

            result = Add(x);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int Add(params int[] nums)
        {
            int total = 0;
            foreach (int i in nums)
            {
                total = total + i;
            }
            return total;
        }
    }
}
