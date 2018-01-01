package com.techlabs.assignment.december;

import java.lang.reflect.*;

public class TestCountMethods {

	public static void main(String[] args) {
		try {
			Class class1 = Class.forName("java.lang.Class");
			String className = class1.getName();
			Class c1 = className.getClass();
			Constructor[] allConstructors = class1.getDeclaredConstructors();
			Method[] allMethods = c1.getDeclaredMethods();
			Field[] fields = c1.getFields();
			System.out.println("Name of the Class\t: " + className);
			System.out.println("Number of Constructors\t: "
					+ allConstructors.length);
			System.out.println("Number of Methods\t: " + allMethods.length);
			System.out.println("Number of Fields\t: " + fields.length);

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
