package com.techlabs.assignment.december;

public class TestResumeBuilder {
	public static void main(String[] args) {
		ResumeBuilder s = new ResumeBuilder();
		s.setName("Brijesh");
		s.setAge(21);
		s.setAddress("Ambawadi,Ahmedabad");
		s.setPercentage(85.00f);
		s.setMobile("1234567890");
		s.buildResume();
	}
}
