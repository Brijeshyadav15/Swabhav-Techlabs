using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            caseStudyonADD();

            casestudyonDelete();

            caseStudyonUpdate();
        }

        private static void caseStudyonUpdate()
        {
            Dictionary<int, String> dict = new Dictionary<int, string>();
            dict.Add(1, "Brijesh");
            dict.Add(2, "Akash");


            foreach (KeyValuePair<int, String> entry in dict)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }

            dict.Add(3, "Kannan");

            foreach (KeyValuePair<int, String> entry in dict)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }

        private static void casestudyonDelete()
        {
            Dictionary<int, String> dict = new Dictionary<int, string>();
            dict.Add(1, "Brijesh");
            dict.Add(2, "Akash");


            foreach (KeyValuePair<int, String> entry in dict)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }

            dict.Remove(1);

            foreach (KeyValuePair<int, String> entry in dict)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }

        private static void caseStudyonADD()
        {
            Dictionary<int, String> dict = new Dictionary<int, string>();
            dict.Add(1, "Brijesh");
            dict.Add(2, "Akash");

            foreach (KeyValuePair<int, String> entry in dict)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
    }
}
