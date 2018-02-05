using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPViolationApp
{
    class Robot : IWorkable
    {
        public void EndsEat()
        {
            Console.WriteLine("Robot ends eating");
        }

        public void EndsWork()
        {
            Console.WriteLine("Robot ends working");
        }

        public void StartsEat()
        {
            Console.WriteLine("Robot starts eating");
        }

        public void StartsWork()
        {
            Console.WriteLine("Robot starts working");
        }
    }
}
