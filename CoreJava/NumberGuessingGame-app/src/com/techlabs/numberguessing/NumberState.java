package com.techlabs.numberguessing;

public enum NumberState {
	LOWER_BOUND, UPPER_BOUND, MATCHED;

	@Override
	public String toString() {
		switch (this) {
		case LOWER_BOUND:
			return "Guessed Number is less than original number";
		case UPPER_BOUND:
			return "Guessed Number is greater than original number";
		case MATCHED:
			return "You have guessed the number correctly";
		}
		return null;
	}
}