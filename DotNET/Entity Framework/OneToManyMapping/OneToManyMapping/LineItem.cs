using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMapping
{
    class LineItem
    {
        public LineItem()
        {
        }

        public LineItem(Guid id, Guid order, Guid product, int quantity, int tot)
        {
            Id = id;
            OrderId = order;
            ProductId = product;
            Quantity = quantity;
            Total = tot;
        }

        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
    }
}
