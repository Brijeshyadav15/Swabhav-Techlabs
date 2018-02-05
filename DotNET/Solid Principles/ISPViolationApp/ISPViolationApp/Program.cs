using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            atTheCafeteria(new Manager());
            atTheWorkstation(new Manager());

            atTheCafeteria(new Robot());
            atTheWorkstation(new Robot());
        }

        private static void atTheWorkstation(IWorkable worker)
        {
            Console.WriteLine("At the Workstation");
            worker.StartsWork();
            worker.EndsWork();
        }

        private static void atTheCafeteria(IWorkable worker)
        {
            Console.WriteLine("At the Cafeteria");
            worker.StartsEat();
            worker.EndsEat();

        }

    }
}
