using System;

namespace InheritanceConstructorApp
{
    class Child : Parent
    {
        public Child() : base(0)
        {
            Console.WriteLine("Child Constructor is called");
        }
    }
}
