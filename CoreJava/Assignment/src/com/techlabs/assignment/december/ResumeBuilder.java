package com.techlabs.assignment.december;

import java.io.FileWriter;
import java.io.IOException;

public class ResumeBuilder {
	private String name;
	private String mobile;
	private int age;
	private float percentage;
	private String address;

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getMobile() {
		return mobile;
	}

	public void setMobile(String mobile) {
		this.mobile = mobile;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public float getPercentage() {
		return percentage;
	}

	public void setPercentage(float percentage) {
		this.percentage = percentage;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public void buildResume() {
		String result = "<html> <head><title>" + getName()
				+ " -Resume </title></head>";
		result += "<body>" + "<h1> Name :" + getName() + "</h1>";
		result += "<h1> Age :" + getAge() + "</h1>";
		result += "<h1> Percentage :" + getPercentage() + "</h1>";
		result += "<h1> Address :" + getAddress() + "</h1>";
		result += "<h1> Mobile :" + getMobile() + "</h1>";
		try {
			FileWriter fw = new FileWriter(getName() + "Resume.html");
			fw.write(result);
			fw.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
