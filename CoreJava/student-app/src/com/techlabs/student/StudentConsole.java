package com.techlabs.student;

import java.io.*;
import java.util.*;

public class StudentConsole implements Serializable {
	private static Scanner input;
	public static final int AddChoice = 1;
	public static final int DisplayChoice = 2;
	public static final int SortNameChoice = 3;
	public static final int CHOICE_4 = 4;
	public static final int CHOICE_5 = 5;
	public static final int CHOICE_6 = 6;

	public void start() {
		StudentStore student = new StudentStore();
		input = new Scanner(System.in);

		System.out.println("Press 1 to add Student");
		System.out.println("Press 2 to display Students");
		System.out.println("Press 3 to Sort Student By Name");
		System.out.println("Press 4 to Sort Student By Location");
		System.out.println("Press 5 to Search Student By Name");
		System.out.println("Press 6 to Delete Student");

		int choice = Integer.parseInt(input.nextLine());

		if (choice == AddChoice) {
			getDetails();
		} else if (choice == DisplayChoice) {
			student.retrieveStudents();
			start();
		} else if (choice == SortNameChoice) {
			student.sortByName();
		} else if (choice == CHOICE_4) {
			student.sortByLocation();
		} else if (choice == CHOICE_5) {
			student.searchByName();
		} else if (choice == CHOICE_6) {
			student.deleteByName();
		}
	}

	public void getDetails() {
		ArrayList<Student> studentlist = new ArrayList<Student>();

		do {
			System.out.println("Enter Student Id :");
			int id = Integer.parseInt(input.nextLine());

			System.out.println("Enter Student Name :");
			String name = input.nextLine();

			System.out.println("Enter Student Age :");
			int age = Integer.parseInt(input.nextLine());

			System.out.println("Enter Student Location :");
			String location = input.nextLine();

			Student student = new Student(id, name, age, location);
			studentlist.add(student);

			System.out.println("Thank You !! Your details are being saved.");
			System.out.println("Press 1 to add more Student");
			System.out.println("Any Other number to exit");

		} while (Integer.parseInt(input.nextLine()) == AddChoice);
		StudentStore student = new StudentStore();
		student.saveStudent(studentlist);
		start();
	}
}