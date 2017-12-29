package com.excerise.student;

public class Student {
	private String name;
	private String mobile;
	private int age;
	private float percentage;
	private String address;	
	
	public String getName()
	{
		return name;
	}
	public void setName(String name)
	{
		this.name = name; 
	}
	
	public String getMobile()
	{
		return mobile;
	}
	public void setMobile(String mobile)
	{
		this.mobile = mobile; 
	}
	
	public int getAge()
	{
		return age;
	}
	public void setAge(int age)
	{
		this.age = age; 
	}
	
	public float getPercentage()
	{
		return percentage;
	}
	public void setPercentage(float percentage)
	{
		this.percentage = percentage; 
	}
	
	public String getAddress()
	{
		return address;
	}
	public void setAddress(String address)
	{
		this.address = address; 
	}
	
	public String buildResume() {
		String result = "Name : " + getName() + "\n";
		result += "Age : " + getAge() + "\n";
		result += "Percentage : " + getPercentage() + "\n";
		result += "Address : " + getAddress() + "\n";
		return result;
	}
}
