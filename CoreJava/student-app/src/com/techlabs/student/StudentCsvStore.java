package com.techlabs.student;

import java.io.*;
import java.util.*;

@SuppressWarnings({ "unchecked", "resource" })
public class StudentCsvStore implements IStudentStore {
	ArrayList<Student> studentlist;

	public StudentCsvStore() {
		// init();
	}

	public void init() {
		try {
			FileInputStream fs = new FileInputStream("studentdata.csv");
			// studentlist = (ArrayList<Student>) new ObjectInputStream(fs)
			// .readObject();
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
		try {
			studentlist.add(student);
			save();
		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	private void save() {
		try {

			FileWriter fos = new FileWriter("studentdata.csv");
			for (Student student : studentlist) {
				String temp = student.getId() + "," + student.getName() + ","
						+ student.getAge() + "," + student.getLocation();
				fos.append(temp);
			}
			fos.close();
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
	public Student search(String name) {
		for (Student studentName : studentlist) {
			if (name.equals(studentName.getName()))
				return studentName;
		}
		return null;
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
