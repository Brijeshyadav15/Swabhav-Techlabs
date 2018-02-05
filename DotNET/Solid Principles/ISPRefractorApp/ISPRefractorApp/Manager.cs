using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPRefractorApp
{
    class Manager : IWorkableEatable
    {
        public void StartsEat()
        {
            Console.WriteLine("Manager Starts Eating");
        }

        public void StartsWork()
        {
            Console.WriteLine("Manager Starts Working");
        }

        public void StopsEat()
        {
            Console.WriteLine("Manager Stops Eating");
        }

        public void StopsWork()
        {
            Console.WriteLine("Manager Stops Working");
        }
    }
}
