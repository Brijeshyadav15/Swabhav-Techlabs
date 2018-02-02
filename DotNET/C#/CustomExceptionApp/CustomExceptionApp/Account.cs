using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomExceptionApp
{
    class Account
    {
        private String _name;
        private double _balance;
        private int _id;
        private int _accountholder;

        public Account(int id, String name) : this(id, name, 500)
        {
            _id = id;
            _name = name;
        }

        public Account(int id, String name, double balanace)
        {
            _id = id;
            _balance = balanace;
            _name = name;
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public int AccountHolder
        {
            get
            {
                return _accountholder;
            }
        }

        public double Balance
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

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public void withdraw(double amount)
        {
            Type type = typeof(Account);

            if (Balance >= 500 && Balance - amount >= 500)
                Balance = Balance - amount;
            else
                throw new InsufficientFundsException(String.Format("{0} tried to withdraw {1} but {0} has balance {2} . Minimum Balance should be more than 500", Name, amount, Balance));
        }


        public String GetAccountHolders()
        {
            return "Number of Account Holders :" + AccountHolder;
        }

        public override string ToString()
        {
            return " Id\t:" + Id + "\n Name\t:" + Name + " \n Balance:" + Balance + "\n";
        }

    }
}
