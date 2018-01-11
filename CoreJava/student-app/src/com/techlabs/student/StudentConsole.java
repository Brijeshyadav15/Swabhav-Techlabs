package com.techlabs.student;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;


public class StudentConsole {
	IStudentStore studentobj;

	public StudentConsole(IStudentStore obj) {
		studentobj = obj;
	}

	private static Scanner input;
	private static final int ADD_CHOICE = 1;
	private static final int DISPLAY_CHOICE = 2;
	private static final int SEARCH_STUDENT_CHOICE = 3;
	private static final int DELETE_STUDENT_CHOICE = 4;
	private static final int EXPORT_TO_HTML = 5;

	public void start() {

		input = new Scanner(System.in);
		System.out.println("Press 1 to add Student");
		System.out.println("Press 2 to Display Students");
		System.out.println("Press 3 to Search Student By Name");
		System.out.println("Press 4 to Delete Student");
		System.out.println("Press 5 to Export to HTML File");

		int choice = Integer.parseInt(input.nextLine());

		switch (choice) {
		case ADD_CHOICE:
			getDetails();
			break;
		case DISPLAY_CHOICE:
			print(studentobj.get());
			break;
		case SEARCH_STUDENT_CHOICE:
			getSearch();
			break;
		case DELETE_STUDENT_CHOICE:
			getDelete();
			studentobj.delete(0);
			break;
		case EXPORT_TO_HTML:
			studentobj.export();
			System.out.println("Data has been exported to CSV file");
			break;
		}

	}

	@SuppressWarnings("unused")
	public void getDetails() {
		List<Student> studentlist = new ArrayList<Student>();

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

		} while (Integer.parseInt(input.nextLine()) == ADD_CHOICE);
		start();
	}

	public void print(List<Student> list) {
		for (Student student : list) {
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