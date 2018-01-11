package com.techlabs.tictactoe;

import java.util.Scanner;

public class GameConsole {
	private GameController gamecontroller;
	private GameState currentstate;
	private CellState currentPlayer;

	public GameConsole() {
		gamecontroller = new GameController();
		init();
	}

	public void init() {
		gamecontroller.init();
		currentPlayer = CellState.CROSS;
		currentstate = GameState.RUNNING;
		do {
			playerMove(currentPlayer);
			gamecontroller.paintBoard();
			updateGame(currentPlayer);

			if (currentstate == GameState.XWON) {
				System.out.println("'X' won! Bye!");
			} else if (currentstate == GameState.OWON) {
				System.out.println("'O' won! Bye!");
			} else if (currentstate == GameState.DRAW) {
				System.out.println("It's Draw! Bye!");
			}

			currentPlayer = (currentPlayer == CellState.CROSS) ? CellState.NOUGHT
					: CellState.CROSS;
		} while (currentstate == GameState.RUNNING);

	}

	public void playerMove(CellState cell) {
		boolean validInput = false;
		Scanner input = new Scanner(System.in);
		do {
			if (cell == CellState.CROSS) {
				System.out
						.println("'X', enter your move (row[1-"+ gamecontroller.getRows()+"] column[1-"+ gamecontroller.getCols()+"]):");
			} else {
				System.out
						.println("'O', enter your move (row[1-3] column[1-3]): ");
			}
			int row = input.nextInt() - 1;
			int col = input.nextInt() - 1;
			if (row >= 0
					&& row < gamecontroller.getRows()
					&& col >= 0
					&& col < gamecontroller.getCols()
					&& gamecontroller.cellstate[row][col].cell == CellState.EMPTY) {
				gamecontroller.cellstate[row][col].cell = cell;
				gamecontroller.setCurrentRow(row);
				gamecontroller.setCurrentCol(col);
				validInput = true;
			} else {
				System.out.println("Move is not valid");
			}
		} while (!validInput);
	}

	public void updateGame(CellState cell) {
		if (gamecontroller.checkWinner(cell)) {
			currentstate = (cell == CellState.CROSS) ? GameState.XWON
					: GameState.OWON;
		} else if (gamecontroller.checkDraw()) {
			currentstate = GameState.DRAW;
		}
	}
}
