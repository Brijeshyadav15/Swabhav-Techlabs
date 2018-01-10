package com.techlabs.student.test;

import java.util.*;

import com.techlabs.student.*;

public class TestCSVStore {
	public static void main(String[] args) {
		StudentCsvStore studentcsv = new StudentCsvStore();
		//studentcsv.add(new Student("Akash", 26, "Laram Center"));
		print(studentcsv.get());

	}

	private static void print(ArrayList<Student> students) {
		for (Student student : students) {
			System.out.println("Student Id:" + student.getId());
			System.out.println("Student Name:" + student.getName());
			System.out.println("Student Age:" + student.getAge());
			System.out.println("Student Location:" + student.getLocation()
					+ "\n");
		}
	}
}
