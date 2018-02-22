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

        public User(Guid id, string name, string password, UserType role)
        {
            Id = id;
            Name = name;
            Password = password;
            Role = role;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public UserType Role { get; set; }
    }
}
