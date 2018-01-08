package com.techlabs.student.test;

import com.techlabs.student.*;


public class TestCSVStore {
	public static void main(String[] args) {
		StudentCsvStore studentcsv = new StudentCsvStore();
		Student student = new Student(3, "Brijesh", 22, "Mumbai");
		studentcsv.add(student);
	}
}
