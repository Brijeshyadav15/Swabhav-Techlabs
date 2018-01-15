package com.techlabs.structural.decorator;

public class Account implements IAccount {
	private int id;
	private String name;
	private double amount;

	public Account(int id, String name, double amount) {
		this.id = id;
		this.name = name;
		this.amount = amount;
	}

	public int getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public double getAmount() {
		return amount;
	}

	public void setAmount(double amount) {
		this.amount = amount;
	}

	@Override
	public void deposit(double amount) {
		this.amount = getAmount() - amount;
	}

	@Override
	public void withdraw(double amount) {
		this.amount = getAmount() + amount;
	}

}
