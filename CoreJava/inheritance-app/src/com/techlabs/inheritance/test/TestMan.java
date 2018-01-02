package com.techlabs.inheritance.test;

import com.techlabs.inheritance.*;

public class TestMan {
	public static void main(String[] args) {
		// caseone();
		casetwo();
		// casethree();
		// casefour();
	}

	public static void caseone() {
		Man x;
		x = new Man();
		x.read();
		x.play();

	}

	public static void casetwo() {
		Boy y;
		y = new Boy();
		y.play();
		y.eat();
		y.read();
	}

	public static void casethree() {
		Man x;
		x = new Boy();
		x.play();
		x.read();
	}

	public static void casefour() {
		atThePark(new Man());
		atThePark(new Boy());
		atThePark(new Kid());
		atThePark(new Infant());
	}

	public static void atThePark(Man x) {
		System.out.println("At the Park");
		x.play();
	}
}
