package com.techlabs.behavioral.observer;

public class EmailListener implements IAccountListener {

	@Override
	public void onBalanceChange(Account account) {
		System.out
				.println("Email Listener invoked. Sending message of Balance Change");
		System.out.println("Account Name: " + account.getName());
		System.out.println("Account Number: " + account.getAccountno());
		System.out.println("Account Balance: " + account.getAmount());

	}

}
