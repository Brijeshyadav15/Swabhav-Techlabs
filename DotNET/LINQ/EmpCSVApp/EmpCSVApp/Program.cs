using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmpCSVApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("dataFile.txt");
            String line;
            HashSet<String> names = new HashSet<string>();
            using (reader)
            {
                while ((line = reader.ReadLine()) != null)
                {
                    String[] emp = line.Split(',');
                    emp[1] = emp[1].Replace("'", "");
                    names.Add(emp[1]);
                }
            }

            var sortedNames = names.OrderBy(e => e);

            foreach (var Name in sortedNames)
                Console.WriteLine(Name);
        }
    }
}
