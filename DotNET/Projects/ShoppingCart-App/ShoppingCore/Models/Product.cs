using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    class Product
    {
        public Product()
        {
        }

        public Product(Guid id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
