using System;

namespace InheritanceApp
{
    class Boy : Man
    {

        public Boy()
        {
            Console.WriteLine("Boy is created");
        }

        public void Eat()
        {
            Console.WriteLine("Boy is eating");
        }

        new public void Play()
        {
            Console.WriteLine("Boy is playing");
        }

    }
}