using System;
using ShoppingCore.Entity_Framework.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    class Order : Entity
    {
        public Order()
        {
        }

        public Order(Guid id, DateTime date, Guid customerid, double total,OrderStatus orderstatus)
        {
            Id = id;
            Date = date;
            CustomerId = customerid;
            OrderTotal = total;
            OrderStatus = orderstatus;
        }

        public DateTime Date { get; set; }
        public Guid CustomerId { get; set; }
        public double OrderTotal { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
