﻿using System;

namespace AccountPolymorphism
{
    abstract class Account
    {
        protected int _accountnum;
        protected int _balance;
        protected String _name;

        protected Account(int accountnum, int balance, String name)
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
