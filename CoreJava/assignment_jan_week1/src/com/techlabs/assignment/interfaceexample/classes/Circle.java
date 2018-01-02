package com.techlabs.assignment.interfaceexample.classes;

import com.techlabs.assignment.interfaceexample.*;

public class Circle implements ShapeInterface {
	private int radius;

	public int getRadius() {
		return radius;
	}

	public void setRadius(int radius) {
		this.radius = radius;
	}

	@Override
	public int calcArea() {
		return (int) (3.14 * (this.getRadius() * this.getRadius()));
	}

	@Override
	public int calcPerimeter() {
		return (int) (2 * 3.14 * this.getRadius());
	}
}
