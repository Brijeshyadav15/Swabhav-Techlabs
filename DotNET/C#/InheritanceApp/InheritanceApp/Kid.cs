using System;

namespace InheritanceApp
{
    class Kid : Man
    {
        public Kid()
        {
            Console.WriteLine("Kid is created");
        }

        public void Play()
        {
            Console.WriteLine("Kid is playing");
        }
    }
}
