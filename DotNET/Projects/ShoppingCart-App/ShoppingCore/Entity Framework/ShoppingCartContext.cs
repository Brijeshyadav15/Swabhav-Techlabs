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
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<LineItem> LineItems { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public ShoppingCartContext() : base("ShoppingCartContext")
        {
            this.Database.Log = logInfo => FileLogger.Log(logInfo);
        }

        public class FileLogger
        {
            public static void Log(string logInfo)
            {
                File.AppendAllText("Log.txt", logInfo);
            }
        }
    }
}
