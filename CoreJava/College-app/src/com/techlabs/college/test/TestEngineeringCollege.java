package com.techlabs.college.test;

import java.text.ParseException;
import java.text.SimpleDateFormat;

import com.techlabs.college.*;

public class TestEngineeringCollege {
	static SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");

	public static void main(String[] args) throws ParseException	 {
		casestudyonStudent();
		casestudyonProfessor();

	}

	private static void casestudyonStudent() throws ParseException{
		Student student = new Student(1, "Mumbai", sdf.parse("15/02/1996"),
				Branch.CIVIL);

		System.out.println(student.getId() + "\t" + student.getAddress() + "\t"
				+ "\t" + sdf.format(student.getDob()) + "\t"
				+ student.getBranch());
	}

	private static void casestudyonProfessor() throws ParseException{
		Professor professor = new Professor(2, "Delhi",
				sdf.parse("15/02/1976"), 5000.00);
		System.out.println(professor.getId() + "\t" + professor.getAddress()
				+ "\t" + "\t" + sdf.format(professor.getDob()) + "\t"
				+ professor.calcSalary());
	}
}
