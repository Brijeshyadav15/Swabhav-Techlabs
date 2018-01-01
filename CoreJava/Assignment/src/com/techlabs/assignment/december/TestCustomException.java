package com.techlabs.assignment.december;

public class TestCustomException {
	public static void main(String[] args) {
		int testint = 20;
		try {
			if (testint < 0) {
				throw new NegativeValueException();
			} else {
				System.out.println(testint);
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
