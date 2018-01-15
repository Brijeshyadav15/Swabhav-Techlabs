package com.techlabs.structural.decorator.test;

import com.techlabs.structural.decorator.Account;
import com.techlabs.structural.decorator.LogDecorator;
import com.techlabs.structural.decorator.GmailDecorator;
import com.techlabs.structural.decorator.SMSDecorator;

public class TestSMSDecorator {
	public static void main(String[] args) {
		SMSDecorator account1 = new SMSDecorator(new GmailDecorator(
				new LogDecorator(new Account(1, "Brijesh", 1500))));
		account1.deposit(1000);
		account1.withdraw(1000);

		SMSDecorator account2 = new SMSDecorator(
				new Account(1, "Brijesh", 3500));
		account2.deposit(2000);
		
	}
}
