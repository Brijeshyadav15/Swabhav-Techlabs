package com.techlabs.student.test;

import java.util.ArrayList;

import com.techlabs.student.Student;
import com.techlabs.student.StudentStore;

public class TestStudentStore {
	static ArrayList<Student> studentlist = new ArrayList<Student>();

	public static void main(String[] args) {
		StudentStore student = new StudentStore();
		//StudentStore.saveStudent(studentlist);
		student.retrieveStudents();
	}
}
