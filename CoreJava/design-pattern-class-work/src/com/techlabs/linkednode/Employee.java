package com.techlabs.linkednode;

public class Employee {

	private String name;
	private int age;
	private int id;

	public String getName() {
		return name;
	}

	public int getAge() {
		return age;
	}

	public int getId() {
		return id;
	}

	public Employee(int id, String name, int age) {
		this.name = name;
		this.age = age;
		this.id = id;
	}

}
