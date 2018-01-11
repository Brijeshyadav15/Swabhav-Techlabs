package com.techlabs.tictactoe;

public class Tile {
	CellState cell;
	private int row;
	private int col;

	public Tile(int row, int col) {
		this.row = row;
		this.col = col;
	}

	public void clear() {
		cell = CellState.EMPTY;
	}

	public void intialize() {
		switch (cell) {
		case EMPTY:
			System.out.println(" ");
			break;
		case CROSS:
			System.out.println("x");
			break;
		case NOUGHT:
			System.out.println("o");
			break;
		}
	}

}
