using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPRefractorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoicePrinter invoiceprinter = new InvoicePrinter();
            invoiceprinter.printInvoice(new Invoice("1", "Brijesh", 150, 15));
        }
    }
}
