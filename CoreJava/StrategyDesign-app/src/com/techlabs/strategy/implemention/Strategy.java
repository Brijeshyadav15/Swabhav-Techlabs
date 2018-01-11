package com.techlabs.strategy.implemention;

public class Strategy {
	private IStrategy istrategy;

	public Strategy(IStrategy istrategy) {
		this.istrategy = istrategy;
	}

	public int executeStrategy(int num1, int num2) {
		return istrategy.doOperation(num1, num2);
	}
}
