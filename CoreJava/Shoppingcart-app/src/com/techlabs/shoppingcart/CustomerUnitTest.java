package com.techlabs.shoppingcart;

import static org.junit.Assert.*;

import java.text.ParseException;
import java.text.SimpleDateFormat;

import org.junit.Test;

public class CustomerUnitTest {

	@Test
	public void customerOrderAddTest() throws ParseException {
		Customer customer = new Customer(1, "Brijesh");

		SimpleDateFormat sdf = new SimpleDateFormat("DD/MM/YY");
		Order order = new Order(1, sdf.parse("08/01/18"));

		LineItem lineItem1 = new LineItem(1, 3, new Product(4, "Product4",
				2000, 200f));

		order.addItem(lineItem1);
		customer.addOrder(order);
		int lengthofOrders = customer.getOrders().size();
		assertEquals(1, lengthofOrders);

		LineItem lineItem2 = new LineItem(1, 3, new Product(5, "Product5",
				2200, 250f));
		order.addItem(lineItem2);

	}
}
