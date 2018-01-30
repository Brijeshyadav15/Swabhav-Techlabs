using System;
namespace AccountPolymorphism
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int accountnum, int balance, string name) : base(accountnum, balance, name)
        {
        }

        public override void withdraw(int amount)
        {
            if (Balance >= 1000 && Balance - amount >= 1000)
                Balance = Balance - amount;
            else
                Console.WriteLine("Withdraw failed.Minimum Balance is less");
        }
    }
}
