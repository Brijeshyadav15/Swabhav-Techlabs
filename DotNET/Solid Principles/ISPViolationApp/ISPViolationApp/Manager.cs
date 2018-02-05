using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViolationApp
{
    class Manager : IWorkable
    {
        public void EndsEat()
        {
            Console.WriteLine("Manager Stops Eating");
        }

        public void EndsWork()
        {
            Console.WriteLine("Manager Ends Working");
        }

        public void StartsEat()
        {
            Console.WriteLine("Manager Starts Eating");
        }

        public void StartsWork()
        {
            Console.WriteLine("Manager Starts Working");
        }
    }
}
