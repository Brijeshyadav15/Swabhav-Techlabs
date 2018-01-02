package com.techlabs.assignment.interfaceinheritance;

public class Car extends FourWheeler {
	private int mileage;
	private int seats;

	public int getMileage() {
		return mileage;
	}

	public void setMileage(int mileage) {
		this.mileage = mileage;
	}

	public int getSeats() {
		return seats;
	}

	public void setSeats(int seats) {
		this.seats = seats;
	}

	@Override
	public String getDetails() {
		return super.getDetails() + "\n Mileage\t:" + getMileage()
				+ "\n No of Seats\t:" + getSeats();
	}
}
