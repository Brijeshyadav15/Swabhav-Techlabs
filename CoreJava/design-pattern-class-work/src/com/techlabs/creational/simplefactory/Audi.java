package com.techlabs.creational.simplefactory;

public class Audi implements IAutomobile {

	@Override
	public void starts() {
		System.out.println("Audi Starts");

	}

	@Override
	public void stops() {
		System.out.println("Audi Stops");

	}

}
