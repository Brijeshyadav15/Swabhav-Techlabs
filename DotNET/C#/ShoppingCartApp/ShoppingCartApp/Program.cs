using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCustomer();
        }

        private static void printInvoice(Customer customer)
        {
            Console.WriteLine("Customer Id: \t" + customer.Id
                    + "\t\t\t\tName: \t" + customer.Name + "\n");

            List<Order> orders = customer.Order;
            foreach (Order order in orders)
            {
                Console.WriteLine("Order Id: \t" + order.OrderId + "\tOrder Date: \t" + order.OrderDate + "\n");

                Console.WriteLine("Id\tProduct Name\t Cost \tDiscount\tQuantity\tPrice");

                List<LineItem> items = order.Items;
                foreach (LineItem lineitem in items)
                {
                    Console.WriteLine(lineitem.Id + "\t" + lineitem.Product.Name + "\t " + lineitem.Product.Cost + "\t " + lineitem.Product.Discount + "\t\t  " + lineitem.Quantity + "\t\t" + lineitem.costofLineItem() + "\n");

                }

                Console.WriteLine("\n" + "Total " + "\t\t\t\t\t\t\t\t"
                        + order.CalculateCheckOutCost() + "\n");
            }
        }
        private static void AddCustomer()
        {

            Order order1 = new Order(1, Convert.ToDateTime("08/01/18"));

            order1.AddItem(new LineItem(1, 4, new Product(1, "product1", 2000.00,
                    100.00f)));
            order1.AddItem(new LineItem(2, 3, new Product(2, "product2", 2500.00,
                    1230.00f)));
            order1.AddItem(new LineItem(3, 6, new Product(3, "product3", 3500.00,
                    1000.00f)));

            Order order2 = new Order(2, Convert.ToDateTime("09/01/18"));

            order2.AddItem(new LineItem(6, 4, new Product(1, "product3", 2000.00,
                    100.00f)));
            order2.AddItem(new LineItem(7, 3, new Product(2, "product2", 2500.00,
                    1230.00f)));
            order2.AddItem(new LineItem(8, 6, new Product(4, "product4", 3500.00,
                    1000.00f)));

            Customer customer = new Customer(1, "Brijesh");
            customer.AddOrder(order1);
            customer.AddOrder(order2);

            printInvoice(customer);
        }

    }
}
