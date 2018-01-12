package com.techlabs.tictactoe;

import java.util.Scanner;

public class Game {
	private Board board;
	private GameState currentstate;
	private CellState currentPlayer;

	public Game() {
		board = new Board();
		init();
	}

	public void init() {
		board.init();
		currentPlayer = CellState.CROSS;
		currentstate = GameState.RUNNING;
		do {
			playerMove(currentPlayer);
			paintBoard();
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
				System.out.println("'X', enter your move (row[1-"
						+ board.getRows() + "] column[1-" + board.getCols()
						+ "]):");
			} else {
				System.out
						.println("'O', enter your move (row[1-3] column[1-3]): ");
			}
			int row = input.nextInt() - 1;
			int col = input.nextInt() - 1;
			if (row >= 0 && row < board.getRows() && col >= 0
					&& col < board.getCols()
					&& board.cellstate[row][col].cell == CellState.EMPTY) {
				board.cellstate[row][col].cell = cell;
				board.setCurrentRow(row);
				board.setCurrentCol(col);
				validInput = true;
			} else {
				System.out.println("Move is not valid");
			}
		} while (!validInput);
	}

	public void updateGame(CellState cell) {
		if (board.checkWinner(cell)) {
			currentstate = (cell == CellState.CROSS) ? GameState.XWON
					: GameState.OWON;
		} else if (board.checkDraw()) {
			currentstate = GameState.DRAW;
		}
	}

	public void paintBoard() {
		for (int row = 0; row < board.getRows(); row++) {
			for (int col = 0; col < board.getCols(); col++) {
				System.out.print(board.cellstate[row][col].intialize());
				if (col < board.getCols() - 1)
					System.out.print("|");
			}
			System.out.println();
			if (row < board.getRows() - 1)
				System.out.println("-----");
		}
	}
}
