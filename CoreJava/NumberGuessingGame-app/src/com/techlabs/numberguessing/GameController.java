package com.techlabs.numberguessing;

public class GameController {

	private int rangeStart;
	private int rangeEnd;
	private final int noOfAttempts;
	private GameState gamestate;
	private final int declaredNumber;

	public GameController(int rangeStart, int rangeEnd, int noOfAttempts) {
		this.rangeStart = rangeStart;
		this.rangeEnd = rangeEnd;
		this.noOfAttempts = noOfAttempts;
		this.declaredNumber = (int) (Math.random() * getRangeEnd())
				+ getRangeStart();
	}

	public int getDeclaredNumber() {
		return declaredNumber;
	}

	public GameState getGamestate() {
		return gamestate;
	}

	public void setGamestate(GameState gamestate) {
		this.gamestate = gamestate;
	}

	public int getNoOfAttempts() {
		return noOfAttempts;
	}

	public int getRangeStart() {
		return rangeStart;
	}

	public int getRangeEnd() {
		return rangeEnd;
	}

	public NumberState compare(int guessNumber) {
		if (guessNumber == declaredNumber) {
			setGamestate(GameState.WON);
			return NumberState.MATCHED;
		} else if (guessNumber > declaredNumber) {
			setGamestate(GameState.STOP);
			return NumberState.UPPER_BOUND;
		} else if (guessNumber < declaredNumber) {
			setGamestate(GameState.STOP);
			return NumberState.LOWER_BOUND;
		}
		return null;
	}

	public int checkattempts(int attempts) {
		return getNoOfAttempts() - attempts;
	}
}
