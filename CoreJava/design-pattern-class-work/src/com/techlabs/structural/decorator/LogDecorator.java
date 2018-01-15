package com.techlabs.structural.decorator;

public class LogDecorator extends DecoratorBase implements IAccount {
	public LogDecorator(IAccount account) {
		super(account);
	}

	public void logging(String accmode) {
		System.out.println(accmode + iaccount.getAmount());
	}

	@Override
	public void deposit(double amount) {
		logging("Before Deposit :");
		iaccount.deposit(amount);
		logging("After Deposit :");
	}

	@Override
	public void withdraw(double amount) {
		logging("Before Withdraw :");
		iaccount.withdraw(amount);
		logging("After Withdraw :");
	}

	@Override
	public double getAmount() {
		return iaccount.getAmount();
	}

}
