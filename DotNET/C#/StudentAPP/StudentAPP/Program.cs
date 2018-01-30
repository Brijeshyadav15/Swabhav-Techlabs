using System;

namespace StudentAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Brijesh", 1, 4000);
            Account account2 = new Account("Akash", 2, 5000);

            Console.WriteLine(account2.AccountNum);
            Console.WriteLine(account2.Name);
            Console.WriteLine(account2.Balance);
            account1.Withdraw(6000);

            Console.WriteLine(account1.AccountNum);
            Console.WriteLine(account1.Name);
            Console.WriteLine(account1.Balance);
            account1.Deposit(2000);


        }
    }
}
