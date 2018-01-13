package com.techlabs.creational.simplefactory;

public class Tesla implements IAutomobile {

	@Override
	public void starts() {
		System.out.println("Tesla Starts");

	}

	@Override
	public void stops() {
		System.out.println("Tesla Stops");

	}

}
