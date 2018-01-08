package com.techlabs.calculator;

public class Calculator {
	public int squareOdd(int number) throws Exception {
		if (number % 2 == 0) {
			throw new RuntimeException("Number should not be even");
		} else if (number < 0) {
			throw new RuntimeException("Number should be greater than zero");
		} else {
			return number * number;
		}
	}
}
