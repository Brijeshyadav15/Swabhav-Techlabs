package com.techlabs.account.test;

import com.techlabs.account.*;

public class TestAccount {

	public static void main(String[] args) {
		Account account = new Account(123, "Brijesh");
		Account account1 = new Account(126, "Aakash", 400);
		Account account2 = new Account(128, "Aakash11", 400);
		// account.withdraw(500);

		account.deposit(500);
		account1.deposit(300);

		account2.deposit(300);
		System.out.println(account.toString());
		System.out.println(account1.toString());
		System.out.println(account2.getAccountHolders());
		System.out.println(Account.getHeadCount());

	}

}
