using System;
using System.IO;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Lorem ipsum dolor sit amet, consectetur adipiscing elit,";
            File.WriteAllText(@"TestFile1.txt", line);

        }
    }
}

