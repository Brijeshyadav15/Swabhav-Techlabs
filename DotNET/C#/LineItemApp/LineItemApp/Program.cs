using System;
using System.Collections.Generic;

namespace LineItemApp
{
    class Program
    {
        static HashSet<LineItem> items = new HashSet<LineItem>();
        static void Main(string[] args)
        {
            caseStudyOne();

            //caseStudyTwo();
        }

        private static void caseStudyTwo()
        {
            items.Add(new LineItem(1, "Product1", 5, 10));
            items.Add(new LineItem(2, "Product2", 8, 12));
            items.Add(new LineItem(3, "Product3", 10, 15));
        }

        private static void caseStudyOne()
        {
            List<LineItem> items = new List<LineItem>();
            items.Add(new LineItem(1, "Product1", 5, 10));
            items.Add(new LineItem(2, "Product2", 8, 12));
            items.Add(new LineItem(3, "Product3", 10, 15));

            foreach (LineItem item in items)
            {
                Console.WriteLine("Total Price of " + item.Product + "is:" + item.CalculateTotal());
            }
        }

        public static HashSet<LineItem> Get()
        {
            caseStudyTwo();
            return items;
        }
    }
}
