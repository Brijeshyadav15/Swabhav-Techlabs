using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    class Purchase
    {
        public Purchase()
        {
        }

        public Purchase(Guid id, string name, DateTime purchaseDate,List<Product> products, PurchaseStatus status)
        {
            Id = id;
            Name = name;
            PurchaseDate = purchaseDate;
            Products = products;
            PurchaseStatus = status;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime PurchaseDate { get; set; }
        public List<Product> Products { get; set; }
        public PurchaseStatus PurchaseStatus { get; set; }

    }
}
