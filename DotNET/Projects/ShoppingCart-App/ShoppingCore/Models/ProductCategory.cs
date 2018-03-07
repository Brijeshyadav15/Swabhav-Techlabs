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

        public ProductCategory(Guid id, string name, DateTime createdDate,ProductCategory parentCategory)
        {
            Id = id;
            Name = name;
            CreatedDate = createdDate;
            ParentCategory = parentCategory;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public ProductCategory ParentCategory { get; set; }

    }
}
