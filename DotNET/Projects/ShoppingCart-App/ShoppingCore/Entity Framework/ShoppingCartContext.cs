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
