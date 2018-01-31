using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentSerializeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentConsole studentconsole = new StudentConsole(new BinaryStore());
            studentconsole.Start();
        }
    }
}
