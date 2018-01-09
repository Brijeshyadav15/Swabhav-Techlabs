package com.techlabs.shoppingcart;

import java.util.*;

public class Customer {

	private int id;
	private String name;

	private List<Order> orders = new ArrayList<Order>();

	public Customer(int id, String name) {
		super();
		this.id = id;
		this.name = name;
	}

	public int getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public List<Order> getOrders() {
		return orders;
	}

	public void addOrder(Order order) {
		orders.add(order);
	}

}
