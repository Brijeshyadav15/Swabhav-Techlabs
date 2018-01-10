package com.techlabs.numberguessing;

import java.util.*;

public class NumberGuessConsole {
	private int declaredNumber = 54;

	public NumberGuessConsole() {
		start();
	}

	public void start() {
		NumberGuessService ngs = new NumberGuessService();
		GameController ga = new GameController();

		Scanner input = new Scanner(System.in);
		ngs.setGamestate(GameState.START);

		System.out
				.println("Please enter Starting Range for Guessing the number");
		ga.setRangeStart(Integer.parseInt(input.nextLine()));

		System.out.println("Please enter Ending Range for Guessing the number");
		ga.setRangeEnd(Integer.parseInt(input.nextLine()));

		int attempts = 0;

		while (attempts <= ga.getNoOfAttempts()) {
			System.out.println(ngs.getGamestate());
			System.out.println("Please enter your Guessed Number");
			int userNumber = Integer.parseInt(input.nextLine());
			System.out.println(ngs.compare(userNumber));
			attempts++;
		}

	}
}
