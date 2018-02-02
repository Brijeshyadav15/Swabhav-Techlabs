using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();

            atTheParty(man);

            atTheParty(boy);

            //atTheMovies(man);

            atTheMovies(boy);
        }

        public static void atTheParty(IMannerable obj)
        {
            Console.WriteLine("At the Party ");
            obj.Wish();
            Console.WriteLine("At the Party ");
            obj.Depart();

        }

        public static void atTheMovies(IEmotionable obj)
        {
            Console.WriteLine("At the Movies ");
            obj.Cry();
            Console.WriteLine("At the Movies ");
            obj.Laugh();

        }
    }
}
