using System;

namespace OCPRefractorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd = new FixedDeposit("Brijesh", 1000, 1,
                new NewYearRate());
            Console.WriteLine("Interest is :" + fd.CalculateInterest());
        }
    }
}
