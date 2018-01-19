package com.techlabs.builder.test;

import com.techlabs.builder.builderpattern.Account;
import com.techlabs.builder.builderpattern.AccountBuilder;
import com.techlabs.builder.builderpattern.AccountType;

public class TestAccount {
	public static void main(String[] args) {
		Account acc1 = new AccountBuilder().withAccountNumber(101).build();

		Account acc2 = new AccountBuilder()
						.withAccountNumber(102)
						.withType(AccountType.SAVINGS)
						.withCustomer("Brijesh")
						.hasLoan(true).build();

		System.out.println(acc1.toString());
		System.out.println(acc2.toString());

	}
}
