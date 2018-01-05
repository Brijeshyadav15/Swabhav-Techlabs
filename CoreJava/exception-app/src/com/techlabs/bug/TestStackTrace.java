package com.techlabs.bug;

public class TestStackTrace {

	public static void main(String[] args) {
		try {
			m1();
		} catch (Exception e) {
			e.printStackTrace();
		}
		System.out.println("End of main");
	}

	public static void m1() throws Exception {
		m2();
	}

	public static void m2() throws Exception {
		m3();
	}

	public static void m3() throws Exception {
		throw new Exception("Something went wrong");
	}

}
