using System;
using System.IO;
using System.Text;

namespace ReadFromFile
{
    class ReadFromFile
    {
        static void Main(string[] args)
        {
            var fileStream = new FileStream(@"TestFile.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
