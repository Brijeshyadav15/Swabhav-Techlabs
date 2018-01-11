package com.techlabs.tictactoe;

public class Tile {
	CellState cell;
	private final int row;
	private final int col;

	public Tile(int row, int col) {
		this.row = row;
		this.col = col;
	}

	public int getRow() {
		return row;
	}

	public int getCol() {
		return col;
	}

	public void clear() {
		cell = CellState.EMPTY;
	}

	public void intialize() {
		switch (cell) {
		case EMPTY:
			System.out.print(" ");
			break;
		case CROSS:
			System.out.print("x");
			break;
		case NOUGHT:
			System.out.print("o");
			break;
		}
	}

}
