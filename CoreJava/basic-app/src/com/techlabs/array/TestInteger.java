package com.techlabs.array;

public class TestInteger {
	public static void main(String[] args) {
		int mark = 100;
		changemark(mark);
		System.out.println(mark);
		int[] marks = { 10, 20, 30, 40 };
		changemarks(marks);
		for (int temp_mark : marks) {
			System.out.println(temp_mark);
		}
	}

	private static void changemark(int markParam) {
		markParam = 0;
	}

	private static void changemarks(int[] markparams) {
		for (int i = 0; i < markparams.length; i++) {
			markparams[i] = 0;
		}
	}
}
