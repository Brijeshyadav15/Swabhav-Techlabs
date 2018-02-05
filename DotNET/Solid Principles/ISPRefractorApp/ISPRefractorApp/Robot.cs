using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPRefractorApp
{
    class Robot : IWorkable
    {
        public void StartsWork()
        {
            Console.WriteLine("Robot starts working");
        }

        public void StopsWork()
        {
            Console.WriteLine("Robot stops working");
        }
    }
}
