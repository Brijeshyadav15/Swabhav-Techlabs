package com.techlabs.account.test;

import com.techlabs.account.*;

public class TestAccount {
	public static void main(String[] args) {
		Account acc1;
		acc1 = new SavingAccount(101, "Brijesh", 1000);
		acc1.deposit(500);
		printDetails(acc1);

		acc1 = new CurrentAccount(102, "Akash", 2000);
		acc1.withdraw(1000);
		printDetails(acc1);
	}

	public static void printDetails(Account acc) {
		System.out.println("Account number :" + acc.getAccno());
		System.out.println("Holder name :" + acc.getName());
		System.out.println("Account Balance :" + acc.getBalance());
	}
}
