package com.techlabs.numberguessing;

public enum GameState {
	START, STOP, RUNNING, WAITING, ENDED,WON;
	
	@Override
	public String toString() {
		switch (this) {
		case START:
			return "Game has started";
		case STOP:
			return "Game has stopped";
		case RUNNING:
			return "Game is running";
		case WAITING:
			return "Game is in waiting mode";
		case ENDED:
			return "Game has ended";
		case WON:
			return "Player won";
		}
		return null;
	}
}
