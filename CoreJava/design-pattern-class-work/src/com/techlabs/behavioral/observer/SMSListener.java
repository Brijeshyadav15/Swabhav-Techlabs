package com.techlabs.behavioral.observer;

public class SMSListener implements IAccountListener {

	@Override
	public void onBalanceChange(Account account) {
		System.out
				.println("SMS Listeer invoked. Sending message of Balance Change");
		System.out.println("Account Name: " + account.getName());
		System.out.println("Account Number: " + account.getAccountno());
		System.out.println("Account Balance: " + account.getAmount());

	}

}
