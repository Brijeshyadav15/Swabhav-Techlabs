using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity_App
{
    class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }

        public EmployeeDbContext()
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
