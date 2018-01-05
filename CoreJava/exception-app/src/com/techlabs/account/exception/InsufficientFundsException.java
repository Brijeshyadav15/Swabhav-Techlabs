package com.techlabs.account.exception;

public class InsufficientFundsException extends RuntimeException {
	private Account account;
	private double amount;

	public double getAmount() {
		return amount;
	}

	public InsufficientFundsException(Account account, double amount) {
		this.account = account;
		amount = amount;
	}

	@Override
	public String getMessage() {
		return account.getName() + " tried to withdraw " + getAmount()
				+ "\nBut " + account.getName() + " has balance "
				+ account.getBalance()
				+ "\nMinimum Balance should be more than 500.";
	}
}
