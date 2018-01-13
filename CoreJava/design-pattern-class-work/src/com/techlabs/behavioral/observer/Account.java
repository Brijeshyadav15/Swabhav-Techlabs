package com.techlabs.behavioral.observer;

import java.util.ArrayList;
import java.util.List;

public class Account {
	private String name;
	private int Accountno;
	private double amount;
	private List<IAccountListener> subscriberlisteners = new ArrayList<IAccountListener>();

	public Account(String name, int accountno, double amount) {
		this.name = name;
		Accountno = accountno;
		this.amount = amount;
	}

	public String getName() {
		return name;
	}

	public int getAccountno() {
		return Accountno;
	}

	public double getAmount() {
		return amount;
	}

	public List<IAccountListener> getListener() {
		return subscriberlisteners;
	}

	public void withdraw(double withdrawamount) {
		notifyListener();
		this.amount -= withdrawamount;
	}

	public void deposit(double withdrawamount) {
		notifyListener();
		this.amount += withdrawamount;
	}

	public void addListener(IAccountListener addlistener) {
		subscriberlisteners.add(addlistener);
	}

	public void notifyListener() {
		for (IAccountListener listener : subscriberlisteners) {
			listener.onBalanceChange(this);
		}
	}

}
