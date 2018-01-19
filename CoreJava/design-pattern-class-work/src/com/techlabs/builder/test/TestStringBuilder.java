package com.techlabs.builder.test;

public class TestStringBuilder {

	public static void main(String[] args) {
		
		String string = new String("Hello");
		System.out.println(string.hashCode());
		string +="Java";
		System.out.println(string.hashCode());
		
		
		StringBuilder stringbuilder = new StringBuilder("Hello");
		System.out.println(stringbuilder.hashCode());
		stringbuilder.append("Java");
		System.out.println(stringbuilder.hashCode());
	}

}
