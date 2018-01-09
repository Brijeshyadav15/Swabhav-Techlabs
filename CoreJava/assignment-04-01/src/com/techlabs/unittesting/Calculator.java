package com.techlabs.unittesting;

public class Calculator {
	private int first;
	private int second;

	public Calculator(int first, int second) {
		this.first = first;
		this.second = second;
	}

	public int add() {

		if (first >= 0 && second >= 0) {
			return first + second;
		} else {
			try {
				throw new RuntimeException("Numbers can not be negative");
			} catch (Exception e) {
				e.printStackTrace();
			}
		}

		return 0;
	}
}
