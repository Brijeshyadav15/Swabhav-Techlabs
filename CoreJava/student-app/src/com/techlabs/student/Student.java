package com.techlabs.student;

import java.io.*;

@SuppressWarnings("serial")
public class Student implements Serializable{
	private int id;
	private String name;
	private int age;
	private String location;

	public Student(int id, String name, int age, String location) {
		this.id = id;
		this.name = name;
		this.age = age;
		this.location = location;
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

	public String getLocation() {
		return location;
	}
}
