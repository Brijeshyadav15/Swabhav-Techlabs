package com.techlabs.structural.decorator.test;

import com.techlabs.structural.decorator.Account;
import com.techlabs.structural.decorator.LogDecorator;

public class TestAccount {
	public static void main(String[] args) {
		LogDecorator accountLogger = new LogDecorator(new Account(1,
				"Brijesh", 1000));
		accountLogger.deposit(1000);
		//accountLogger.withdraw(100);
	}
}
