package com.techlabs.student;

import java.io.*;
import java.util.*;

@SuppressWarnings({ "unchecked", "resource" })
public class StudentCsvStore implements IStudentStore {
	ArrayList<Student> studentlist;

	public StudentCsvStore() {
		init();
	}

	public void init() {
		try {
			FileInputStream fs = new FileInputStream("studentdata.csv");
			studentlist = (ArrayList<Student>) new ObjectInputStream(fs)
					.readObject();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public ArrayList<Student> get() {
		return studentlist;
	}

	@Override
	public void add(Student student) {
		studentlist.add(student);
		save();
	}

	private void save() {
		try {

			FileOutputStream fos = new FileOutputStream("studentdata.csv");
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(studentlist);
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
	public void search(String name) {
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
	}

	@Override
	public void delete(int id) {
		Student removeStudent = null;
		for (Student studentName : studentlist) {
			if (id == studentName.getId()) {
				System.out.println("Student Found by name of :"
						+ studentName.getName());
				removeStudent = studentName;
			}
		}
		studentlist.remove(removeStudent);
		save();
	}
}
