using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMapping
{
    class Order
    {
        public Guid Id { get; set; }
        public Customer customer { get; set; }
        public Guid customerId { get; set; }
        public List<LineItem> LineItems { get; set; }
        public int OrderTotal { get; set; }
    }
}
