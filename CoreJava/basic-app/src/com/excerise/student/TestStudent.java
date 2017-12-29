package com.excerise.student;

public class TestStudent {
	public static void main(String[] args) {
		Student s = new Student();
		s.setName("Brijesh");
		s.setAge(21);
		s.setAddress("Ambawadi,Ahmedabad");
		s.setPercentage(85.00f);
		s.setMobile("1234567890");
		System.out.println(s.buildResume());
	}

}
