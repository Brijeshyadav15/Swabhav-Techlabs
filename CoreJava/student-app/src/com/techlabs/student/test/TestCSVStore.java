package com.techlabs.student.test;

import java.util.List;

import com.techlabs.student.Student;
import com.techlabs.student.StudentCsvStore;

public class TestCSVStore {
	public static void main(String[] args) {
		StudentCsvStore studentcsv = new StudentCsvStore();
		print(studentcsv.get());

	}

	private static void print(List<Student> list) {
		for (Student student : list) {
			System.out.println("Student Id:" + student.getId());
			System.out.println("Student Name:" + student.getName());
			System.out.println("Student Age:" + student.getAge());
			System.out.println("Student Location:" + student.getLocation()
					+ "\n");
		}
	}
}
