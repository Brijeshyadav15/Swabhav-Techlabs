using System;

namespace ReflectionApp
{
    abstract class Account
    {
        public int accountnum;
        public int balance;
        public String name;

        public Account()
        {
        }

        public Account(int accountnum, int balance, String name)
        {
            this.accountnum = accountnum;
            this.balance = balance;
            this.name = name;
        }

        public int AccountNum
        {
            get
            {
                return accountnum;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public String Name
        {
            get
            {
                return name;
            }
        }

        public void deposit(int amount)
        {
            this.balance += amount;
        }

        public abstract void withdraw(int amount);

    }
}

