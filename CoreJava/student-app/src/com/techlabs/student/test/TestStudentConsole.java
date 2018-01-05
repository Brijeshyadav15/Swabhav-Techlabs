package com.techlabs.student.test;

import com.techlabs.student.*;

public class TestStudentConsole {
	public static void main(String[] args) {
		StudentConsole  studentconsole = new StudentConsole(new StudentBinaryStore());
		studentconsole.start();
	}
}
