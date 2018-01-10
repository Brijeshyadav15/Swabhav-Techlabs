package com.techlabs.numberguessing;

public class NumberGuessService {
	private int declaredNumber = (int) (Math.random() * new GameController()
			.getRangeStart()) + new GameController().getRangeStart();
	private GameState gamestate;

	public GameState getGamestate() {
		return gamestate;
	}

	public void setGamestate(GameState gamestate) {
		this.gamestate = gamestate;
	}

	public NumberState compare(int guessNumber) {
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
