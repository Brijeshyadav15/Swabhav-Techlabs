package com.techlabs.shoppingcart;

import static org.junit.Assert.*;

import java.text.ParseException;
import java.text.SimpleDateFormat;

import org.junit.Test;

public class OrderUnitTest {

	@Test
	public void orderLineItemTest() throws ParseException {
		SimpleDateFormat sdf = new SimpleDateFormat("DD/MM/YY");
		Order order = new Order(1, sdf.parse("08/01/18"));

		LineItem lineItem1 = new LineItem(1, 3, new Product(4, "Product4", 2000,
				200f));
		
		LineItem lineItem2 = new LineItem(1, 3, new Product(5, "Product5", 2200,
				250f));
		
		order.addItem(lineItem1);
		int lengthofAdditem = order.getItems().size();
		assertEquals(1, lengthofAdditem);
		
		order.addItem(lineItem2);
		
	}
	
	@Test
	public void orderCheckOutCostTest() throws ParseException {
		SimpleDateFormat sdf = new SimpleDateFormat("DD/MM/YY");
		Order order = new Order(1, sdf.parse("08/01/18"));

		LineItem lineItem1 = new LineItem(1, 3, new Product(4, "Product4", 2000,
				200f));
		
		LineItem lineItem2 = new LineItem(1, 3, new Product(5, "Product5", 2200,
				250f));
		
		order.addItem(lineItem1);
		order.addItem(lineItem2);
		
		double finalprice = order.calcCheckOutCost();
		
		assertEquals(11250,finalprice,0.001);
		
	}
}
