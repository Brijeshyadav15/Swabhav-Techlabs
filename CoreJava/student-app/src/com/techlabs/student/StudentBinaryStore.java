package com.techlabs.student;

import java.io.*;
import java.util.*;

public class StudentBinaryStore implements IStudentStore {
	ArrayList<Student> studentlist;

	// int idCounter = studentlist.size();
	public StudentBinaryStore() {
		init();
	}

	@SuppressWarnings({ "unchecked", "resource" })
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
			FileOutputStream fos = new FileOutputStream("studentdata.ser");
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(studentlist);
			oos.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public void read() {
		// Iterator<Student> it = studentlist.iterator();
		// while (it.hasNext()) {
		// System.out.println("Student Name:" + ((Student) it.next()).getId());
		// System.out.println("Student Name:"
		// + ((Student) it.next()).getName());
		// System.out.println("Student Age:" + ((Student) it.next()).getAge());
		// System.out.println("Student Location:"
		// + ((Student) it.next()).getLocation());
		// System.out.println();
		// }

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
