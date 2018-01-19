package com.techlabs.builder.builderpattern;

public class AccountBuilder {
	private int id;
	private String customer;
	private AccountType type;
	private boolean loan;

	public AccountBuilder withAccountNumber(int id) {
		this.id = id;
		return this;
	}

	public AccountBuilder withType(AccountType type) {
		this.type = type;
		return this;
	}

	public AccountBuilder withCustomer(String customer) {
		this.customer = customer;
		return this;
	}

	public AccountBuilder hasLoan(boolean loan) {
		this.loan = loan;
		return this;
	}

	public Account build() {
		Account account = new Account();
		account.setId(this.id);
		account.setCustomer(this.customer);
		account.setType(this.type);
		account.setHasTakenLoan(this.loan);
		return account;
	}
}
