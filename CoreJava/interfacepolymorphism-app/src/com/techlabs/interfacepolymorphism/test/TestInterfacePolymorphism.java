package com.techlabs.interfacepolymorphism.test;

import com.techlabs.interfacepolymorphism.*;

public class TestInterfacePolymorphism {
	public static void main(String[] args) {
		Man x = new Man();
		Boy y = new Boy();

		atTheParty(x);

		atTheParty(y);

		//atTheMovies(x);
		
		atTheMovies(y);

	}

	public static void atTheParty(IMannerable obj) {
		System.out.println("At the Party ");
		obj.wish();
		System.out.println("At the Party ");
		obj.depart();

	}

	public static void atTheMovies(IEmotionable obj) {
		System.out.println("At the Movies ");
		obj.cry();
		System.out.println("At the Movies ");
		obj.laugh();

	}
}
