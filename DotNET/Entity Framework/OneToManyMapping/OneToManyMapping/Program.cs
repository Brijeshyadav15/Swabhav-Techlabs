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
            case1();
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
            order1.ProductName = "Laptop";
            order1.ProductCost = 20000;
            odc.Orders.Add(order1);


            Order order2 = new Order();
            order2.Id = Guid.NewGuid();
            order2.customer = brijesh;
            order2.customerId = brijesh.Id;
            order2.ProductName = "Mobile";
            order2.ProductCost = 10000;
            odc.Orders.Add(order2);

            Order order3 = new Order();
            order3.Id = Guid.NewGuid();
            order3.customer = brijesh;
            order3.customerId = brijesh.Id;
            order3.ProductName = "HDD";
            order3.ProductCost = 5000;
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
            order4.ProductName = "Books";
            order4.ProductCost = 2000;
            odc.Orders.Add(order4);

            Order order5 = new Order();
            order5.Id = Guid.NewGuid();
            order5.customer = aakash;
            order5.customerId = aakash.Id;
            order5.ProductName = "Peripherals";
            order5.ProductCost = 2500;
            odc.Orders.Add(order5);

            List<Order> aakashorder = new List<Order>();
            aakashorder.Add(order4);
            aakashorder.Add(order5);

            odc.SaveChanges();
        }
    }
}
