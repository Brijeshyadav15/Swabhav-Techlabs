using System;

namespace AccountPolymorphism
{
    class SavingAccount : Account
    {
        public SavingAccount(int accountnum, int balance, string name) : base(accountnum, balance, name)
        {
        }

        public override void withdraw(int amount)
        {
            if (Balance >= 500 && Balance - amount >= 500)
                Balance = Balance - amount;
            else
                Console.WriteLine("Withdraw failed.Minimum Balance is less");
        }
    }
}
