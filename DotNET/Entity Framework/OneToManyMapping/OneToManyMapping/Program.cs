using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            //case1();
            //case2();
            Customer brijesh = new Customer();
            brijesh.Id = Guid.Parse("7A54B3B8-3ADC-4457-8966-6672F477ABDD");// (Guid);
            printInvoice(brijesh);
        }

        private static void case2()
        {
            OrderDbContext odc = new OrderDbContext();

            Product laptop = new Product(Guid.NewGuid(), "Laptop", 2500);
            Product mobile = new Product(Guid.NewGuid(), "Mobile", 10000);
            Product hdd = new Product(Guid.NewGuid(), "Mobile", 5000);
            Product books = new Product(Guid.NewGuid(), "Books", 1000);
            Product peripherals = new Product(Guid.NewGuid(), "Peripherals", 1500);

            Customer brijesh = new Customer();
            brijesh.Id = Guid.NewGuid();
            brijesh.Name = "Brijesh";

            Order order1 = new Order();
            order1.Id = Guid.NewGuid();

            Order order2 = new Order();
            order2.Id = Guid.NewGuid();

            LineItem l1 = new LineItem(Guid.NewGuid(), order1.Id, laptop.Id, 3, laptop.ProductCost * 2);
            LineItem l2 = new LineItem(Guid.NewGuid(), order1.Id, mobile.Id, 3, mobile.ProductCost * 3);
            LineItem l3 = new LineItem(Guid.NewGuid(), order1.Id, books.Id, 3, books.ProductCost * 3);
            LineItem l4 = new LineItem(Guid.NewGuid(), order2.Id, mobile.Id, 3, mobile.ProductCost * 3);

            LineItem l5 = new LineItem(Guid.NewGuid(), order2.Id, peripherals.Id, 4, peripherals.ProductCost * 4);

            order1.LineItems = new List<LineItem> { l1, l2 };
            order1.customer = brijesh;
            order1.customerId = brijesh.Id;
            order1.OrderTotal = (from od in order1.LineItems
                                 where od.Total > 0
                                 select od.Total).Sum();


            order2.LineItems = new List<LineItem> { l1, l3, l5 };
            order2.customer = brijesh;
            order2.customerId = brijesh.Id;
            order2.OrderTotal = (from od in order2.LineItems
                                 where od.Total > 0
                                 select od.Total).Sum();

            brijesh.Order = new List<Order> { order1, order2 };
            brijesh.Location = "Mumbai";
            odc.Orders.Add(order1);
            odc.Orders.Add(order2);


            odc.Product.Add(mobile);
            odc.Product.Add(books);
            odc.Product.Add(peripherals);
            odc.Product.Add(laptop);
            odc.Product.Add(books);

            odc.LineItem.Add(l1);
            odc.LineItem.Add(l2);
            odc.LineItem.Add(l3);
            odc.LineItem.Add(l4);
            odc.LineItem.Add(l5);

            odc.Customers.Add(brijesh);
            odc.SaveChanges();

        }
        private static void case1()
        {
            OrderDbContext odc = new OrderDbContext();
            Customer brijesh = new Customer();

            brijesh.Id = Guid.NewGuid();
            brijesh.Name = "Brijesh";
            brijesh.Location = "Mumbai";


            Order order1 = new Order();
            order1.Id = Guid.NewGuid();
            order1.customer = brijesh;
            order1.customerId = brijesh.Id;
            odc.Orders.Add(order1);


            Order order2 = new Order();
            order2.Id = Guid.NewGuid();
            order2.customer = brijesh;
            order2.customerId = brijesh.Id;
            odc.Orders.Add(order2);

            Order order3 = new Order();
            order3.Id = Guid.NewGuid();
            order3.customer = brijesh;
            order3.customerId = brijesh.Id;
            odc.Orders.Add(order3);

            List<Order> brijeshorder = new List<Order>();
            brijeshorder.Add(order1);
            brijeshorder.Add(order2);
            brijeshorder.Add(order3);

            brijesh.Order = brijeshorder;
            odc.Customers.Add(brijesh);

            Customer aakash = new Customer();
            aakash.Id = Guid.NewGuid();
            aakash.Name = "Aakash";
            aakash.Location = "Ahmedabad";

            Order order4 = new Order();
            order4.Id = Guid.NewGuid();
            order4.customer = aakash;
            order4.customerId = aakash.Id;
            odc.Orders.Add(order4);

            Order order5 = new Order();
            order5.Id = Guid.NewGuid();
            order5.customer = aakash;
            order5.customerId = aakash.Id;
            odc.Orders.Add(order5);

            List<Order> aakashorder = new List<Order>();
            aakashorder.Add(order4);
            aakashorder.Add(order5);

            odc.SaveChanges();
        }
        private static void printInvoice(Customer customer)
        {
            OrderDbContext odc = new OrderDbContext();
            var custID = odc.Customers.Single(c => c.Id == customer.Id);
            Console.WriteLine("Customer ID:" + custID.Id + "\t Customer Name:" + custID.Name);

            var orders = odc.Orders.Where(c => c.customerId == custID.Id).ToList();
            foreach (var o in orders)
            {
                Console.WriteLine(o.OrderTotal);
            }


        }
    }
}
