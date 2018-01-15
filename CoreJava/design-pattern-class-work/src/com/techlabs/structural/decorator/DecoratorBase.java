package com.techlabs.structural.decorator;

abstract class DecoratorBase {
	protected IAccount iaccount;

	public DecoratorBase(IAccount iaccount) {
		this.iaccount = iaccount;
	}
}
