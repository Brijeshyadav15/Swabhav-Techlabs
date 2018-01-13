package com.techlabs.creational.simplefactory;

public class Bmw implements IAutomobile {

	@Override
	public void starts() {
		System.out.println("BMW Starts");

	}

	@Override
	public void stops() {
		System.out.println("BMW Stops");

	}

}
