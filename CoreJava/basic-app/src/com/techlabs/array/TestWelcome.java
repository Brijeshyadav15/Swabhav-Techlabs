package com.techlabs.array;

public class TestWelcome {
	public static void main(String names[]) {
		System.out.println("Welcome, Java");
		if (names.length > 0) {
			for (String name : names) {
				System.out.println("Hello, " + name);
			}
		} else if (names.length == 0) {
			System.out.println("Please enter atleast one Name");
		}
	}
}