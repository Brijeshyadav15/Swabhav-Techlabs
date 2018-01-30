using System;

namespace InheritanceApp
{
    class Kid : Man
    {
        public Kid()
        {
            Console.WriteLine("Kid is created");
        }

        new public void Play()
        {
            Console.WriteLine("Kid is playing");
        }
    }
}
