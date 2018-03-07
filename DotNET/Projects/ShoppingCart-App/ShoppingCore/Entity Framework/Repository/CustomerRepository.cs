using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCore.Entity_Framework.Repository;
using ShoppingCore.Models;

namespace ShoppingCore.Entity_Framework.Repository
{
    class CustomerRepository : IRepository<User>
    {
        public void Add(User entity)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.Users.Add(entity);
            shp.SaveChanges();
        }

        public void Delete(Guid entityId)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var customer = shp.Users.Single(c => c.Id == entityId);
            shp.Users.Remove(customer);
            shp.SaveChanges();
        }

        public IQueryable<User> Get()
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            return shp.Users;
        }

        public User GetById(Guid entityId)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var result = shp.Users.Single(c => c.Id == entityId);
            return result;
        }

        public void Update(User entity)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var customer = shp.Users.Single(c => c.Id == entity.Id);
            shp.Users.Remove(customer);
            shp.Users.Add(entity);
            shp.SaveChanges();
        }

        public IQueryable<Order> GetOrders(Guid entityId)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            return shp.Orders.Where(c => c.CustomerId == entityId);
        }

        public Order GetOrderById(Guid entityId)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            return shp.Orders.Single(a => a.Id == entityId);
        }

        public void AddOrder(Order order)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.Orders.Add(order);
            shp.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.Orders.Remove(order);
            shp.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var oldOrder = shp.Orders.Single(c => c.Id == order.Id);
            shp.Orders.Remove(oldOrder);
            shp.Orders.Add(order);            
            shp.SaveChanges();
        }

        public IQueryable<Address> GetAddresses(Guid entityId)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            return shp.Addresses.Where(a => a.CustomerId == entityId);
        }

        public void AddAddress(Address address)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.Addresses.Add(address);
            shp.SaveChanges();
        }

        public Address GetAddressById(Guid entityId)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            return shp.Addresses.Single(a => a.Id == entityId);
        }

        public void DeleteAddress(Address address)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.Addresses.Remove(address);
            shp.SaveChanges();
        }

        public void AddWishList(WishList wishlist)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.WishLists.Add(wishlist);
            shp.SaveChanges();
        }

        public void DeleteWishList(WishList wishlist)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.WishLists.Remove(wishlist);
            shp.SaveChanges();
        }

        public void UpdateWishList(WishList wishlist)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var oldWishlist = shp.WishLists.Single(c => c.Id == wishlist.Id);
            shp.WishLists.Remove(oldWishlist);
            shp.WishLists.Add(wishlist);
            shp.SaveChanges();
        }

    }
}
