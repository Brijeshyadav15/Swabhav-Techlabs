using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<String> names = args;
            String s = "Brijesh ";
            Console.WriteLine(s.AddHiTech());
            Console.WriteLine(s);
        }
    }
}
