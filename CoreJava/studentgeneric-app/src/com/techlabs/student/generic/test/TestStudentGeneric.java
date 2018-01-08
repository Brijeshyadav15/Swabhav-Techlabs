package com.techlabs.student.generic.test;

import java.util.*;

import com.techlabs.student.generic.*;

public class TestStudentGeneric {
	public static void main(String[] args) {
		casestudyone();
		casestudytwo();
	}

	public static void casestudyone() {
		Set<StudentGeneric> studentset = new LinkedHashSet<StudentGeneric>();
		StudentGeneric student1 = new StudentGeneric(4, 14, "Brijesh");
		StudentGeneric student2 = new StudentGeneric(4, 14, "Brijesh");
		studentset.add(student1);
		studentset.add(student2);

		for (StudentGeneric student : studentset) {
			System.out.println(student.getStd());
			System.out.println(student.getRollno());
			System.out.println(student.getName());
		}

		// Iterator<StudentGeneric> it = studentset.iterator();
		// while (it.hasNext()) {
		// System.out.println(it.next().getStd());
		// System.out.println(it.next().getRollno());
		// System.out.println(it.next().getName());
		// }
	}

	public static void casestudytwo() {
		Set<StudentGeneric> studentset = new TreeSet<StudentGeneric>();
		StudentGeneric student1 = new StudentGeneric(4, 14, "Brijesh");
		StudentGeneric student2 = new StudentGeneric(4, 14, "Aakash");
		studentset.add(student1);
		studentset.add(student2);

		for (StudentGeneric student : studentset) {
			System.out.println(student.getStd());
			System.out.println(student.getRollno());
			System.out.println(student.getName());
		}
	}
	
}
