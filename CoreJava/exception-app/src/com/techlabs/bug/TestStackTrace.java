package com.techlabs.bug;

public class TestStackTrace {

	public static void main(String[] args) throws Exception{
		m1();

	}

	public static void m1() throws Exception{
		m2();
	}
	
	public static void m2() throws Exception {
		m3();
	}
	public static void m3() throws Exception {
		throw new Exception("Something went wrong"); 
	}

}
