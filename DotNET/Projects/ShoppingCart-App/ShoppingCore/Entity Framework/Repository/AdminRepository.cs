using ShoppingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Entity_Framework.Repository
{
    class AdminRepository : IRepository<User>
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
            var admin = shp.Users.Single(c => c.Id == entityId);
            shp.Users.Remove(admin);
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
            return shp.Users.Single(c => c.Id == entityId);
        }

        public void Update(User entity)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var customer = shp.Users.Single(c => c.Id == entity.Id);
            shp.Users.Remove(customer);
            shp.Users.Add(entity);
            shp.SaveChanges();
        }

        public void AddProduct(Product product)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.Products.Add(product);
            shp.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.Products.Remove(product);
            shp.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var oldProduct = shp.Products.Single(c => c.Id == product.Id);
            shp.Products.Remove(oldProduct);
            shp.Products.Add(product);
            shp.SaveChanges();
        }

        public void AddProductCategory(ProductCategory productCategory)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.ProductCategorys.Add(productCategory);
            shp.SaveChanges();
        }

        public void DeleteProductCategory(ProductCategory productCategory)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            shp.ProductCategorys.Remove(productCategory);
            shp.SaveChanges();
        }

        public void UpdateProductCategory(ProductCategory productCategory)
        {
            ShoppingCartContext shp = new ShoppingCartContext();
            var oldProductCategory = shp.ProductCategorys.Single(c => c.Id == productCategory.Id);
            shp.ProductCategorys.Remove(oldProductCategory);
            shp.ProductCategorys.Add(productCategory);
            shp.SaveChanges();
        }
    }
}
