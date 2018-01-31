using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathComponentLib;
using MathComponentLib.Techlabs;


namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.CubeEvenNum(10));

            var dto = new StudentDTO { Location = "Mumbai", Name = "Briijesh" };

            //Console.WriteLine(dto);
            Console.WriteLine(dto.ToString());
            Console.WriteLine(dto.GetType());
            Console.WriteLine(dto.GetHashCode());

            var dto1= new StudentDTO { Location = "Ahmedabd", Name = "Akash" };

            Console.WriteLine(dto1);
            Console.WriteLine(dto1.ToString());

            Console.WriteLine(dto);


        }
    }
}
