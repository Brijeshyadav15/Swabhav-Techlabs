using System;

namespace InheritanceApp
{
    class Man
    {
        public Man()
        {
            Console.WriteLine("Man is created");
        }

        public void Read()
        {
            Console.WriteLine("Man is reading");
        }

        public virtual void Play()
        {
            Console.WriteLine("Man is playing");
        }

    }
}
