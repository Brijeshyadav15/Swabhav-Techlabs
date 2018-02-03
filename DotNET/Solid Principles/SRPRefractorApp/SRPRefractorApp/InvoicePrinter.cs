using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPRefractorApp
{
    class InvoicePrinter
    {
        public void printInvoice(Invoice invoice)
        {
            Console.WriteLine("Invoice ID :" + invoice.Id);
            Console.WriteLine("Customer name :" + invoice.Name);
            Console.WriteLine("Cost Price :" + invoice.Cost);
            Console.WriteLine("Discounted Price :" + invoice.CalculateDiscount());
            Console.WriteLine("Tax on this product :" + invoice.CalculateTax());
            Console.WriteLine("Total :" + invoice.CalculateTotal());
        }
    }
}
