using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RefExample();
            OutExample();

            VarExample();
            DynamicExample();

        }

        private static void VarExample()
        {
            var svar = "VAR EXAMPLE";
            Console.WriteLine(svar.Length);
        }

        private static void DynamicExample()
        {
            dynamic sdynamic = "Dynamic EXAMPLE";
            Console.WriteLine(sdynamic.Length);
        }

        private static void OutExample()
        {
            int value;
            OutMethod(out value);
            Console.WriteLine(value);
        }

        private static void RefExample()
        {
            int val = 4;
            RefMethod(ref val);
            Console.WriteLine(val);
        }

        static void RefMethod(ref int i)
        {
            i = i *24 ;
        }

        static void OutMethod(out int i)
        {
            i = 44;
        }
    }
}
