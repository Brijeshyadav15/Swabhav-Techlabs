package com.techlabs.account;

public class CurrentAccount extends Account {

	public CurrentAccount(int accno, String name, double amount) {
		super(accno, name, amount);
	}

	@Override
	public void withdraw(double amount) {
		if (this.getBalance() >= 1000 && this.getBalance() - amount >= 1000)
			this.balance = this.balance - amount;

	}

}
