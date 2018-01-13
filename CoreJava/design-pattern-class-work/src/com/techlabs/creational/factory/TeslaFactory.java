package com.techlabs.creational.factory;

public class TeslaFactory implements IAutoFactory {
	
	public IAutomobile make() {
		return new Tesla();
	}

}
