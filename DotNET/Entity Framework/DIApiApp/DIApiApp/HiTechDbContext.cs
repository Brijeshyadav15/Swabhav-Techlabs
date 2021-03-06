﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;


namespace DIApiApp
{
    class HiTechDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public HiTechDbContext() : base("name=HiTechDbContext")
        {
            this.Database.Log = Console.WriteLine;
            //this.Database.Log = logInfo => FileLogger.Log(logInfo);
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
