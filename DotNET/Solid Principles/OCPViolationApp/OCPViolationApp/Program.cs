using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd = new FixedDeposit("Brijesh", 1000, 1,
                FestivalType.NEWYEAR);
            Console.WriteLine("Interest is :" + fd.CalculateInterest());
        }
    }
}
