package com.techlabs.tictactoe;

public class Board {
	private int rows = 3;
	private int cols = 3;

	public Board(int rows, int cols) {
		this.rows = rows;
		this.cols = cols;
	}

	public int getCols() {
		return cols;
	}

	public int getRows() {
		return rows;
	}

	Cell[][] cellstate;
	private int currentRow;
	private int currentCol;

	public int getCurrentRow() {
		return currentRow;
	}

	public void setCurrentRow(int currentRow) {
		this.currentRow = currentRow;
	}

	public int getCurrentCol() {
		return currentCol;
	}

	public void setCurrentCol(int currentCol) {
		this.currentCol = currentCol;
	}

	public Board() {
		cellstate = new Cell[rows][cols];
		for (int row = 0; row < rows; row++) {
			for (int col = 0; col < cols; col++)
				cellstate[row][col] = new Cell(row, col);
		}
	}

	public void init() {
		for (int row = 0; row < rows; ++row) {
			for (int col = 0; col < cols; ++col) {
				cellstate[row][col].clear(); // clear the cell content
			}
		}
	}

	public boolean checkDraw() {
		for (int row = 0; row < rows; row++) {
			for (int col = 0; col < cols; col++) {
				if (cellstate[row][col].cell == CellState.EMPTY)
					return false;
			}
		}
		return true;
	}

	public boolean checkWinner(CellState cell) {
		return (cellstate[currentRow][0].cell == cell
				&& cellstate[currentRow][1].cell == cell
				&& cellstate[currentRow][2].cell == cell
				|| cellstate[0][currentCol].cell == cell
				&& cellstate[1][currentCol].cell == cell
				&& cellstate[2][currentCol].cell == cell
				|| currentRow == currentCol && cellstate[0][0].cell == cell
				&& cellstate[1][1].cell == cell && cellstate[2][2].cell == cell || currentRow
				+ currentCol == 2
				&& cellstate[0][2].cell == cell
				&& cellstate[1][1].cell == cell
				&& cellstate[2][0].cell == cell);
	}

	public boolean markInput(int row, int col, CellState cell) {
		boolean validInput = false;
		if (row >= 0 && row < getRows() && col >= 0 && col < getCols()
				&& cellstate[row][col].cell == CellState.EMPTY) {
			cellstate[row][col].cell = cell;
			setCurrentRow(row);
			setCurrentCol(col);
			validInput = true;
		}
		return validInput;
	}
}