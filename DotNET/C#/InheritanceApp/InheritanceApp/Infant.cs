using System;

namespace InheritanceApp
{
    class Infant : Man
    {
        public Infant()
        {
            Console.WriteLine("Infant is created");
        }

       

        new public void Play()
        {
            Console.WriteLine("Infant is playing");
        }
    }
}
