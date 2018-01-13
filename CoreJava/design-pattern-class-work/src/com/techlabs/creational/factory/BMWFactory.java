package com.techlabs.creational.factory;

public class BMWFactory implements IAutoFactory{

	@Override
	public IAutomobile make() {
		return new Bmw();
	}

}
