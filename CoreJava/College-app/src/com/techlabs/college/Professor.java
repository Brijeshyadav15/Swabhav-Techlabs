package com.techlabs.college;

import java.util.*;

public class Professor extends Person implements SalariedEmployee {
	private int id;
	private String address;
	private Date dob;
	private double basic;
	private double hra;
	private double da;

	public Professor(int id, String address, Date dob, Double basic) {
		this.id = id;
		this.address = address;
		this.dob = dob;
		this.basic = basic;
		this.hra = basic / 2;
		this.da = basic/3;
	}

	public double getBasic() {
		return basic;
	}

	public double getHra() {
		return hra;
	}

	public double getDa() {
		return da;
	}

	public int getId() {
		return id;
	}

	public String getAddress() {
		return address;
	}

	public Date getDob() {
		return dob;
	}

	@Override
	public double calcSalary() {
		return getBasic() + getDa() + getHra();
	}

}
