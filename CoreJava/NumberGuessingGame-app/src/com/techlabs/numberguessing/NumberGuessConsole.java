package com.techlabs.numberguessing;

import java.util.*;

public class NumberGuessConsole {
	public NumberGuessConsole() {
		start();
	}

	public void start() {
		GameController ga = new GameController(1, 100, 2);
		Scanner input = new Scanner(System.in);
		ga.setGamestate(GameState.START);
		int attempts = 0;

		while (ga.checkattempts(attempts) > 0) {
			ga.setGamestate(GameState.RUNNING);
			
			if (ga.checkattempts(attempts) > 0)
				System.out.println("You have " + ga.checkattempts(attempts)
						+ " attempts remaining");

			System.out.println("Guess your Number :");
			int userNumber = Integer.parseInt(input.nextLine());
			
			System.out.println(ga.compare(userNumber));
			attempts++;
		}
		System.out.println(ga.getGamestate().toString());
	}
}
