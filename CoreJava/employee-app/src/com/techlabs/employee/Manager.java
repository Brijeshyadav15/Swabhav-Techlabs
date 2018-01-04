package com.techlabs.employee;

import java.util.Date;

public class Manager extends Employee {
	private double hra = (this.getBasic() * 50) / 100;
	private double da = (this.getBasic() * 40) / 100;

	public Manager(String name, Date dob, double basic) {
		super(name, dob, basic);
	}

	public double getHra() {
		return hra;
	}

	public double getDa() {
		return da;
	}

	@Override
	public double calcNetSalary() {
		return getBasic() + getDa() + getHra();
	}

}
