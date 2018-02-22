using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    class Admin
    {
        public Admin()
        {
        }

        public Admin(Guid id, string name, string email, string address, int age, Gender gender, string contact, string location, IEnumerable<Product> product)
        {
            Id = id;
            Name = name;
            Age = age;
            Location = location;
            Contact = contact;
            Gender = gender;
            Products = product;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Contact { get; set; }
        public string Location { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
