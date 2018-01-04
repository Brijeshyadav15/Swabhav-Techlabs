package com.techlabs.unittesting;

import static org.junit.Assert.*;

import org.hamcrest.core.Is;
import org.junit.Test;

public class CalculatorTest {

	@Test
	public void testCalculator() {
		// Arrange
		Calculator calculator = new Calculator(3, 2);

		// Act
		int result = calculator.add();

		// Assert
		assertEquals(5, result);
	}

	@Test
	public void testArrangeOne() {
		// Arrange
		Calculator calculator = new Calculator(3, -2);

		// Act
		int result = calculator.add();

		// Assert
		fail("Integer values can't be negative");
		// assertEquals(5, result);

	}

}
