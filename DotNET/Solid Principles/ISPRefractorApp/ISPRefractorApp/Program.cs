using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPRefractorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            atTheCafeteria(new Manager());

            atTheWorkstation(new Manager());

            atTheWorkstation(new Robot());
        }

        private static void atTheWorkstation(IWorkable worker)
        {
            Console.WriteLine("At the Workstation");
            worker.StartsWork();
            worker.StopsWork();
        }

        private static void atTheCafeteria(IEatable worker)
        {
            Console.WriteLine("At the Cafeteria");
            worker.StartsEat();
            worker.StopsEat();
        }
    }
}
