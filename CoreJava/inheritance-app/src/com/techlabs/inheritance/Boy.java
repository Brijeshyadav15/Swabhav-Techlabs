package com.techlabs.inheritance;

public class Boy extends Man {
	public Boy() {
		System.out.println("Boy is created");
	}

	@Override
	public void play() {
		System.out.println("Boy is playing");
	}

	public void eat() {
		System.out.println("Boy is eating");
	}
}
