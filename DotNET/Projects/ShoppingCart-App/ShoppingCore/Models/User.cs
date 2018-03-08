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
        //IEnumerable<Address> addresses, Gender gender,UserType role, IEnumerable<Order> orders,
        public User(Guid id, string name, string email,  int age, string contact, string location, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            //Addresses = addresses;
            Age = age;
            Location = location;
            Contact = contact;
            //Gender = gender;
            //Orders = orders;
            Id = id;
            Name = name;
            Password = password;
            //Role = role;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string ProfilePic { get; set; }
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
