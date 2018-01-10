package com.techlabs.student.test;

import java.util.*;
import com.techlabs.student.*;

public class TestStudentStore {
	static ArrayList<Student> studentlist = new ArrayList<Student>();

	public static void main(String[] args) {
		// casestudyAdd();
		 casestudyRead();
		// casestudySearch();
		//casestudyDelete();
	}

	public static void casestudyAdd() {
		StudentBinaryStore studentbinary = new StudentBinaryStore();
		Student student = new Student("Brijesh", 22, "Mumbai");
		studentbinary.add(student);
	}

	public static void casestudyDelete() {
		StudentBinaryStore studentbinary = new StudentBinaryStore();
		studentbinary.delete(20180109170314L);
	}

	public static void casestudyRead() {
		StudentBinaryStore studentbinary = new StudentBinaryStore();
		for (Student student : studentbinary.get()) {

			System.out.println("Student ID:" + student.getId());
			System.out.println("Student Name:" + student.getName());
			System.out.println("Student Age:" + student.getAge());
			System.out.println("Student Location:" + student.getLocation());

		}
	}

	public static void casestudySearch() {
		StudentBinaryStore studentbinary = new StudentBinaryStore();
		Student result = studentbinary.search("Brijesh");

		System.out.println("Student ID:" + result.getId());
		System.out.println("Student Name:" + result.getName());
		System.out.println("Student Age:" + result.getAge());
		System.out.println("Student Location:" + result.getLocation());

	}
}
