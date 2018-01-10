package srp.refractor;

import java.util.*;

public class Invoice {
	private final String id;
	private final String name;
	private final double cost;
	private final double discount;
	private final static double GST = 5 ;

	public Invoice(String name, double cost, double discount) {
		this.id = UUID.randomUUID().toString().replace("-","");
		this.name = name;
		this.cost = cost;
		this.discount = discount;
	}

	public String getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public double getCost() {
		return cost;
	}

	public double getDiscount() {
		return discount;
	}

	public double getGST() {
		return GST;
	}

	protected double calcDiscount() {
		return Math.abs(this.getDiscount() - this.getCost());
	}

	protected double calcTax() {
		return (getGST() * getCost() - calcDiscount()) /100;
	}

	protected double calcTotal() {
		return (this.getCost() - this.getDiscount()) + this.calcTax();
	}	
}
