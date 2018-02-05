using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountEventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, 2000, "Brijesh");
            account.OnBalanceChanged += SendEmail;
            account.OnBalanceChanged += SendSMS;

            account.Withdraw(1000);
        }

        private static void SendEmail(Account account)
        {
            Console.WriteLine("Sending Email");
        }

        private static void SendSMS(Account account)
        {
            Console.WriteLine("Sending SMS");
        }
    }
}
