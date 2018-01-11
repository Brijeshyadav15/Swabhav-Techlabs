package com.techlabs.tictactoe;

public class GameController {
	private static final int rows = 3;
	private static final int cols = 3;

	Tile[][] cellstate;
	private int currentRow;
	private int currentCol;

	public GameController() {
		cellstate = new Tile[rows][cols];
		for (int row = 0; row < rows; row++) {
			for (int col = 0; col < cols; col++)
				cellstate[row][col] = new Tile(row, col);
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

	public void paintBoard() {

	}

}
