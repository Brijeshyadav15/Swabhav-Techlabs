package com.techlabs.vehicle.test;

import java.util.*;

import com.techlabs.vehicle.*;

public class TestVehicle {
	public static void main(String[] args) {
		IMoveable[] movers = {new Car(),new Truck(),new Bike()};
		Race(movers);
	}

	public static void Race(IMoveable[] moveables) {
		System.out.println("Race Starts");

		for (IMoveable moveable : moveables) {
			moveable.move();
		}
		System.out.println("Race Stops");
	}
}
