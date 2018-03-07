using ShoppingCore.Entity_Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    class LineItem : Entity
    {
        public LineItem()
        {
        }

        public LineItem(Guid id, Guid orderid, Guid productid, int quantity)
        {
            Id = id;
            OrderId = orderid;
            Quantity = quantity;
            ProductId = productid;
        }

        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }


    }
}
