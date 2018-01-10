package com.techlabs.student;

import java.io.*;
import java.text.*;
import java.util.*;

@SuppressWarnings("serial")
public class Student implements Serializable {
	private long id;
	private String name;
	private int age;
	private String location;

	public Student() {
	}

	public Student(String name, int age, String location) {
		this.id = Long.parseLong(new SimpleDateFormat("yyyyMMddHHmmss")
				.format(new Date()));
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
