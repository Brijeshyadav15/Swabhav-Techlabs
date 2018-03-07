using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    class WishList
    {
        public WishList()
        {
        }

        public WishList(Guid id, string name,List<Product> products)
        {
            Id = id;
            Name = name;
            Products = products;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
