using System;

namespace AccountAPP
{
    public class Account
    {
        private String _name;
        private int _accountnum;
        private int _balance;
        private static readonly int MINIMUM_BALANCE = 500;

        public Account(String name, int accountnum, int balance)
        {
            _name = name;
            _accountnum = accountnum;
            _balance = balance;
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public int AccountNum
        {
            get
            {
                return _accountnum;
            }
        }

        public int Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public void Withdraw(int amount)
        {
            if (Balance - amount >= MINIMUM_BALANCE)
            {
                Balance = Balance - amount;
                Console.WriteLine("Withdraw Unsuccessful. Main Balance is " + Balance);
            }
            else
            {
                throw new Exception("Your Balance is low. Withdraw not completed");
            }
        }

        public void Deposit(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("Deposit Successful. Main Balance is " + Balance);
        }
    }
}
