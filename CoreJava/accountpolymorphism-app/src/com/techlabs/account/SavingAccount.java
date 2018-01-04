package com.techlabs.account;

public class SavingAccount extends Account {

	public SavingAccount(int accno, String name, double amount) {
		super(accno, name, amount);
	}

	@Override
	public void withdraw(double amount) {
		if (this.getBalance() >= 500 && this.getBalance() - amount >= 500)
			this.balance = this.balance - amount;
	}

}
