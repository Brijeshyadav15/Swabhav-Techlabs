package lsp.violation.test;

import lsp.violation.*;

public class TestLSPViolation {
	public static void main(String[] args) {
		shouldnotchange_height_ifwidthischanged(new Rectangle(5, 2));
		shouldnotchange_height_ifwidthischanged(new Square(5));
	}

	private static void shouldnotchange_height_ifwidthischanged(
			Rectangle rectangle) {
		int before = rectangle.getHeight();
		rectangle.setWidth(50);
		int after = rectangle.getHeight();

		System.out.println("Height before:" + before);
		System.out.println("Height After:" + after);

	}
}
