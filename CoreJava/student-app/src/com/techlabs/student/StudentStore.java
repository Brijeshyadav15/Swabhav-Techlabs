package com.techlabs.student;

import java.io.*;
import java.util.*;

public class StudentStore {

	public void saveStudent(List<Student> student) {
		try {
			FileOutputStream fos = new FileOutputStream("studentdata.txt", true);
			ObjectOutputStream oos = new ObjectOutputStream(fos);
			oos.writeObject(student);
			oos.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public void retrieveStudents() {
		try {
			FileInputStream fs = new FileInputStream("studentdata.txt");
			ObjectInputStream os = new ObjectInputStream(fs);
			ArrayList<Student> studentlist = (ArrayList<Student>) os
					.readObject();
			for (Student student : studentlist) {
				System.out.println("Student Id:" + student.getId());
				System.out.println("Student Name:" + student.getName());
				System.out.println("Student Age:" + student.getAge());
				System.out
						.println("Student Marks:" + student.getMarks() + "\n");
			}
			os.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
