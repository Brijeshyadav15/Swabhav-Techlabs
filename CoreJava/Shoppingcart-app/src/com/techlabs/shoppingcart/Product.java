package com.techlabs.shoppingcart;

public class Product {
	private int id;
	private String name;
	private double cost;
	private float discount;

	public Product(int id, String name, double cost, float discount) {
		super();
		this.id = id > 0 ? id : 0;
		this.name = name;
		this.cost = cost > 0 ? cost : 0;
		this.discount = discount > 0 ? discount : 0f;
	}

	public int getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public double getCost() {
		return cost;
	}

	public float getDiscount() {
		return discount;
	}

	public double calcDiscountCost() {
		return cost > discount ? cost - (double) discount : cost;
	}

}
