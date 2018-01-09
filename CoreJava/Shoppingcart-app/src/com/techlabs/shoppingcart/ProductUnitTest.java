package com.techlabs.shoppingcart;

import static org.junit.Assert.*;

import org.junit.Test;

public class ProductUnitTest {

	@Test
	public void Productaddedtest() {
		// arrange
		Product product1 = new Product(1, "product1", 2000.00, 100.00f);

		// act
		double finalcost = product1.calcDiscountCost();

		// assert
		assertEquals(1900.00, finalcost,0.001);
	}
	
	@Test
	public void ProductaddedtestTwo() {
		// arrange
		Product product2 = new Product(1, "product1", 2500.00, 26000.00f);
		// act
		double finalcost = product2.calcDiscountCost();

		// assert
		assertEquals(2500.00, finalcost,0.001);
	}
}
