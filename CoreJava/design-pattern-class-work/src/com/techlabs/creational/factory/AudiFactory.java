package com.techlabs.creational.factory;

public class AudiFactory implements IAutoFactory {

	@Override
	public IAutomobile make() {
		return new Audi();
	}

}
