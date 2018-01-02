package com.techlabs.assignment.december;

import java.lang.annotation.*;
import java.lang.reflect.*;

public class TestCountMethods {

	public static void main(String[] args) {
		try {
			Class<?> className = Class
					.forName("com.techlabs.assignment.december.ResumeBuilder");
			Constructor[] allConstructors = className.getDeclaredConstructors();
			Method[] allMethods = className.getDeclaredMethods();
			Field[] fields = className.getFields();
			Annotation[] annotations = className.getDeclaredAnnotations();

			System.out.println("Name of the Class\t: " + className);
			System.out.println("Number of Constructors\t: "
					+ allConstructors.length);
			System.out.println("Number of Methods\t: " + allMethods.length);
			System.out.println("Number of Annotated Methods \t: "
					+ annotations.length);
			System.out.println("Number of Fields\t: " + fields.length);
			System.out.println("Number of Getter \t: "
					+ countGetterandSetter(className, allMethods, "get"));
			System.out.println("Number of Setter \t: "
					+ countGetterandSetter(className, allMethods, "set"));

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public static int countGetterandSetter(Class<?> className,
			Method[] methods, String prefix) {
		int numberofMethods = 0;
		for (Method method : methods) {
			numberofMethods = method.getName().startsWith(prefix) ? numberofMethods + 1
					: numberofMethods;
		}
		return numberofMethods;
	}
}
