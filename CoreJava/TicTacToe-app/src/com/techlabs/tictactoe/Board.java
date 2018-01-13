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

	// public boolean checkWinner(CellState cell) {
	// return (cellstate[currentRow][0].cell == cell
	// && cellstate[currentRow][1].cell == cell
	// && cellstate[currentRow][2].cell == cell
	// || cellstate[0][currentCol].cell == cell
	// && cellstate[1][currentCol].cell == cell
	// && cellstate[2][currentCol].cell == cell
	// || currentRow == currentCol && cellstate[0][0].cell == cell
	// && cellstate[1][1].cell == cell && cellstate[2][2].cell == cell ||
	// currentRow
	// + currentCol == 2
	// && cellstate[0][2].cell == cell
	// && cellstate[1][1].cell == cell
	// && cellstate[2][0].cell == cell);
	// }

	public boolean checkWinner(CellState cell) {
		int counter = 1;
		
		// horizontal
		for (int i = 0; i < getRows(); i++) {
			for (int j = 0; j < getRows() - 1; j++) {
				if (cellstate[i][j] == cellstate[i][j + 1]) {
					counter = counter + 1;
					System.out.println("Current cell is:"+cellstate[i][j]);
					System.out.println("next cell is:"+cellstate[i][j + 1]);
					System.out.println("Counter is: " + counter);
				}
				
				if (counter == getRows()) {
					return true;
				}
			}
			counter = 1;
		}

		counter = 1;

		// vertical
		for (int i = 0; i < getCols(); i++) {
			for (int j = 0; j < getCols() - 1; j++) {
				if (cellstate[j][i].cell == cellstate[j + 1][i].cell) {
					counter = counter + 1;
				}
				if (counter == getCols()) {
					return true;
				}
			}
			counter = 1;
		}

		counter = 1;
		
		// diagonal from left-top to right-bottom
		for (int i = 0; i < getCols() - 1; i++) {
			if (cellstate[i][i].cell == cellstate[i + 1][i + 1].cell) {
				counter = counter + 1;
			}
			if (counter == getCols()) {
				return true;
			}
		}

		counter = 1;
		
		// diagonal from right-top to left-bottom
		for (int i = 0; i < getCols() - 1; i++) {
			if (cellstate[i][getCols() - 1 - i].cell == cellstate[i + 1][getCols()
					- 1 - (i + 1)].cell) {
				counter = counter + 1;
			}
			if (counter == getCols()) {
				return true;
			}
		}
		return false;
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