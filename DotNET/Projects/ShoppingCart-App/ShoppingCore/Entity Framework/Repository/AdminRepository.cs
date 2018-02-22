using ShoppingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Entity_Framework.Repository
{
    class AdminRepository : IRepository<Admin>
    {
        public void Add(Admin entity)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.Admins.Add(entity);
            shp.SaveChanges();
        }

        public void Delete(Guid entityId)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var admin = shp.Admins.Single(c => c.Id == entityId);
            shp.Admins.Remove(admin);
            shp.SaveChanges();
        }

        public IQueryable<Admin> Get()
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            return shp.Admins;
        }

        public Admin GetById(Guid entityId)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            return shp.Admins.Single(c => c.Id == entityId);
        }

        public void Update(Admin entity)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var customer = shp.Admins.Single(c => c.Id == entity.Id);
            shp.Admins.Remove(customer);
            shp.Admins.Add(entity);
            shp.SaveChanges();
        }
    }
}
