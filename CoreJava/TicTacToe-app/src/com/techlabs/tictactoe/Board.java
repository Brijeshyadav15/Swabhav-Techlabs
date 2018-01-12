package com.techlabs.tictactoe;

public class Board {
	private int rows = 0;
	private int cols = 0;

	public Board(int rows, int cols) {
		this.rows = rows;
		this.cols = cols;

		cellstate = new Cell[rows][cols];
		for (int row = 0; row < getRows(); row++) {
			for (int col = 0; col < getCols(); col++)
				cellstate[row][col] = new Cell(row, col);
		}
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

	public void init() {
		for (int row = 0; row < rows; ++row) {
			for (int col = 0; col < cols; ++col) {
				cellstate[row][col].clear();
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
		return (checkRow(cell) || checkCol(cell) || checkDiagonal(cell));
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

	public boolean checkRow(CellState cell) {
		boolean rowCheck = false;
		for (int row = 0; row < getRows(); row++) {
			rowCheck = cellstate[currentRow][row].cell == cell ? true : false;
			System.out.println("Row Check is :" +cellstate[currentRow][row]);
			System.out.println("Row Check is :" +cell);
		}
		System.out.println("Row Check is :" +rowCheck);
		return rowCheck;
	}

	public boolean checkCol(CellState cell) {
		boolean colCheck = false;
		for (int col = 0; col < getCols(); col++) {
			colCheck = cellstate[col][currentCol].cell == cell ? true : false;
		}
		System.out.println("Col Check is :" +colCheck);
		return colCheck;
	}

	public boolean checkDiagonal(CellState cell) {
		boolean diagonalCheck = false;
		for (int col = 0; col < getCols(); ++col) {
			diagonalCheck = currentRow == currentCol
					&& cellstate[col][col].cell == cell ? true : false;
		}
		System.out.println("Diagonal Check is :" +diagonalCheck);
		return diagonalCheck;
	}

	public boolean checkOppDiagonal(CellState cell) {
		boolean oppDiagonalCheck = false;
		int n = getCols() - 1;
		for (int col = 0; col < getCols(); ++col) {
			oppDiagonalCheck = currentRow + currentCol == n
					&& cellstate[col][n - col].cell == cell ? true : false;
		}
		System.out.println("Opposite Diagonal Check is :" +oppDiagonalCheck);
		return oppDiagonalCheck;
	}
}