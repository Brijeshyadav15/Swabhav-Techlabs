package com.techlabs.student;

import java.io.*;
import java.util.*;

public class StudentStore implements Serializable {

	public void saveStudent(List<Student> student,boolean append) {
		try {
			FileOutputStream fos = new FileOutputStream("studentdata.ser", append);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(student);
			oos.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public ArrayList<Student> retrieveStudents() {
		ArrayList<Student> studentlist = null;
		try {
			FileInputStream fs = new FileInputStream("studentdata.ser");
			ObjectInputStream os = new ObjectInputStream(fs);
			studentlist = (ArrayList<Student>) os.readObject();
			for (Student student : studentlist) {
				System.out.println("Student Id:" + student.getId());
				System.out.println("Student Name:" + student.getName());
				System.out.println("Student Age:" + student.getAge());
				System.out.println("Student Location:" + student.getLocation()
						+ "\n");
			}
			os.close();

		} catch (Exception e) {
			e.printStackTrace();
		}
		return studentlist;
	}

	public void sortByName() {
		ArrayList<String> studentNames = new ArrayList<String>();
		for (Student studentName : retrieveStudents()) {
			studentNames.add(studentName.getName());
		}
		Collections.sort(studentNames);
		for (String studentName : studentNames) {
			System.out.println(studentName);
		}
	}

	public void sortByLocation() {
		ArrayList<String> studentLocations = new ArrayList<String>();
		for (Student studentName : retrieveStudents()) {
			studentLocations.add(studentName.getLocation());
		}
		Collections.sort(studentLocations);
		for (String studentName : studentLocations) {
			System.out.println(studentName);
		}
	}

	public void searchByName() {
		Scanner input = new Scanner(System.in);
		System.out.println("Please enter Student Name");
		String name = input.nextLine();

		ArrayList<String> studentNames = new ArrayList<String>();
		for (Student studentName : retrieveStudents()) {
			if (name.equals(studentName.getName())) {
				System.out.println("Student Found");
				System.out.println("Student Id  :" + studentName.getId());
				System.out.println("Student Name :" + studentName.getName());
				System.out.println("Student Age :" + studentName.getAge());
				System.out.println("Student Location: "
						+ studentName.getLocation());
			}
		}
	}

	public void deleteByName() {
		Scanner input = new Scanner(System.in);
		System.out.println("Please enter Student Name");
		String name = input.nextLine();
		Student removeStudent = null;
		ArrayList<Student> studentlist = retrieveStudents();
		for (Student studentName : studentlist) {
			if (name.equals(studentName.getName())) {
				System.out.println("Student Found by name of :"
						+ studentName.getName());
				removeStudent = studentName;
			}
		}
		studentlist.remove(removeStudent);
		saveStudent(studentlist, false);
	}
}
