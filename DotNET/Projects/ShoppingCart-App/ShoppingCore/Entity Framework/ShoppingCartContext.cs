using ShoppingCore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Entity_Framework
{
    class ShoppingCartContext : DbContext
    {
        public ShoppingCartContext() : base("ShoppingCartContext")
        {
            //Database.SetInitializer<ShoppingCartContext>(null);
            this.Database.Log = logInfo => FileLogger.Log(logInfo);
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //  modelBuilder.HasDefaultSchema("hitech");
        //}

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public class FileLogger
        {
            public static void Log(string logInfo)
            {
                try
                {
                    File.AppendAllText("Log.txt", logInfo);
                }
                catch
                {
                }
            }
        }
    }
}
