using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            String name = Console.ReadLine();

            Console.WriteLine("Enter your Number:");
            String number = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            String age = Console.ReadLine();

            Console.WriteLine("Enter your Percentage:");
            String percentage = Console.ReadLine();

            Console.WriteLine("Enter your Address:");
            String address = Console.ReadLine();

            ResumeBuilder resumebuilder = new ResumeBuilder(name, number, age, percentage, address);
            resumebuilder.BuildResume();
        }
    }
}
