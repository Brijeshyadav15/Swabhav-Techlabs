package com.techlabs.assignment.interfaceinheritance;

public class FourWheeler implements Vehicles {
	public int wheels;
	public String type;

	public int getWheels() {
		return wheels;
	}

	public void setWheels(int wheels) {
		this.wheels = wheels;
	}

	public String getType() {
		return type;
	}

	public void setType(String type) {
		this.type = type;
	}

	@Override
	public String getDetails() {
		return " No of Wheels\t:" + getWheels() + "\n Engine Type\t:"
				+ getType();
	}

}
