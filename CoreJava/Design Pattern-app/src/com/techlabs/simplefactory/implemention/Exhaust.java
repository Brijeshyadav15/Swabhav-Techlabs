package com.techlabs.simplefactory.implemention;

public class Exhaust implements IFan {

	@Override
	public void switchOn() {
		System.out.println("Exhaust Fan switched On");
	}

	@Override
	public void switchOff() {
		System.out.println("Exhaust Fan switched OFF");
	}

}
