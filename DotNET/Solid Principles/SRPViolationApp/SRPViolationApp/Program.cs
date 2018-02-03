using System;

namespace SRPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("1", "Brijesh", 100, 15);
            invoice.printInvoice();
        }
    }
}
