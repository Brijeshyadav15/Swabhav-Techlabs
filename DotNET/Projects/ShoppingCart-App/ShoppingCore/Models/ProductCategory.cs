using ShoppingCore.Entity_Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    public class ProductCategory : Entity
    {
        public ProductCategory()
        {
        }

        public ProductCategory(Guid id, string name, DateTime createdDate)
        {
            Id = id;
            Name = name;
            CreatedDate = createdDate;
        }

        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
