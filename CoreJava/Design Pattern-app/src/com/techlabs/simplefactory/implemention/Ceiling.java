package com.techlabs.simplefactory.implemention;

public class Ceiling implements IFan {

	@Override
	public void switchOn() {
		System.out.println("Ceiling Fan switched On");
	}

	@Override
	public void switchOff() {
		System.out.println("Ceiling Fan switched OFF");
	}

}
