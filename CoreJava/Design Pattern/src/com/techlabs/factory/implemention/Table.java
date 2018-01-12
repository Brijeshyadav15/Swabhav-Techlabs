package com.techlabs.factory.implemention;

public class Table implements IFan {

	@Override
	public void switchOn() {
		System.out.println("Table Fan switched On");
	}

	@Override
	public void switchOff() {
		System.out.println("Table Fan switched OFF");
	}

}
