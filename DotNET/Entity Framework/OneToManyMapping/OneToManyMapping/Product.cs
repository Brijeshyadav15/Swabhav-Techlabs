using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMapping
{
    class Product
    {
        public Product()
        {
        }

        public Product(Guid id, string name, int cost)
        {
            Id = id;
            ProductName = name;
            ProductCost = cost;
        }
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int ProductCost { get; set; }
    }
}
