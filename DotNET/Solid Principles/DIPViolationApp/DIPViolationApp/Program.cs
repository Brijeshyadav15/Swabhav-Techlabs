using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxcalculator = new TaxCalculator(LogType.XML);
            Console.WriteLine(taxcalculator.CalculateTax(10, 5));

            TaxCalculator taxcalculator1 = new TaxCalculator(LogType.TXT);
            Console.WriteLine(taxcalculator1.CalculateTax(0, 0));
        }
    }
}
