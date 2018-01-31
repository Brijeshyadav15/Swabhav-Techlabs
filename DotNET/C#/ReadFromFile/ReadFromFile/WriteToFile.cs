using System;
using System.IO;
using System.Text;

namespace ReadFromFile
{
    class WriteToFile
    {
        static void Main(string[] args)
        {
            string line = "Lorem ipsum dolor sit amet, consectetur adipiscing elit,";
            File.WriteAllText(@"TestFile1.txt", line);

        }
    }
}
