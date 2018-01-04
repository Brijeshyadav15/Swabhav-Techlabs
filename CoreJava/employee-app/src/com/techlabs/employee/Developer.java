package com.techlabs.employee;

import java.util.*;

public class Developer extends Employee {
	private double pa = (this.getBasic() * 20) / 100;

	public Developer(String name, Date dob, double basic) {
		super(name, dob, basic);
	}

	public double getPa() {
		return pa;
	}

	@Override
	public double calcNetSalary() {
		return getBasic() + getPa();
	}

}
