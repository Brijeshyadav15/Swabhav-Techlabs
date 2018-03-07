using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    class ProductCategory
    {

        public ProductCategory()
        {

        }

        public ProductCategory(Guid id, string name, DateTime createdDate,ProductCategory subCategory)
        {

        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime createdDate { get; set; }


    }
}
