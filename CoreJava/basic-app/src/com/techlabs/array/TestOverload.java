package com.techlabs.array;

public class TestOverload {
	public static void main(String[] args) {
		print();
		print('#');
		print(10);
		print(10.5);
		print(11.22);
		print(7.43f);
	}

	private static void print() {
		System.out.println("----------------------");
	}

	private static void print(char pattern) {
		System.out.println(pattern);
	}

	private static void print(int number) {
		System.out.println(number);
	}

	private static void print(float floatnumber) {
		System.out.println(floatnumber);
	}
	
	private static void print(double doublenumber) {
		System.out.println(doublenumber);
	}

	
}
