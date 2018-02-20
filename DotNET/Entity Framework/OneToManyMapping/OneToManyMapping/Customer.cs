using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMapping
{
    class Customer
    {
        public Guid Id { get; set; }
        public List<Order> Order { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
    }
}
