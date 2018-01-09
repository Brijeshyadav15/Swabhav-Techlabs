package com.techlabs.shoppingcart;

public class LineItem {
	private int id;
	private int quantity;
	private Product products;

	public LineItem(int id, int quantity, Product product) {
		super();
		this.id = id > 0 ? id : 0;
		this.quantity = quantity > 0 ? quantity : 0;
		this.products = product;
	}

	public int getId() {
		return id;
	}

	public int getQuantity() {
		return quantity;
	}

	public Product getProduct() {
		return products;
	}

	public double costofLineItem() {
		return products.calcDiscountCost() * getQuantity();
	}

}
