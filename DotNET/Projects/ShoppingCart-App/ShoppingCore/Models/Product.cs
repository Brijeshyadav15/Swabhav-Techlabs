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

        public Product(Guid id, string name, double price, ProductCategory productCategory, ProductCategory baseCategory)
        {
            Id = id;
            Name = name;
            Price = price;
            ProductCategory = productCategory;
            parentCategory = baseCategory;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public string ProductImage { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ProductCategory parentCategory { get; set; }
    }
}
