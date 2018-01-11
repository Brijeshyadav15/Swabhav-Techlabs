package com.techlabs.tictactoe;

import java.util.*;

public class GameConsole {
	private GameController gamecontroller;
	private GameState currentstate;
	private CellState currentPlayer;

	public GameConsole() {
		gamecontroller = new GameController();
		init();
		do {
	         playerMove(currentPlayer); 
	         gamecontroller.paintBoard();
	         updateGame(currentPlayer); // update currentState
	         // Print message if game-over
	         if (currentstate == GameState.XWON) {
	            System.out.println("'X' won! Bye!");
	         } else if (currentstate == GameState.OWON) {
	            System.out.println("'O' won! Bye!");
	         } else if (currentstate == GameState.DRAW) {
	            System.out.println("It's Draw! Bye!");
	         }
	         // Switch player
	         currentPlayer = (currentPlayer == CellState.CROSS) ? CellState.NOUGHT : CellState.CROSS;
	      } while (currentstate == GameState.RUNNING);  // repeat until game-over
	}

	public void init() {
		gamecontroller.init();
		currentPlayer = CellState.CROSS;
		currentstate = GameState.RUNNING;
	}

	public void playerMove(CellState cell) {
		boolean validInput = false;
		Scanner input = new Scanner(System.in);
		do {
			if (cell == CellState.CROSS) {
				System.out
						.println("Player 'X', enter your move (row[1-3] column[1-3]): ");
			} else {
				System.out
						.println("Player 'O', enter your move (row[1-3] column[1-3]): ");
			}
			int row = input.nextInt() - 1;
			int col = input.nextInt() - 1;
			if (row >= 0
					&& row < gamecontroller.rows
					&& col >= 0
					&& col < gamecontroller.cols
					&& gamecontroller.cellstate[row][col].cell == CellState.EMPTY) {
				gamecontroller.cellstate[row][col].cell = cell;
				gamecontroller.currentRow = row;
				gamecontroller.currentCol = col;
				validInput = true;
			} else {
				System.out.println("This move at (" + (row + 1) + ","
						+ (col + 1) + ") is not valid. Try again...");
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
