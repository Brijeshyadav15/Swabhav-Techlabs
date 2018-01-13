package com.techlabs.behavioral.observer.test;

import com.techlabs.behavioral.observer.Account;
import com.techlabs.behavioral.observer.EmailListener;
import com.techlabs.behavioral.observer.SMSListener;

public class TestObserver {
	public static void main(String[] args) {

		Account account = new Account("Brijesh", 1234, 5000);
		account.addListener(new SMSListener());
		account.addListener(new EmailListener());
		account.deposit(1000);

		Account account1 = new Account("Akash", 4567, 5000);
		account1.addListener(new EmailListener());
		account1.withdraw(1000);
	}
}
