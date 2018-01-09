package com.techlabs.shoppingcart.test;

import java.text.*;
import java.util.*;

import com.techlabs.shoppingcart.*;

public class TestShoppingCart {
	static SimpleDateFormat sdf = new SimpleDateFormat("DD/MM/YY");

	public static void main(String[] args) throws ParseException {
		addCustomer();
	}

	private static void printInvoice(Customer customer) {
		System.out.println("Customer Id: \t" + customer.getId()
				+ "\t\t\t\tName: \t" + customer.getName() + "\n");

		List<Order> orders = customer.getOrders();
		for (Order order : orders) {
			System.out.println("Order Id: \t" + order.getOrderid()
					+ "\tOrder Date: \t" + sdf.format(order.getOrderDate())
					+ "\n");

			System.out
					.println("Id\tProduct Name\t Cost \tDiscount\tQuantity\tPrice");

			List<LineItem> items = order.getItems();
			for (LineItem lineitem : items) {
				System.out.println(lineitem.getId() + "\t"
						+ lineitem.getProduct().getName() + "\t "
						+ lineitem.getProduct().getCost() + "\t "
						+ lineitem.getProduct().getDiscount() + "\t\t  "
						+ lineitem.getQuantity() + "\t\t"
						+ lineitem.costofLineItem() + "\n");

			}

			System.out.println("\n" + "Total " + "\t\t\t\t\t\t\t\t"
					+ order.calcCheckOutCost() + "\n");
		}
	}

	private static void addCustomer() throws ParseException {

		Order order1 = new Order(1, sdf.parse("08/01/18"));

		order1.addItem(new LineItem(1, 4, new Product(1, "product1", 2000.00,
				100.00f)));
		order1.addItem(new LineItem(2, 3, new Product(2, "product2", 2500.00,
				1230.00f)));
		order1.addItem(new LineItem(3, 6, new Product(3, "product3", 3500.00,
				1000.00f)));

		Order order2 = new Order(2, sdf.parse("09/01/18"));

		order2.addItem(new LineItem(6, 4, new Product(1, "product3", 2000.00,
				100.00f)));
		order2.addItem(new LineItem(7, 3, new Product(2, "product2", 2500.00,
				1230.00f)));
		order2.addItem(new LineItem(8, 6, new Product(4, "product4", 3500.00,
				1000.00f)));

		Customer customer = new Customer(1, "Brijesh");
		customer.addOrder(order1);
		customer.addOrder(order2);
		printInvoice(customer);
	}

}
