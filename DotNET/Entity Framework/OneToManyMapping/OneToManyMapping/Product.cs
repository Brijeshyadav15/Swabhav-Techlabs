using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMapping
{
    class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int ProductCost { get; set; }
    }
}
