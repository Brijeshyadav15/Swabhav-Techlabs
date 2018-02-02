using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(2, "Brijesh", 1000);
            account.withdraw(1500);
        }
    }
}
