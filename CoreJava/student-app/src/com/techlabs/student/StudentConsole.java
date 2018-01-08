package com.techlabs.student;

import java.io.*;
import java.util.*;

@SuppressWarnings("serial")
public class StudentConsole implements Serializable {
	public StudentConsole(StudentBinaryStore sbs) {

	}

	private static Scanner input;
	public static final int AddChoice = 1;
	public static final int DisplayChoice = 2;
	public static final int SearchStudentChoice = 3;
	public static final int DeleteStudentChoice = 4;
	StudentBinaryStore student = new StudentBinaryStore();

	public void start() {

		input = new Scanner(System.in);
		System.out.println("Press 1 to add Student");
		System.out.println("Press 2 to Display Students");
		System.out.println("Press 3 to Search Student By Name");
		System.out.println("Press 4 to Delete Student");

		int choice = Integer.parseInt(input.nextLine());

		switch (choice) {
		case AddChoice:
			getDetails();
			break;
		case DisplayChoice:
			student.read();
			break;
		case SearchStudentChoice:
			getSearch();
			break;
		case DeleteStudentChoice:
			student.delete(0);
			break;
		}

	}

	@SuppressWarnings("unused")
	public void getDetails() {
		ArrayList<Student> studentlist = new ArrayList<Student>();
		StudentBinaryStore studentstore = new StudentBinaryStore();

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
			((IStudentStore) studentstore).add(student);

			System.out.println("Thank You !! Your details are being saved.");
			System.out.println("Press 1 to add more Student");
			System.out.println("Any Other number to exit");

		} while (Integer.parseInt(input.nextLine()) == AddChoice);
		start();
	}

	@SuppressWarnings("unused")
	public void getSearch() {
		start();
	}
}