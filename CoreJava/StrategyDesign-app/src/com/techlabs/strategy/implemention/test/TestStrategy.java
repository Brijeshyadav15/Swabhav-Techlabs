package com.techlabs.strategy.implemention.test;

import com.techlabs.strategy.implemention.*;

public class TestStrategy {
	public static void main(String[] args) {
		
		Strategy strategy = new Strategy(new OperationAdd());
		System.out.println("Answer is :" +  strategy.executeStrategy(10, 5));
		
		strategy = new Strategy(new OperationSubstract());
		System.out.println("Answer is :" +  strategy.executeStrategy(10, 5));
	}
}
