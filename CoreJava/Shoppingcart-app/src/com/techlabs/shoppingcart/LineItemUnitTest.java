package com.techlabs.shoppingcart;

import static org.junit.Assert.*;

import org.junit.Test;

public class LineItemUnitTest {

	@Test
	public void LineItemTest() {
		LineItem lineItem = new LineItem(1, 4, new Product(1, "Product1", 2000,
				125f));

		double actual = lineItem.costofLineItem();

		assertEquals(7500, actual, 0.001);

	}
	
	@Test
	public void LineItemTestTwo() {
		LineItem lineItem = new LineItem(1, 4, new Product(1, "Product1", 2000,
				2600f));

		double actual = lineItem.costofLineItem();

		assertEquals(8000, actual, 0.001);

	}
	
	

}
