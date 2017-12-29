package com.excerise.student;

public class Student {
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

	public String buildResume() {
		String result = "\t\t\t\t RESUME \t\t\t\t\n";
		result += "-------------------------------------------------------------------\n";
		result += "Name \t\t: " + getName() + "\n";
		result += "Age \t\t: " + getAge() + "\n";
		result += "Percentage \t: " + getPercentage() + "\n";
		result += "Address \t: " + getAddress() + "\n";
		result += "Mobile \t\t: " + getMobile() + "\n";
		result += "-------------------------------------------------------------------\n";
		return result;
	}
}
