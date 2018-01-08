package com.techlabs.unittesting;

import static org.junit.Assert.*;

import org.hamcrest.core.Is;
import org.hamcrest.core.IsEqual;
import org.junit.Test;

public class CalculatorTest {

	@Test
	public void testCalculator() {
		// Arrange
		Calculator calculator = new Calculator(3, 2);
		int actual = 5;
		// Act
		int result = calculator.add();

		// Assert
		assertEquals(actual, result);
	}

	@Test
	public void testNegativeValue() {
		// Arrange
		Calculator calculator = new Calculator(3, -2);
		boolean exceptionoccured = false;
		// Act
		try {
			int result = calculator.add();
		} catch (Exception e) {
			exceptionoccured = true;
		}

		// Assert
		assertTrue(exceptionoccured);
	}

}
