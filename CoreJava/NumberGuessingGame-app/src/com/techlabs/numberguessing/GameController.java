package com.techlabs.numberguessing;

public class GameController {
	private int rangeStart = 0;
	private int rangeEnd = 100;
	private int noOfAttempts = 5;

	public int getNoOfAttempts() {
		return noOfAttempts;
	}

	public void setNoOfAttempts(int noOfAttempts) {
		this.noOfAttempts = noOfAttempts;
	}

	public int getRangeStart() {
		return rangeStart;
	}

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

	public void setRangeStart(int rangeStart) {
		if (rangeStart < getRangeEnd())
			this.rangeEnd = rangeStart;
		else
			throw new RuntimeException(
					"Range starting number must be smaller than Range Ending number");
	}
}
