package com.techlabs.numberguessing;

public class NumberGuessService {
	private int rangeEnd =0;

	public int getRangeEnd() {
		return rangeEnd;
	}

	public void setRangeEnd(int rangeEnd) {
		if (rangeEnd > getRangeStart())
			this.rangeEnd = rangeEnd;
		else
			throw new RuntimeException(
					"Range ending number must be greater than Range Starting number");
	}

	public int getRangeStart() {
		return rangeStart;
	}

	public void setRangeStart(int rangeStart) {
		if (rangeStart < getRangeEnd())
			this.rangeEnd = rangeStart;
		else
			throw new RuntimeException(
					"Range starting number must be smaller than Range Ending number");
	}

	private int rangeStart = 100;
	private int declaredNumber = (int) (Math.random() * rangeEnd) + rangeStart;
	private static int attempt = 0;
	private GameState gamestate;

	public GameState getGamestate() {
		return gamestate;
	}

	public void setGamestate(GameState gamestate) {
		this.gamestate = gamestate;
	}

	public static int getAttempt() {
		return attempt;
	}

	public static void setAttempt() {
		NumberGuessService.attempt = attempt + 1;
	}

	public NumberState compare(int guessNumber) {
		setAttempt();
		System.out.println(declaredNumber);
		if (guessNumber == declaredNumber) {
			setGamestate(GameState.ENDED);
			return NumberState.MATCHED;
		} else if (guessNumber > declaredNumber) {
			return NumberState.UPPER_BOUND;
		}

		else if (guessNumber < declaredNumber)
			return NumberState.LOWER_BOUND;
		return null;
	}

}
