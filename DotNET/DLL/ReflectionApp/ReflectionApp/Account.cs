using System;

namespace ReflectionApp
{
    abstract class Account
    {
        public int _accountnum;
        public int _balance;
        public String _name;

        public Account()
        {
        }

        public Account(int accountnum, int balance, String name)
        {
            _accountnum = accountnum;
            _balance = balance;
            _name = name;
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

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public void deposit(int amount)
        {
            _balance += amount;
        }

        public abstract void withdraw(int amount);

    }
}

