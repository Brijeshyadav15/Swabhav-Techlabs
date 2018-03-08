using ShoppingCore.Entity_Framework.Repository;
using ShoppingCore.Entity_Framework.Specification;
using ShoppingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Service
{
    class AuthenicationService
    {
        public bool CheckLogin(string username,string password)
        {
            UserSearchCriteria criteria = new UserSearchCriteria{ Email  = username, Password = password };

            EntityFrameworkRepository<User> efr = new EntityFrameworkRepository<User>();
            User user = efr.Find(new FindByEmailSpecification(criteria)).SingleOrDefault();

            if (user == null)
                return false;
            else
                return true;
        }

        public User GetUser(string username, string password)
        {
            UserSearchCriteria criteria = new UserSearchCriteria { Email = username, Password = password };
            EntityFrameworkRepository<User> efr = new EntityFrameworkRepository<User>();
            User user = efr.Find(new FindByEmailSpecification(criteria)).SingleOrDefault();

            if (user == null)
                return null;
            else
                return user;
        }
    }
}
