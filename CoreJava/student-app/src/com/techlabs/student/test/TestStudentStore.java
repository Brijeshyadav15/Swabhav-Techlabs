package com.techlabs.student.test;

import java.util.*;
import com.techlabs.student.*;

public class TestStudentStore {
	static ArrayList<Student> studentlist = new ArrayList<Student>();

	public static void main(String[] args) {
//		casestudyone();
//		casestudytwo();
//		casestudythree();
//		casestudyfour();
		casestudyfive();
	}

	public static void casestudyone() {
		StudentBinaryStore studentbinary = new StudentBinaryStore();
		Student student = new Student(3, "Brijesh", 22, "Mumbai");
		studentbinary.add(student);
	}

	public static void casestudytwo() {
		StudentBinaryStore studentbinary = new StudentBinaryStore();
		studentbinary.read();
	}

	public static void casestudythree() {
		StudentBinaryStore studentbinary = new StudentBinaryStore();
		studentbinary.delete(1);
	}

	public static void casestudyfour() {
		StudentBinaryStore studentbinary = new StudentBinaryStore();
		ArrayList<Student> studentlist = studentbinary.get();
		Iterator<Student> it = studentlist.iterator();
		while (it.hasNext()) {
			System.out.println("Student Name:" +((Student) it.next()).getName());
			System.out.println("Student Age:" +((Student) it.next()).getAge());
			System.out.println("Student Location:"+((Student) it.next()).getLocation());
			System.out.println();

		}
	}
	
	public static void casestudyfive() {
		StudentBinaryStore studentbinary = new StudentBinaryStore();
		studentbinary.search("Brijesh");
	}
}
