package com.techlabs.student;

import java.io.*;
import java.util.*;

@SuppressWarnings("serial")
public class StudentConsole implements Serializable {
	IStudentStore studentobj;
	
	public StudentConsole(IStudentStore obj) {
		studentobj= obj;
	}
		

	private static Scanner input;
	public static final int AddChoice = 1;
	public static final int DisplayChoice = 2;
	public static final int SearchStudentChoice = 3;
	public static final int DeleteStudentChoice = 4;
	public static final int ExportToHTML = 5;
	

	public void start() {

		input = new Scanner(System.in);
		System.out.println("Press 1 to add Student");
		System.out.println("Press 2 to Display Students");
		System.out.println("Press 3 to Search Student By Name");
		System.out.println("Press 4 to Delete Student");
		System.out.println("Press 5 to Export to HTML File");

		int choice = Integer.parseInt(input.nextLine());

		switch (choice) {
		case AddChoice:
			getDetails();
			break;
		case DisplayChoice:
			print(studentobj.get());
			break;
		case SearchStudentChoice:
			getSearch();
			break;
		case DeleteStudentChoice:
			getDelete();
			studentobj.delete(0);
			break;
		case ExportToHTML:
			studentobj.Export();
			System.out.println("Data has been exported to CSV file");
			break;
		}

	}

	@SuppressWarnings("unused")
	public void getDetails() {
		ArrayList<Student> studentlist = new ArrayList<Student>();

		do {
			System.out.println("Enter Student Name :");
			String name = input.nextLine();

			System.out.println("Enter Student Age :");
			int age = Integer.parseInt(input.nextLine());

			System.out.println("Enter Student Location :");
			String location = input.nextLine();

			Student student = new Student(name, age, location);
			((IStudentStore) studentobj).add(student);

			System.out.println("Thank You !! Your details are being saved.");
			System.out.println("Press 1 to add more Student");
			System.out.println("Any Other number to exit");

		} while (Integer.parseInt(input.nextLine()) == AddChoice);
		start();
	}

	public void print(ArrayList<Student> students) {
		for (Student student : students) {
			System.out.println("Student Id:" + student.getId());
			System.out.println("Student Name:" + student.getName());
			System.out.println("Student Age:" + student.getAge());
			System.out.println("Student Location:" + student.getLocation()
					+ "\n");
		}
	}

	public void getSearch() {
		System.out.println("Enter Student Name :");
		Student result = studentobj.search(input.nextLine());

		System.out.println("Student ID:" + result.getId());
		System.out.println("Student Name:" + result.getName());
		System.out.println("Student Age:" + result.getAge());
		System.out.println("Student Location:" + result.getLocation());
	}

	private void getDelete() {
		System.out.println("Enter Student Id to delete:");
		System.out.println(studentobj.delete(Long.parseLong(input.nextLine())));
	}
}