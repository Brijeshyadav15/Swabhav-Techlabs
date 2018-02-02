using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            caseStudyonAdd();

            caseStudyonDelete();

            caseStudyonUpdate();
        }

        private static void caseStudyonUpdate()
        {
            List<ListApp> list = new List<ListApp>();
            ListApp list1 = new ListApp(1, "Brijesh");
            ListApp list2 = new ListApp(2, "Akash");

            list.Add(list1);
            list.Add(list2);

            foreach (ListApp li in list)
            {
                Console.WriteLine(li.Id + " " + li.Name);
            }

            list.Where(l => l.Id == 2).First().Name = "Kannan";

            foreach (ListApp li in list)
            {
                Console.WriteLine(li.Id + " " + li.Name);
            }
        }

        private static void caseStudyonDelete()
        {
            List<ListApp> list = new List<ListApp>();
            ListApp list1 = new ListApp(1, "Brijesh");
            ListApp list2 = new ListApp(2, "Akash");

            list.Add(list1);
            list.Add(list2);

            foreach (ListApp li in list)
            {
                Console.WriteLine(li.Id + " " + li.Name);
            }

            list.Remove(list1);

            foreach (ListApp li in list)
            {
                Console.WriteLine(li.Id + " " + li.Name);
            }
        }

        private static void caseStudyonAdd()
        {
            List<ListApp> list = new List<ListApp>();
            ListApp list1 = new ListApp(1, "Brijesh");
            ListApp list2 = new ListApp(2, "Akash");

            list.Add(list1);
            list.Add(list2);

            foreach (ListApp li in list)
            {
                Console.WriteLine(li.Id + " " + li.Name);
            }
        }
    }
}
