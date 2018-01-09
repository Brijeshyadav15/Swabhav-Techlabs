package com.techlabs.shoppingcart;

import java.text.*;
import java.util.*;

public class Order {
	private int orderid;
	private Date orderDate;
	private List<LineItem> items = new ArrayList<LineItem>();
	SimpleDateFormat sdf = new SimpleDateFormat("DD/MM/YY");
	
	public Order(int orderid, Date orderDate) {
		super();
		this.orderid = orderid > 0 ? orderid : null;
		this.orderDate = orderDate;
	}

	public void addItem(LineItem lineItem) {
		items.add(lineItem);
	}

	public int getOrderid() {
		return orderid;
	}

	public Date getOrderDate() {
		return orderDate;
	}

	public List<LineItem> getItems() {
		return items;
	}

	public double calcCheckOutCost() {
		double checkoutcost = 0;
		for (LineItem item : items) {
			checkoutcost += item.costofLineItem();
		}
		return checkoutcost;
	}
}
