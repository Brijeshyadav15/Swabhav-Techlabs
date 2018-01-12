package com.techlabs.tictactoe;

public class Cell {
	CellState cell;
	private final int row;
	private final int col;

	public Cell(int row, int col) {
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

	public char intialize() {
		switch (cell) {
		case EMPTY:
			return ' ';
		case CROSS:
			return 'x';
		case NOUGHT:
			return 'o';
		}
		return 0;
	}

}
