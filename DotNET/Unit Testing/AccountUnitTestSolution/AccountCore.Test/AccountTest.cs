using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountCore;
using AccountAPP;

namespace AccountCore.Test
{

    [TestClass]
    public class AccountTest
    {

        [TestMethod]
        public void Should_Instantiate_Through_Constructor()
        {
            //Arrange && ACT
            Account acc = new Account("ABC", 1001, 500);

            //Assert
            Assert.AreEqual(acc.AccountNum, 1001);
            Assert.AreEqual(acc.Name, "ABC");
            Assert.AreEqual(acc.Balance, 500);
        }

        [TestMethod]
        public void Should_Make_A_Deposit()
        {
            //Arrange && ACT
            Account acc = new Account("ABC", 1001, 500);

            //Assert
            var balance = acc.Balance;
            acc.Deposit(1000);
            balance += 1000;

            Assert.AreEqual(acc.Balance, balance);
        }

        [TestMethod]
        public void Should_Make_A_Withdraw()
        {
            //Arrange && ACT
            Account acc = new Account("ABC", 1001, 1500);

            //Assert
            var balance = acc.Balance;
            acc.Withdraw(1000);
            balance -= 1000;
            Assert.AreEqual(acc.Balance, balance);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cannot_Withdraw_More_Than_Balance()
        {
            //Arrange && ACT
            Account acc = new Account("ABC", 1001, 1500);

            //Assert
            var balance = acc.Balance;
            acc.Withdraw(2000);

            Assert.AreEqual(acc.Balance, balance);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cannot_Withdraw_More_Than_Minimum_Balance()
        {
            //Arrange && ACT
            Account acc = new Account("ABC", 1001, 1500);

            //Assert
            var balance = acc.Balance;
            acc.Withdraw(1200);

            //Assert
            Assert.AreEqual(acc.Balance, balance);
        }
    }
}
