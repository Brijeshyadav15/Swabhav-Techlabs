using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            caseStudyonAdd();

            caseStudyonDelete();

            caseStudyOnUpdate();

        }

        private static void caseStudyOnUpdate()
        {
            HashSet<Set> set = new HashSet<Set>();
            Set set1 = new SetApp.Set(1, "Brijesh");
            Set set2 = new SetApp.Set(2, "Akash");

            set.Add(set1);
            set.Add(set2);

            foreach (Set s in set)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }

            Set set3 = new SetApp.Set(3, "Kannan");
            set.Add(set3);

            foreach (Set s in set)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }
        }

        private static void caseStudyonDelete()
        {
            HashSet<Set> set = new HashSet<Set>();
            Set set1 = new SetApp.Set(1, "Brijesh");
            Set set2 = new SetApp.Set(2, "Akash");

            set.Add(set1);
            set.Add(set2);

            foreach (Set s in set)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }

            set.Remove(set1);

            foreach (Set s in set)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }
        }

        private static void caseStudyonAdd()
        {
            HashSet<Set> set = new HashSet<Set>();
            Set set1 = new SetApp.Set(1, "Brijesh");
            Set set2 = new SetApp.Set(2, "Akash");

            set.Add(set1);
            set.Add(set2);

            foreach (Set s in set)
            {
                Console.WriteLine(s.Id + " " + s.Name);
            }
        }
    }
}
