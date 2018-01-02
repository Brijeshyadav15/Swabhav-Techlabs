package com.techlabs.assignment.december;

import java.util.*;

public class TestResumeBuilder {
	public static void main(String[] args) {
		ResumeBuilder student = new ResumeBuilder();
		getDetails(student);
		student.buildResume();
	}

	public static void getDetails(ResumeBuilder student) {
		Scanner input = new Scanner(System.in);
		System.out.println("Please Enter Your Name:");
		student.setName(input.nextLine());

		System.out.println("Please Enter Your Age:");
		student.setAge(input.nextLine());

		System.out.println("Please Enter Your Address:");
		student.setAddress(input.nextLine());

		System.out.println("Please Enter Your Percentage:");
		student.setPercentage(input.nextLine());

		System.out.println("Please Enter Your Mobile:");
		student.setMobile(input.nextLine());

		System.out.println("Thank You!! Your Resume has been build.");
		input.close();
	}
}