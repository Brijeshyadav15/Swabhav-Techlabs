package com.techlabs.student;

import java.io.*;
import java.text.*;
import java.util.Date;
import java.util.UUID;


@SuppressWarnings("serial")
public class Student implements Serializable {
	private long id;
	private String name;
	private int age;
	private String location;

	public Student() {
	}

	public Student(String name, int age, String location) {
		this.id = UUID.randomUUID().toString().replace("-", "");
		this.name = name;
		this.age = age;
		this.location = location;
	}

	public Student(long id, String name, int age, String location) {
		this.id = id;
		this.name = name;
		this.age = age;
		this.location = location;
	}

	public long getId() {
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
