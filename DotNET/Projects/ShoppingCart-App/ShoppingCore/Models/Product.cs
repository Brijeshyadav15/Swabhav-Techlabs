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

        public Product(Guid id, string name, double price,ProductCategory productCategory, ProductCategory subCategory)
        {
            Id = id;
            Name = name;
            Price = price;
            ProductCategory = productCategory;
            ProductSubCategory = subCategory;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ProductCategory ProductSubCategory { get; set; }
    }
}
