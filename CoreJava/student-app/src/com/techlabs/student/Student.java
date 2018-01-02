package com.techlabs.student;

public class Student {
	private int id;
	private String name;
	private int age;
	private int marks;

	public Student(int id, String name, int age, int marks) {
		this.id = id;
		this.name = name;
		this.age = age;
		this.marks = marks;
	}

	public int getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public int getAge() {
		return age;
	}

	public int getMarks() {
		return marks;
	}
}
