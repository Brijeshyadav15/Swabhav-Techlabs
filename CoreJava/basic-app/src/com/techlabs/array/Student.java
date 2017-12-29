package com.techlabs.array;

public class Student {
	protected String name;
	protected String mobile;
	protected int age;
	protected float percentage;
	protected String address;

	public void buildResume() {
		System.out.println("Name of the Student is : " + name);
		System.out.println(name + " is " + age + " years old");
		System.out.println(name + " has " + percentage + " % marks");
		System.out.println(name + " lives at " + address);
		System.out.println(name + " can be contacted at " + mobile + " number");
	}
}
