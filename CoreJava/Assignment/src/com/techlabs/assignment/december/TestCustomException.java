package com.techlabs.assignment.december;

public class TestCustomException {
	public static void main(String[] args)  {
		int testint = -20;
			if (testint < 0) {
				throw new NegativeValueException();
			} else {
				System.out.println("Number is :"+testint);
			}
	}
}
