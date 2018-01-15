package com.techlabs.structural.decorator;

public class GmailDecorator extends DecoratorBase implements IAccount {

	public GmailDecorator(IAccount iaccount) {
		super(iaccount);
	}

	@Override
	public void deposit(double amount) {
		iaccount.deposit(amount);
		System.out.println("Emailing the Depositing Details ");
		System.out.println("Current Account Balance  " + iaccount.getAmount());
	}

	@Override
	public void withdraw(double amount) {
		iaccount.withdraw(amount);
		System.out.println("Emailing the Withdrawing Details ");
		System.out.println("Current Account Balance  " + iaccount.getAmount());
	}

	@Override
	public double getAmount() {
		return iaccount.getAmount();
	}
}
