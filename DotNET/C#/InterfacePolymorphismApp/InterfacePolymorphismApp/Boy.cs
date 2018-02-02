using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePolymorphismApp
{
    class Boy : IEmotionable, IMannerable
    {
        public void Cry()
        {
            Console.WriteLine("Boy is crying");
        }

        public void Depart()
        {
            Console.WriteLine("Boy is departing");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy is laughing");
        }

        public void Wish()
        {
            Console.WriteLine("Boy is wishing");
        }
    }
}
