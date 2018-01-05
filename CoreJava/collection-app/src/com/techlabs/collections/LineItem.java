package com.techlabs.collections;

public class LineItem {
	private int id;
	private String product;
	private int quantity;
	private double unitprice;

	public LineItem(int id, String product, int quantity, double unitprice) {
		super();
		this.id = id;
		this.product = product;
		this.quantity = quantity;
		this.unitprice = unitprice;
	}

	public int getId() {
		return id;
	}

	public String getProduct() {
		return product;
	}

	public int getQuantity() {
		return quantity;
	}

	public double getUnitprice() {
		return unitprice;
	}

	public double calcTotal() {
		return getQuantity() * getUnitprice();
	}
}
