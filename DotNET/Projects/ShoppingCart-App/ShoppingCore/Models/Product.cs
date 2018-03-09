using ShoppingCore.Entity_Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    public class Product : Entity
    {
        public Product()
        {
        }

        public Product(Guid id, string name, double price,Guid productcategory)
        {
            Id = id;
            Name = name;
            Price = price;
            ProductCategory = productcategory;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public string ProductImage { get; set; }
        public Guid ProductCategory { get; set; }
    }
}
