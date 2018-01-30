using System;

namespace AccountPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1;

            account1 = new SavingAccount(101, 1000, "Brijesh");
            account1.deposit(500);
            printDetails(account1);

            account1 = new CurrentAccount(102, 2000, "Akash");
            account1.withdraw(2000);
            printDetails(account1);

        }

        public static void printDetails(Account acc)
        {
            Console.WriteLine("Account number :" + acc.AccountNum);
            Console.WriteLine("Account number :" + acc.Name);
            Console.WriteLine("Account number :" + acc.Balance);
        }
    }
}
