using ShoppingCore.Entity_Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    class Address : Entity
    {
        public Address()
        {
        }

        public Address(Guid id, Guid customerId, string streetaddress, string city, string pincode)
        {
            Id = id;
            CustomerId = customerId;
            StreetAddress = streetaddress;
            City = city;
            Pincode = pincode;
        }
 
        public Guid CustomerId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
    }
}
