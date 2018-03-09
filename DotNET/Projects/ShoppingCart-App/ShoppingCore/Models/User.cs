using ShoppingCore.Entity_Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    public class User : Entity 
    {
        public User()
        {
        }
        //IEnumerable<Address> addresses, IEnumerable<Order> orders,
        public User(Guid id, string name, string email,  int age, Gender gender , string contact, string location, string password, UserType role)
        {
            Id = id;
            Name = name;
            Email = email;
            Age = age;
            Location = location;
            Contact = contact;
            Password = password;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string ProfilePic { get; set; }
        public List<Address> Addresses { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Contact { get; set; }
        public string Location { get; set; }
        public List<Order> Orders { get; set; }
        public string Password { get; set; }
        public UserType Role { get; set; }
    }
}
