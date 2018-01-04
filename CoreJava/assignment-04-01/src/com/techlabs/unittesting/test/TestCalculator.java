package com.techlabs.unittesting.test;

import com.techlabs.unittesting.Calculator;

public class TestCalculator {

	public static void main(String[] args) {
		Calculator calculator = new Calculator(3, 2);
		System.out.println(calculator.add());

	}

}
