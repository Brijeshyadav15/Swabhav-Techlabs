package com.techlabs.interfaceexample;

public class Customer implements Icrudable {

	@Override
	public void create() {
		System.out.println("Customer is creating");
	}

	@Override
	public void read() {
		System.out.println("Customer is reading");
	}

	@Override
	public void update() {
		System.out.println("Customer is updating");
	}

	@Override
	public void delete() {
		System.out.println("Customer is deleting");
	}

}
