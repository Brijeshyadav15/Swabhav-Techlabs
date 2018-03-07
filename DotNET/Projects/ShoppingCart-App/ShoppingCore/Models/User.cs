using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    class User
    {
        public User()
        {
        }

        public User(Guid id, string name, string email, IEnumerable<Address> addresses, int age, Gender gender, string contact, string location, IEnumerable<Order> orders,string password,UserType role)
        {
            Id = id;
            Name = name;
            Email = email;
            Addresses = addresses;
            Age = age;
            Location = location;
            Contact = contact;
            Gender = gender;
            Orders = orders;
            Id = id;
            Name = name;
            Password = password;
            Role = role;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Contact { get; set; }
        public string Location { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public string Password { get; set; }
        public UserType Role { get; set; }
    }
}
