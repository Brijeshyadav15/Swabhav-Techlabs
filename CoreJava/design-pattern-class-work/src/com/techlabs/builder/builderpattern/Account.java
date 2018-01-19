package com.techlabs.builder.builderpattern;

public class Account {
	private int id;
	private String customer;
	private AccountType type;
	private boolean hasTakenLoan;

	public int getId() {
		return id;
	}

	public String getCustomer() {
		return customer;
	}

	public AccountType getType() {
		return type;
	}

	public boolean hasTakenLoan() {
		return hasTakenLoan;
	}

	public void setId(int id) {
		this.id = id;
	}

	public void setCustomer(String customer) {
		this.customer = customer;
	}

	public void setType(AccountType type) {
		this.type = type;
	}

	public void setHasTakenLoan(boolean loan) {
		this.hasTakenLoan = loan;
	}

	@Override
	public String toString() {
		return "Account Number \t\t\t:" + getId() + "\nAccount Type \t\t\t:"
				+ getType() + "\nCustomer Name \t\t\t:" + getCustomer()
				+ "\nCustomer has taken Loan?\t:" + hasTakenLoan() + "\n";
	}
}
