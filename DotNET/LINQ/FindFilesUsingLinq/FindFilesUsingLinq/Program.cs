using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FindFilesUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("C:/Windows/System32");
            Dictionary<string, int> fileinfos = new Dictionary<string, int>();

            foreach (var file in files)
                fileinfos.Add(new FileInfo(file).ToString(), Convert.ToInt32(new FileInfo(file).Length));


            var Top3 = fileinfos.OrderByDescending(f => f.Value).Take(3);

            foreach (var top in Top3)
                Console.WriteLine("File Name " + top.Key + " File Size " + top.Value);    
        }
    }
}
