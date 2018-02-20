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
            case2();
        }

        private static void case2()
        {
            OrderDbContext odc = new OrderDbContext();

            Product laptop = new Product();
            laptop.Id = Guid.NewGuid();
            laptop.ProductName = "Laptop";
            laptop.ProductCost = 25000;

            Product mobile = new Product();
            mobile.Id = Guid.NewGuid();
            mobile.ProductCost = 10000;
            mobile.ProductName = "Mobile";

            Product hdd = new Product();
            hdd.Id = Guid.NewGuid();
            hdd.ProductCost = 5000;
            hdd.ProductName = "Mobile";

            Product books = new Product();
            books.Id = Guid.NewGuid();
            books.ProductCost = 1000;
            books.ProductName = "Books";

            Product peripherals = new Product();
            peripherals.Id = Guid.NewGuid();
            peripherals.ProductCost = 1500;
            peripherals.ProductName = "Peripherals";

            Customer brijesh = new Customer();
            brijesh.Id = Guid.NewGuid();
            brijesh.Name = "Brijesh";

            Order order1 = new Order();
            order1.Id = Guid.NewGuid();

            Order order2 = new Order();
            order2.Id = Guid.NewGuid();

            LineItem l1 = new LineItem();
            l1.Id = Guid.NewGuid();
            l1.ProductId = laptop.Id;
            //l1.Order = order1;
            l1.OrderId = order1.Id;
            l1.Quantity = 2;
            l1.Total = laptop.ProductCost * l1.Quantity;


            LineItem l2 = new LineItem();
            l2.Id = Guid.NewGuid();
            l2.ProductId = mobile.Id;
            //l2.Order = order1;
            l2.OrderId = order1.Id;
            l2.Quantity = 3;
            l2.Total = mobile.ProductCost * l2.Quantity;

            LineItem l3 = new LineItem();
            l3.Id = Guid.NewGuid();
            l3.ProductId = books.Id;
            //l3.Order = order1;
            l3.OrderId = order1.Id;
            l3.Quantity = 3;
            l3.Total = books.ProductCost * l3.Quantity;

            LineItem l4 = new LineItem();
            l4.Id = Guid.NewGuid();
            l4.ProductId = mobile.Id;
            //l4.Order = order2;
            l4.OrderId = order2.Id;
            l4.Quantity = 3;
            l4.Total = mobile.ProductCost * l4.Quantity;

            LineItem l5 = new LineItem();
            l5.Id = Guid.NewGuid();
            l5.ProductId = peripherals.Id;
            //l5.Order = order2;
            l5.OrderId = order2.Id;
            l5.Quantity = 4;
            l5.Total = peripherals.ProductCost * l5.Quantity;

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
    }
}
