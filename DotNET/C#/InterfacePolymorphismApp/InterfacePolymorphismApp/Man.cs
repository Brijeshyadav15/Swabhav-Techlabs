using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePolymorphismApp
{
    class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man is Departing");
        }

        public void Wish()
        {
            Console.WriteLine("Man is Wishing");
        }
    }
}
