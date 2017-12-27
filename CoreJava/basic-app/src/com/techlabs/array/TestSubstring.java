package com.techlabs.array;

public class TestSubstring {
	public static void main(String[] urls) {
		String input = "https://www.swabhavtechlabs.com?student=brijesh";
		System.out.println("Original URL is :" + input);
		System.out.println("Sub string is :" + input.substring(2));
		System.out
				.println("Substring with limit is :" + input.substring(2, 10));
	}
}
