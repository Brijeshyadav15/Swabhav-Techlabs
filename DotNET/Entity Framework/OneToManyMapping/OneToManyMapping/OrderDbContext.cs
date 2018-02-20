using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyMapping
{
    class OrderDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<LineItem> LineItem { get; set; }
        public DbSet<Product> Product { get; set; }

        public OrderDbContext()
        {
            this.Database.Log = Console.WriteLine;
            this.Database.Log = logInfo => FileLogger.Log(logInfo);
        }
    }

    public class FileLogger
    {
        public static void Log(string logInfo)
        {
            File.AppendAllText("Log.txt", logInfo);
        }
    }
}
