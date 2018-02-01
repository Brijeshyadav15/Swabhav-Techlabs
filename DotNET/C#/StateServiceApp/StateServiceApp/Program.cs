using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateServiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StateService states = new StateService();
            Dictionary<String, String> resultStates = states.Search("G");

            try
            {
                if (resultStates.Count > 0)
                {
                    Console.WriteLine("Code\t State Name");
                    foreach (KeyValuePair<string, string> entry in resultStates)
                        Console.WriteLine(entry.Key + " \t " + entry.Value);
                }
            }
            catch
            {
                Console.WriteLine("No Results Found");
            }
        }
    }
}
