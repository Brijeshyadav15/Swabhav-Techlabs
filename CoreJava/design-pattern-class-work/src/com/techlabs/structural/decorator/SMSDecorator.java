package com.techlabs.structural.decorator;

public class SMSDecorator extends DecoratorBase implements IAccount {

	public SMSDecorator(IAccount iaccount) {
		super(iaccount);
	}

	@Override
	public void deposit(double amount) {
		iaccount.deposit(amount);
		System.out.println("Messaging the Depositing Details ");
		System.out.println("Current Account Balance  " + iaccount.getAmount());
	}

	@Override
	public void withdraw(double amount) {
		iaccount.withdraw(amount);
		System.out.println("Messaging the Withdraw Details ");
		System.out.println("Current Account Balance  " + iaccount.getAmount());

	}

	@Override
	public double getAmount() {
		return iaccount.getAmount();
	}

}
