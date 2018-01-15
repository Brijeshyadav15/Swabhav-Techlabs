package com.techlabs.structural.decorator.test;

import com.techlabs.structural.decorator.Account;
import com.techlabs.structural.decorator.LogDecorator;
import com.techlabs.structural.decorator.GmailDecorator;

public class TestGmailDecorator {
	public static void main(String[] args) {
		LogDecorator account1 = new LogDecorator(new GmailDecorator(
				new Account(1, "Brijesh", 1500)));
		account1.deposit(1000);

		GmailDecorator account2 = new GmailDecorator(new Account(1, "Brijesh",
				3500));
		account2.deposit(2000);

	}
}
