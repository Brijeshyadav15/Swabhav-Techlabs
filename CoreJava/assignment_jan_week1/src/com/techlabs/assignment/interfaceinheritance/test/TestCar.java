package com.techlabs.assignment.interfaceinheritance.test;

import com.techlabs.assignment.interfaceinheritance.*;

public class TestCar {
	public static void main(String[] args) {
		Car car = new Car();
		car.setWheels(4);
		car.setType("Diesel");
		car.setMileage(15);
		car.setSeats(5);
		System.out.println(car.getDetails());
	}
}
