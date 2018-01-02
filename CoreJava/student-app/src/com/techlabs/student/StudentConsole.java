package com.techlabs.student;

import java.util.*;

public class StudentConsole {
	private static Scanner input;
	public static final int CHOICE_1 = 1;
	public static final int CHOICE_2 = 2;

	public static void start() {
		StudentStore student = new StudentStore();
		input = new Scanner(System.in);

		System.out.println("Press 1 to add Student");
		System.out.println("Press 2 to display Students");
		int choice = Integer.parseInt(input.nextLine());
		if (choice == CHOICE_1) {
			getDetails();
		} else if (choice == CHOICE_2) {
			student.retrieveStudents();
		}
	}

	public static void getDetails() {
		ArrayList<Student> studentlist = new ArrayList<Student>();
		do {
			System.out.println("Enter Student Id :");
			int id = Integer.parseInt(input.nextLine());

			System.out.println("Enter Student Name :");
			String name = input.nextLine();

			System.out.println("Enter Student Age :");
			int age = Integer.parseInt(input.nextLine());

			System.out.println("Enter Student Marks :");
			int marks = Integer.parseInt(input.nextLine());

			Student student = new Student(id, name, age, marks);

			studentlist.add(student);
			System.out.println("Thank You !! Your details are being saved.");
			System.out.println("Press 1 to add more Student");
			System.out.println("Any Other number to exit");
		} while (Integer.parseInt(input.nextLine()) == 1);
		StudentStore student = new StudentStore();
		student.saveStudent(studentlist);
	}
}