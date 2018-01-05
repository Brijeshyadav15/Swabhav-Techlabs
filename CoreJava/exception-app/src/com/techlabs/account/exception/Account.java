package com.techlabs.account.exception;

public class Account {
	private final String name;
	private double balance;
	private final int id;
	private static int accountholder;

	static {
		accountholder = 0;
	}

	public Account(int id, String name) {
		this(id, name, 500);
	}

	public Account(int id, String name, double balance) {
		this.id = id;
		this.name = name;
		this.balance = balance;
		accountholder++;
	}

	public String getName() {
		return name;
	}

	public static int getAccountholder() {
		return accountholder;
	}

	public double getBalance() {
		return balance;
	}

	public int getId() {
		return id;
	}

	public void deposit(double amount) {
		this.balance = this.getBalance() + amount;
	}

	public void withdraw(double amount) {
		if (this.getBalance() >= 500 && this.getBalance() - amount >= 500)
			this.balance = this.getBalance() - amount;
		else
			throw new InsufficientFundsException(this,amount);
	}

	public String getAccountHolders() {
		return "Number of Account Holders :" + getAccountholder();
	}

	public static String getHeadCount() {
		return "Number of Head Count :" + getAccountholder();
	}

	@Override
	public String toString() {
		return " Id\t:" + getId() + "\n Name\t:" + getName() + " \n Balance:"
				+ getBalance() + "\n";
	}
}
