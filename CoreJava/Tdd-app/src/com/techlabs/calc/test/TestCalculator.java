package com.techlabs.calc.test;

import static org.junit.Assert.*;
import org.junit.Test;
import com.techlabs.calculator.Calculator;

public class TestCalculator {

	@Test
	public void shouldsquare_OddNumber() {
		// arrange
		Calculator calc = new Calculator();
		int expectedresult = 9;
		int actual = 0;

		// act
		try {
			actual = calc.squareOdd(3);
		} catch (Exception e) {
			e.printStackTrace();
		}
		
		// assert
		assertEquals(actual, expectedresult);
	}

	@Test
	public void shouldnotsquare_EvenNumber() {
		// arrange
		Calculator calc = new Calculator();
		int expectedresult = 9;
		boolean expectionoccured = false;

		// act

		try {
			int actual = calc.squareOdd(2);
		} catch (Exception e) {
			expectionoccured = true;
		}
		// assert
		assertTrue(expectionoccured);
	}
	
	@Test
	public void shouldnotsquare_NegativeNumber() {
		// arrange
		Calculator calc = new Calculator();
		boolean expectionoccured = false;

		// act

		try {
			int actual = calc.squareOdd(-3);
		} catch (Exception e) {
			expectionoccured = true;
		}
		// assert
		assertTrue(expectionoccured);
	}
	
	@Test
	public void shouldnotsquare_Zero() {
		// arrange
		Calculator calc = new Calculator();
		boolean exceptionoccured = false;

		// act

		try {
			int actual = calc.squareOdd(0);
		} catch (Exception e) {
			exceptionoccured = true;
		}
		// assert
		assertTrue(exceptionoccured);
	}
}
