package com.techlabs.account;

public abstract class Account {
	protected int accno;
	protected String name;
	protected double balance;

	public int getAccno() {
		return accno;
	}

	public String getName() {
		return name;
	}

	public double getBalance() {
		return balance;
	}

	protected Account(int accno, String name, double amount) {
		this.accno = accno;
		this.name = name;
		this.balance = amount;
	}
	
	public void deposit(double amount)
	{
		this.balance += amount;
	}
	public abstract void withdraw(double amount);
}
