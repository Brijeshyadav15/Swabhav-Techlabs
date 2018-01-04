package com.techlabs.student;

import java.io.*;
import java.util.*;

public class StudentBinaryStore implements IStudentStore {
	ArrayList<Student> studentlist = null;

	public StudentBinaryStore() {
		init();
	}

	public void init() {
		try {
			FileInputStream fs = new FileInputStream("studentdata.ser");
			studentlist = (ArrayList<Student>) new ObjectInputStream(fs)
					.readObject();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public void add(Student student) {
		try {
			FileOutputStream fos = new FileOutputStream("studentdata.ser", true);
			ObjectOutputStream oos = new ObjectOutputStream(fos);

			oos.writeObject(student);
			oos.close();

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public void read() {

		for (Student student : studentlist) {
			System.out.println("Student Id:" + student.getId());
			System.out.println("Student Name:" + student.getName());
			System.out.println("Student Age:" + student.getAge());
			System.out.println("Student Location:" + student.getLocation()
					+ "\n");
		}
	}

	@Override
	public void search() {
		Scanner input = new Scanner(System.in);
		System.out.println("Please enter Student Name");
		String name = input.nextLine();

		for (Student studentName : studentlist) {
			if (name.equals(studentName.getName())) {

				System.out.println("Student Found");
				System.out.println("Student Id  :" + studentName.getId());
				System.out.println("Student Name :" + studentName.getName());
				System.out.println("Student Age :" + studentName.getAge());
				System.out.println("Student Location: "
						+ studentName.getLocation());

			}
		}
		input.close();
	}

	@Override
	public void delete() {

		Scanner input = new Scanner(System.in);
		System.out.println("Enter Student Name to delete :");
		String name = input.nextLine();
		Student removeStudent = null;

		for (Student studentName : studentlist) {
			if (name.equals(studentName.getName())) {
				System.out.println("Student Found by name of :"
						+ studentName.getName());
				removeStudent = studentName;
			}
		}
		studentlist.remove(removeStudent);
		input.close();
	}
}
