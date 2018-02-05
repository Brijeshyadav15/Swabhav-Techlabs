using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountEventApp
{
    delegate void DBalanceModified(Account account);
    class Account
    {
        private int _id;
        private int _balance;
        private String _name;
        public event DBalanceModified OnBalanceChanged = null;

        public Account(int id, int balance, String name)
        {
            _id = id;
            _balance = balance;
            _name = name;
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

        public void Desposit(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("Deposit Completed . Balance is:" + Balance);
            if (OnBalanceChanged != null)
                OnBalanceChanged(this);
        }

        public void Withdraw(int amount)
        {
            if (Balance - amount >= 500)
            {
                Balance = Balance - amount;
                Console.WriteLine("Withdraw Completed . Balance is:" + Balance);
                if (OnBalanceChanged != null)
                    OnBalanceChanged(this);
            }
        }
    }
}
